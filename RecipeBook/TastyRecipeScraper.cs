using HtmlAgilityPack;
using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace RecipeBook
{
    public class TastyRecipeScraper : IRecipeScraper
    {
        public Ingredient ConvertHtmlNodeToIngredient(HtmlNode ingredientNode)
        {
            double amount;
            int stringsToSkip = 0;
            try
            {
                if (!double.TryParse(ingredientNode.Descendants("span").First().GetAttributeValue("data-amount", "nothing"), out amount))
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
            Measurement measurement = IRecipeScraper.ConvertStringToMeasurement(ingredientNode.GetAttributeValue("data-unit", "unit"));
            var innerTextSplit = ingredientNode.InnerText.Split(null);
            Measurement possibleMeasurement = IRecipeScraper.ConvertStringToMeasurement(innerTextSplit.ToList()[1]);
            if (measurement != possibleMeasurement) { measurement = possibleMeasurement; stringsToSkip++; }
            return new Ingredient(amount, WebUtility.HtmlDecode(string.Join(" ", innerTextSplit.Skip(stringsToSkip).ToArray())), measurement);
        }

        public string ConvertInfoToYield(HtmlNode yieldInfo)
        {
            yieldInfo.ChildNodes.RemoveAt(yieldInfo.ChildNodes.Count - 1);
            return yieldInfo.InnerText;
        }

        public TimeSpan ConvertStringToTimeSpan(string timeString)
        {
            var timeSplit = timeString.Split(new char[] { ' ' });
            int totalMinutes = 0;
            for (int index = 0; index < timeSplit.Length; index += 2)
            {
                if (timeSplit[index + 1].ToLower().Contains("min"))
                {
                    totalMinutes += int.Parse(timeSplit[index]);
                }
                else if (timeSplit[index + 1].ToLower().Contains("hour"))
                {
                    totalMinutes += int.Parse(timeSplit[index]) * 60;
                }
            }
            return new TimeSpan(totalMinutes / 60, totalMinutes % 60, 0);
        }

        public Recipe ScrapeRecipe(string url)
        {
            Debug.WriteLine("HERE");
            var htmlWeb = new HtmlWeb();
            var htmlDoc = htmlWeb.Load(url);
            var recipeName = htmlDoc.DocumentNode.Descendants("h2").ToList()[0].InnerText;
            var recipeBasics = htmlDoc.DocumentNode.Descendants("span");
            TimeSpan cookTime = ConvertStringToTimeSpan(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-cook-time").ToList()[0].InnerText);
            TimeSpan prepTime = ConvertStringToTimeSpan(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-prep-time").ToList()[0].InnerText);
            string yield = ConvertInfoToYield(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-yield").ToList()[0]);
            var ingredientsHtml = htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-ingredients").ToList()[0];
            Recipe recipe = new Recipe(recipeName, prepTime, cookTime, yield, url);
            string ingredientsUse = "";
            foreach (var item in ingredientsHtml.Descendants())
            {
                if (item.Name == "h4")
                {
                    ingredientsUse = item.InnerText;
                    Debug.WriteLine(ingredientsUse);
                }
                else if (item.Name == "li")
                {
                    recipe.AddIngredient(ingredientsUse, ConvertHtmlNodeToIngredient(item));
                    Debug.WriteLine(recipe.Ingredients.Last().Value.Last().Quantity + " " + recipe.Ingredients.Last().Value.Last().Measurement + " " + recipe.Ingredients.Last().Value.Last().Name);
                }
            }
            foreach (var instruction in htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-instructions").ToList()[0].Descendants("li"))
            {
                recipe.AddInstruction(WebUtility.HtmlDecode(instruction.InnerText));
                Debug.WriteLine(recipe.Instructions.Last());
            }
            if(htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes").Count() > 0){ 
            foreach (var note in htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes").ToList()[0].Descendants("p"))
            {
                recipe.AddNote(WebUtility.HtmlDecode(note.InnerText));
                Debug.WriteLine(recipe.Notes.Last());
            }
            }
            return recipe;
        }
    }
}