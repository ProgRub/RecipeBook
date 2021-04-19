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
            double amount = double.Parse(ingredientNode.Descendants("span").First().GetAttributeValue("data-amount", "nothing"));
            Measurement measurement = IRecipeScraper.ConvertStringToMeasurement(ingredientNode.GetAttributeValue("data-unit", "unit"));
            var innerTextSplit = ingredientNode.InnerText.Split(null);
            Measurement possibleMeasurement = IRecipeScraper.ConvertStringToMeasurement(innerTextSplit.ToList()[1]);
            int stringsToSkip = 1;
            if (measurement != possibleMeasurement) { measurement = possibleMeasurement; stringsToSkip++; }
            return new Ingredient(amount, WebUtility.HtmlDecode(string.Join(" ", innerTextSplit.Skip(stringsToSkip).ToArray())), measurement);
        }

        public Yield ConvertInfoToYield(List<HtmlNode> yieldInfo)
        {
            foreach (var item in yieldInfo.Take(yieldInfo.Count - 1))
            {
                Debug.WriteLine(item.GetAttributeValue("data-amount", "nothing"));
            }
            double minimum = double.Parse(yieldInfo[0].GetAttributeValue("data-amount", "nothing")), maximum;
            try
            {
                maximum = double.Parse(yieldInfo[1].GetAttributeValue("data-amount", "nothing"));
            }
            catch (Exception)
            {
                maximum = minimum;
            }
            return new Yield(IRecipeScraper.ConvertStringToMeasurement(yieldInfo[0].GetAttributeValue("data-unit", "serving")), minimum, maximum);
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
            Yield yield = ConvertInfoToYield(recipeBasics.Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-yield").ToList()[0].Descendants("span").Where(x => x.GetAttributeValue("data-amount", "nothing") != "nothing").ToList());
            //Debug.WriteLine(yield.Measurement+" "+yield.MinimumQuantity+" "+yield.MaximumQuantity);
            var ingredientsHtml = htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-ingredients").ToList()[0].Descendants("li");
            Recipe recipe = new Recipe(recipeName, prepTime, cookTime, yield, url);
            foreach (var ingredient in ingredientsHtml)
            {
                recipe.AddIngredient(ConvertHtmlNodeToIngredient(ingredient));
                Debug.WriteLine(recipe.Ingredients.Last().Quantity + " " + recipe.Ingredients.Last().Measurement + " " + recipe.Ingredients.Last().Name);
            }
            foreach (var instruction in htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-instructions").ToList()[0].Descendants("li"))
            {
                recipe.AddInstruction(WebUtility.HtmlDecode(instruction.InnerText));
                Debug.WriteLine(recipe.Instructions.Last());
            }
            foreach (var note in htmlDoc.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes").ToList()[0].Descendants("p"))
            {
                recipe.AddNote(WebUtility.HtmlDecode(note.InnerText));
                Debug.WriteLine(recipe.Notes.Last());
            }
            return recipe;
        }
    }
}