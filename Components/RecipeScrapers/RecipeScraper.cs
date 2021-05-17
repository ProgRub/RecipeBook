using System;
using System.Collections.Generic;
using System.Diagnostics;
using HtmlAgilityPack;

namespace Components.RecipeScrapers
{
    public abstract class RecipeScraper
    {
        public HtmlDocument HtmlDocument { get; private set; }

        public Recipe ScrapeRecipe(string url)
        {
            Debug.WriteLine("HERE");
            var htmlWeb = new HtmlWeb();
            HtmlDocument = htmlWeb.Load(url);
            var recipe = new Recipe(GetRecipeName(), GetPrepTime(), GetCookTime(), GetYield(), url);
            SetIngredients(recipe);
            SetInstructions(recipe);
            setNotes(recipe);
            return recipe;
        }
        public Measurement ConvertStringToMeasurement(string measurementString)
        {
            switch (measurementString)
            {
                case "cup":
                case "cups":
                case "c.":
                    return Measurement.Cup;
                case "serving":
                case "servings":
                    return Measurement.Serving;
                case "tablespoon":
                case "tablespoons":
                case "tbsp":
                case "tbsp.":
                    return Measurement.TableSpoon;
                case "teaspoon":
                case "teaspoons":
                case "tsp":
                case "tsp.":
                    return Measurement.TeaSpoon;
                case "pound":
                case "pounds":
                    return Measurement.Pound;
                case "ounce":
                case "ounces":
                case "oz":
                case "oz.":
                    return Measurement.Ounce;
                default:
                    return Measurement.Unit;
            }
        }
        public abstract TimeSpan GetCookTime();
        public abstract TimeSpan GetPrepTime();
        public abstract string GetRecipeName();
        public abstract string GetYield();
        public abstract void SetIngredients(Recipe recipe);
        public abstract void SetInstructions(Recipe recipe);
        public abstract void setNotes(Recipe recipe);
        public TimeSpan ConvertStringToTimeSpan(string timeString)
        {
            var timeSplit = timeString.Split(new char[] { ' ' });
            var totalMinutes = 0;
            for (var index = 0; index < timeSplit.Length; index += 2)
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
    }
}