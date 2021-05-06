using System;
using HtmlAgilityPack;

namespace RecipeBook
{
    public interface IRecipeScraper
    {
        Recipe ScrapeRecipe(string url);
        public static Measurement ConvertStringToMeasurement(string measurementString)
        {
            switch (measurementString)
            {
                case "cup":
                case "cups":
                    return Measurement.Cup;
                case "serving":
                case "servings":
                    return Measurement.Serving;
                case "tablespoon":
                case "tablespoons":
                case "tbsp":
                    return Measurement.TableSpoon;
                case "teaspoon":
                case "teaspoons":
                case "tsp":
                    return Measurement.TeaSpoon;
                case "pound":
                case "pounds":
                    return Measurement.Pound;
                case "ounce":
                case "ounces":
                    return Measurement.Ounce;
                default:
                    return Measurement.Unit;
            }
        }
        TimeSpan ConvertStringToTimeSpan(string timeString);
        Ingredient ConvertHtmlNodeToIngredient(HtmlNode ingredientNode);
        string ConvertInfoToYield(HtmlNode yieldInfo);
    }
}