using System;
using System.Linq;

namespace Components.RecipeScrapers
{
    public class WPRMRecipeScraper : RecipeScraper
    {
        private WPRMRecipeScraper()
        {
        }

        public static RecipeScraper Instance { get; } = new WPRMRecipeScraper();

        public override TimeSpan GetCookTime()
        {
            return ConvertStringToTimeSpan(HtmlDocument.DocumentNode.Descendants("div").First(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-cook-time-container")).Descendants("span").Where(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-time")).ToList()[1].InnerText);
        }

        public override TimeSpan GetPrepTime()
        {
            return ConvertStringToTimeSpan(HtmlDocument.DocumentNode.Descendants("div").First(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-prep-time-container")).Descendants("span").Where(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-time")).ToList()[1].InnerText);
        }

        public override string GetRecipeName()
        {
            return HtmlDocument.DocumentNode.Descendants("h2").First().InnerText;
        }

        public override string GetYield()
        {
            return HtmlDocument.DocumentNode.Descendants("span")
                .First(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-servings-with-unit")).InnerText;
        }

        public override void SetIngredients(Recipe recipe)
        {
            foreach (var ingredientsSection in HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-group"))
            {
                var ingredientsUse = "";
                if (ingredientsSection.Descendants("h4").Any())
                {
                    //ingredientsUse = ingredientsSection.Descendants("h4").First().InnerText;

                    var numberWordsToSkip = 2;
                    if (ingredientsSection.Descendants("h4").First().InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)[1] != "the")
                    {
                        numberWordsToSkip--;
                    }
                    ingredientsUse = string.Join(" ", ingredientsSection.Descendants("h4").First().InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Skip(numberWordsToSkip));
                    ingredientsUse = ingredientsUse.First().ToString().ToUpper() + ingredientsUse.Substring(1);
                }
                foreach (var ingredientHtmlNode in ingredientsSection.Descendants("li"))
                {
                    var amount = ConvertFactionToDouble(ingredientHtmlNode.Descendants("span").First(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-amount").InnerText.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
                    var measurement = Measurement.Unit;
                    var name = "";
                    if (ingredientHtmlNode.Descendants("span").Any(x =>
                        x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit"))
                    {
                        if (ingredientHtmlNode.Descendants("span").First(x =>
                                x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit").InnerText
                            .Contains("clove"))
                        {
                            name += ingredientHtmlNode.Descendants("span").First(x =>
                                x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit").InnerText + " ";
                        }
                        measurement = ConvertStringToMeasurement(ingredientHtmlNode.Descendants("span").First(x =>
                         x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit").InnerText);
                    }
                    name += ingredientHtmlNode.Descendants("span")
                        .First(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-name").InnerText;
                    if (ingredientHtmlNode.Descendants("span").Any(x => x.GetAttributeValue("class", "") == " wprm-recipe-ingredient-notes"))
                    {
                        name += " " + ingredientHtmlNode.Descendants("span").First(x => x.GetAttributeValue("class", "") == " wprm-recipe-ingredient-notes").InnerText;
                    }
                    recipe.AddIngredient(ingredientsUse, new Ingredient(amount, name, measurement));
                }

            }
        }

        public override void SetInstructions(Recipe recipe)
        {
            foreach (var instructionNode in HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "") == "wprm-recipe-instruction-text"))
            {
                recipe.Instructions.Add(instructionNode.InnerText);
            }
        }

        public override void setNotes(Recipe recipe)
        {
            foreach (var noteNode in HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "") == "wprm-recipe-notes"))
            {
                recipe.Notes.Add(noteNode.InnerText);
            }
        }
    }
}