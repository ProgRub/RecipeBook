using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using Database;
using Database.Entities;
using HtmlAgilityPack;

namespace Services.Scrapers
{
	public abstract class RecipeScraper
	{
		public HtmlDocument HtmlDocument { get; private set; }

		public Recipe ScrapeRecipe(string url)
		{
			var htmlWeb = new HtmlWeb();
			HtmlDocument = htmlWeb.Load(url);
			var recipe = new Recipe();
			recipe.IngredientsByComponent = GetIngredients();
			recipe.Instructions = GetInstructions();
			recipe.Notes = GetNotes();
			DatabaseContext.SaveRecipe(recipe);
			return recipe;
		}

		public abstract TimeSpan GetCookTime();
		public abstract TimeSpan GetPrepTime();
		public abstract string GetRecipeName();
		public abstract string GetYield();
		public abstract IDictionary<string, List<Ingredient>> GetIngredients();
		public abstract IList<string> GetInstructions();
		public abstract IList<string> GetNotes();

		protected void AddIngredientToDictionary(string whatComponent, Ingredient ingredient,
			IDictionary<string, List<Ingredient>> dictionary)
		{
			if (!dictionary.ContainsKey(whatComponent))
			{
				dictionary.Add(whatComponent, new List<Ingredient>());
			}
			else
			{
				dictionary[whatComponent].Add(ingredient);
			}
		}

		public Measurement ConvertStringToMeasurement(string measurementString)
		{
			return measurementString switch
			{
				"cup" => Measurement.Cup,
				"cups" => Measurement.Cup,
				"c." => Measurement.Cup,
				"serving" => Measurement.Serving,
				"servings" => Measurement.Serving,
				"tablespoon" => Measurement.TableSpoon,
				"tablespoons" => Measurement.TableSpoon,
				"tbsp" => Measurement.TableSpoon,
				"Tbsp" => Measurement.TableSpoon,
				"tbsp." => Measurement.TableSpoon,
				"teaspoon" => Measurement.TeaSpoon,
				"teaspoons" => Measurement.TeaSpoon,
				"tsp" => Measurement.TeaSpoon,
				"Tsp" => Measurement.TeaSpoon,
				"tsp." => Measurement.TeaSpoon,
				"pound" => Measurement.Pound,
				"pounds" => Measurement.Pound,
				"lbs" => Measurement.Pound,
				"ounce" => Measurement.Ounce,
				"ounces" => Measurement.Ounce,
				"oz" => Measurement.Ounce,
				"oz." => Measurement.Ounce,
				_ => Measurement.Unit
			};
		}

		protected TimeSpan ConvertStringToTimeSpan(string timeString)
		{
			var timeSplit = timeString.Split(new char[] {' '});
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

		protected double ConvertFactionToDouble(IEnumerable<string> faction)
		{
			double result = 0.0;
			foreach (var number in faction)
			{
				if (number.Contains("/"))
				{
					Debug.WriteLine(number);
					var numberSplit = number.Split('/');
					result += double.Parse(numberSplit[0]) / double.Parse(numberSplit[1]);
				}
				else
				{
					result += double.Parse(char.GetNumericValue(number[0]).ToString());
				}
			}

			return result;
		}

		protected double ConvertFactionToDouble(string faction)
		{
			double result = 0.0;
			if (faction.Contains("/"))
			{
				Debug.WriteLine(faction);
				var numberSplit = faction.Split('/');
				result += double.Parse(numberSplit[0]) / double.Parse(numberSplit[1]);
			}
			else
			{
				result += double.Parse(char.GetNumericValue(faction[0]).ToString());
			}

			return result;
		}

		protected string GetDecodedInnerText(HtmlNode node)
		{
			return WebUtility.HtmlDecode(node.InnerText);
		}
	}
}