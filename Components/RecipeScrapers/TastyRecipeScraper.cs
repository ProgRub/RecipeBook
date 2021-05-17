using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;

namespace Components.RecipeScrapers
{
    public class TastyRecipeScraper : RecipeScraper
    {
        private TastyRecipeScraper()
        {
        }

        public static RecipeScraper Instance { get; } = new TastyRecipeScraper();

        public override TimeSpan GetCookTime()
        {
            var recipeBasics = HtmlDocument.DocumentNode.Descendants("span");
            return ConvertStringToTimeSpan(recipeBasics
                .Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-cook-time").ToList()[0]
                .InnerText);
        }

        public override TimeSpan GetPrepTime()
        {
            var recipeBasics = HtmlDocument.DocumentNode.Descendants("span");
            return ConvertStringToTimeSpan(recipeBasics
                .Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-prep-time").ToList()[0]
                .InnerText);
        }

        public override string GetRecipeName()
        {
            return HtmlDocument.DocumentNode.Descendants("h2").ToList()[0].InnerText;
        }

        public override string GetYield()
        {
            var recipeBasics = HtmlDocument.DocumentNode.Descendants("span");
            var yieldInfo = recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-yield").ToList()[0];
            yieldInfo.ChildNodes.RemoveAt(yieldInfo.ChildNodes.Count - 1);
            return yieldInfo.InnerText;
        }

        public override void SetIngredients(Recipe recipe)
        {
            var ingredientsHtml = HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-ingredients").ToList()[0];
            var ingredientsUse = "";
            foreach (var item in ingredientsHtml.Descendants())
            {
                if (item.Name == "h4")
                {
                    ingredientsUse = item.InnerText.Remove(item.InnerText.Length-1);
                    Debug.WriteLine(ingredientsUse);
                }
                else if (item.Name == "li")
                {
                    double amount;
                    var stringsToSkip = 0;
                    try
                    {
                        if (!double.TryParse(item.Descendants("span").First().GetAttributeValue("data-amount", "nothing"), out amount))
                        {
                            amount = 0;
                        }
                        else
                        {
                            stringsToSkip++;
                        }
                    }
                    catch (Exception)
                    {
                        amount = 0;
                    }
                    var measurement = ConvertStringToMeasurement(item.GetAttributeValue("data-unit", "unit"));
                    var innerTextSplit = item.InnerText.Split(null);
                    var possibleMeasurement = ConvertStringToMeasurement(innerTextSplit.ToList()[1]);
                    if (measurement != possibleMeasurement) { measurement = possibleMeasurement; stringsToSkip++; }
                    recipe.AddIngredient(ingredientsUse, new Ingredient(amount, WebUtility.HtmlDecode(string.Join(" ", innerTextSplit.Skip(stringsToSkip).ToArray())), measurement));
                    Debug.WriteLine(recipe.Ingredients.Last().Value.Last().Quantity + " " + recipe.Ingredients.Last().Value.Last().Measurement + " " + recipe.Ingredients.Last().Value.Last().Name);
                }
            }
        }

        public override void SetInstructions(Recipe recipe)
        {
            foreach (var instruction in HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-instructions").ToList()[0].Descendants("li"))
            {
                recipe.AddInstruction(WebUtility.HtmlDecode(instruction.InnerText));
                Debug.WriteLine(recipe.Instructions.Last());
            }
        }

        public override void setNotes(Recipe recipe)
        {
            if (HtmlDocument.DocumentNode.Descendants("div").Any(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes"))
            {
                foreach (var note in HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes").ToList()[0].Descendants("p"))
                {
                    recipe.AddNote(WebUtility.HtmlDecode(note.InnerText));
                    Debug.WriteLine(recipe.Notes.Last());
                }
            }
        }
    }
}