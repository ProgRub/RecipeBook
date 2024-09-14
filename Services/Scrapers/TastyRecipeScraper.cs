using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using Database.Entities;
using Services.Scrapers;

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
			return new TimeSpan(0, 0, 0);
		}

		public override TimeSpan GetPrepTime()
		{
			return new TimeSpan(0, 0, 0);
		}

		public override string GetRecipeName()
		{
			return GetDecodedInnerText(HtmlDocument.DocumentNode.Descendants("h1").First());
		}

		public override string GetYield()
		{
			var recipeBasics = HtmlDocument.DocumentNode.Descendants("p");
			var yieldInfo = recipeBasics.Where(x => x.GetAttributeValue("class", "nothing").Contains("servings-display")).ToList()[0];
			//yieldInfo.ChildNodes.RemoveAt(yieldInfo.ChildNodes.Count - 1);
			return GetDecodedInnerText(yieldInfo);
		}

		public override IDictionary<string, List<Ingredient>> GetIngredients()
		{
			var ingredientsDictionary = new Dictionary<string, List<Ingredient>>();
			var ingredientsHtml = HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "ingredients__section").ToList()[0];
			var ingredientsUse = "Overall";
			foreach (var item in ingredientsHtml.Descendants())
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
				var innerTextSplit = GetDecodedInnerText(item).Split(null);
				var possibleMeasurement = ConvertStringToMeasurement(innerTextSplit.ToList()[1]);
				if (measurement != possibleMeasurement) { measurement = possibleMeasurement; stringsToSkip++; }
				AddIngredientToDictionary(ingredientsUse,
					new Ingredient { Quantity = amount, Name = string.Join(" ", innerTextSplit.Skip(stringsToSkip).ToArray()), Measurement = measurement },
					ingredientsDictionary);
			}

			return ingredientsDictionary;
		}

		public override IList<string> GetInstructions()
		{
			return HtmlDocument.DocumentNode.Descendants("ol").Where(x => x.GetAttributeValue("class", "nothing") == "prep-steps").ToList()[0].Descendants("li").Select(instruction => GetDecodedInnerText(instruction)).ToList();
		}

		public override IList<string> GetNotes()
		{
			var notes = new List<string>();
			//if (HtmlDocument.DocumentNode.Descendants("div").Any(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes"))
			//{
			// notes.AddRange(HtmlDocument.DocumentNode.Descendants("div").Where(x => x.GetAttributeValue("class", "nothing") == "tasty-recipes-notes").ToList()[0].Descendants("p").Select(note => GetDecodedInnerText(note)));
			//}

			return notes;
		}
	}
}