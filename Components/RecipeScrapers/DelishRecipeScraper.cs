using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using HtmlAgilityPack;

namespace Components.RecipeScrapers
{
    public class DelishRecipeScraper : RecipeScraper
    {
        private DelishRecipeScraper()
        {
        }

        public static RecipeScraper Instance { get; } = new DelishRecipeScraper();

        private double ConvertFactionToDouble(IEnumerable<string> faction)
        {
            double result = 0.0;
            foreach (var number in faction)
            {
                if (number.Contains("/"))
                {
                    var numberSplit = number.Split('/');
                    result += double.Parse(numberSplit[0]) / double.Parse(numberSplit[1]);
                }
                else
                {
                    result += double.Parse(number);
                }
            }
            return result;
        }
        public override TimeSpan GetCookTime()
        {
            var totalTimeHtmlNode = HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "recipe-details-item total-time").ToList()[0];
            var totalTimeString = string.Join(" ", totalTimeHtmlNode.Descendants("span")
                .Where(x => x.GetAttributeValue("class", "nothing") == "total-time-amount").ToList()[0].InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
            Debug.WriteLine(ConvertStringToTimeSpan(totalTimeString) - GetPrepTime());
            return ConvertStringToTimeSpan(totalTimeString) - GetPrepTime();
        }

        public override TimeSpan GetPrepTime()
        {
            var prepTimeHtmlNode = HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "recipe-details-item prep-time").ToList()[0];
            var prepTimeString = string.Join(" ", prepTimeHtmlNode.Descendants("span")
                .Where(x => x.GetAttributeValue("class", "nothing") == "prep-time-amount").ToList()[0].InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
            Debug.WriteLine(prepTimeString);
            return ConvertStringToTimeSpan(prepTimeString);
        }

        public override string GetRecipeName()
        {
            Debug.WriteLine(HtmlDocument.DocumentNode.Descendants("h1").First().InnerText);
            return HtmlDocument.DocumentNode.Descendants("h1").First().InnerText;
        }

        public override string GetYield()
        {
            var yieldHtmlNode = HtmlDocument.DocumentNode
                .Descendants("div").First(x => x.GetAttributeValue("class", "nothing") == "recipe-details-item yields");
            var yield = string.Join(" ", yieldHtmlNode.Descendants("span")
                .Where(x => x.GetAttributeValue("class", "nothing") == "yields-amount").ToList()[0].InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
            Debug.WriteLine(yield);
            return yield;
        }

        public override void SetIngredients(Recipe recipe)
        {
            var ingredientsBodyNode = HtmlDocument.DocumentNode
                .Descendants("div").First(x => x.GetAttributeValue("class", "nothing") == "ingredients-body");
            foreach (var ingredientSectionHtmlNode in ingredientsBodyNode.Descendants().Where(x => x.GetAttributeValue("class", "nothing").Contains("ingredient-section")))
            {
                var ingredientsUse = "";
                var ingredientTitleList = ingredientSectionHtmlNode.Descendants()
                    .Where(x => x.GetAttributeValue("class", "nothing") == "ingredient-title").ToList();
                if (ingredientTitleList.Count > 0)
                {
                    var numberWordsToSkip = 2;
                    if (ingredientTitleList.First().InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)[1] != "The")
                    {
                        numberWordsToSkip--;
                    }
                    ingredientsUse = string.Join(" ", ingredientTitleList.First().InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Skip(numberWordsToSkip));
                }
                //Debug.WriteLine(ingredientSectionHtmlNode.Descendants().First(x => x.GetAttributeValue("class", "nothing") == "ingredient-lists").Descendants("div").Count());
                foreach (var ingredientHtmlNode in ingredientSectionHtmlNode.Descendants().First(x => x.GetAttributeValue("class", "nothing") == "ingredient-lists").Descendants("div"))
                {
                    //Debug.WriteLine(ingredientHtmlNode.GetAttributeValue("class","fuck"));
                    var amountHtmlNode = ingredientHtmlNode.Descendants("span")
                        .Where(x => x.GetAttributeValue("class", "nothing") == "ingredient-amount").ToList();
                    var amount = 0.0;
                    var measurement = ConvertStringToMeasurement("");
                    if (amountHtmlNode.Count != 0)
                    {
                        var amountSplit = amountHtmlNode[0].InnerText
                            .Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
                        if (amountSplit.Length != 0)
                        {
                            if (amountSplit.Length >= 2)
                            {
                                measurement = ConvertStringToMeasurement(amountSplit.Last());
                                amount = ConvertFactionToDouble(amountSplit.Take(amountSplit.Length - 1));
                            }
                            else
                            {
                                amount = ConvertFactionToDouble(amountSplit.Take(1));
                            }
                        }
                    }
                    var ingredientName = WebUtility.HtmlDecode(ingredientHtmlNode
                        .Descendants("span").First(x => x.GetAttributeValue("class", "nothing") == "ingredient-description")
                        .InnerText);
                    recipe.AddIngredient(ingredientsUse, new Ingredient(amount, ingredientName, measurement));
                }
            }

            //foreach (var key in recipe.Ingredients.Keys)
            //{
            //    foreach (var value in recipe.Ingredients[key])
            //    {
            //        Debug.WriteLine(key+" ("+value.Quantity+" "+value.Measurement+" "+value.Name+")");
            //    }
            //}
        }
        public override void SetInstructions(Recipe recipe)
        {
            var instructionsBodyNode = HtmlDocument.DocumentNode
                .Descendants("div").First(x => x.GetAttributeValue("class", "nothing") == "directions-body");
            foreach (var instructionSectionHtmlNode in instructionsBodyNode.Descendants().Where(x => x.GetAttributeValue("class", "nothing").Contains("direction-section")))
            {
                var instructionsUse = "";
                var instructionTitleList = instructionSectionHtmlNode.Descendants()
                    .Where(x => x.GetAttributeValue("class", "nothing") == "direction-title").ToList();
                if (instructionTitleList.Count > 0)
                {
                    instructionsUse = string.Join(" ", instructionTitleList.First().InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
                }
                //Debug.WriteLine(ingredientSectionHtmlNode.Descendants().First(x => x.GetAttributeValue("class", "nothing") == "ingredient-lists").Descendants("div").Count());
                var instructions = new List<string>();
                foreach (var instructionHtmlNode in instructionSectionHtmlNode.Descendants().First(x => x.GetAttributeValue("class", "nothing") == "direction-lists").Descendants("li"))
                {
                    //Debug.WriteLine(ingredientHtmlNode.GetAttributeValue("class","fuck"));
                    instructions.Add(WebUtility.HtmlDecode(instructionHtmlNode.InnerText));
                }
                recipe.AddInstruction(instructionsUse + ": " + string.Join(Environment.NewLine,instructions.ToArray()));
            }

            foreach (var instruction in recipe.Instructions)
            {
                Debug.WriteLine(instruction);
            }
        }

        public override void setNotes(Recipe recipe)
        {
        }
    }
}