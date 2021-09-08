using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Database;
using Database.Entities;

namespace Services.Scrapers
{
	public class DelishRecipeScraper : RecipeScraper
	{
		private DelishRecipeScraper()
		{
		}

		public static RecipeScraper Instance { get; } = new DelishRecipeScraper();

		public override TimeSpan GetCookTime()
		{
			var totalTimeHtmlNode = HtmlDocument.DocumentNode.Descendants("div").First(x =>
				x.GetAttributeValue("class", "nothing") == "recipe-details-item total-time");
			var totalTimeString = string.Join(" ", GetDecodedInnerText(totalTimeHtmlNode.Descendants("span")
					.First(x => x.GetAttributeValue("class", "nothing") == "total-time-amount"))
				.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
			return ConvertStringToTimeSpan(totalTimeString) - GetPrepTime();
		}

		public override TimeSpan GetPrepTime()
		{
			var prepTimeHtmlNode = HtmlDocument.DocumentNode.Descendants("div").First(x =>
				x.GetAttributeValue("class", "nothing") == "recipe-details-item prep-time");
			var prepTimeString = string.Join(" ", GetDecodedInnerText(prepTimeHtmlNode.Descendants("span")
					.First(x => x.GetAttributeValue("class", "nothing") == "prep-time-amount"))
				.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
			return ConvertStringToTimeSpan(prepTimeString);
		}

		public override string GetRecipeName()
		{
			return GetDecodedInnerText(HtmlDocument.DocumentNode.Descendants("h1").First());
		}

		public override string GetYield()
		{
			var yieldHtmlNode = HtmlDocument.DocumentNode
				.Descendants("div").First(x => x.GetAttributeValue("class", "nothing") == "recipe-details-item yields");
			var yield = string.Join(" ", GetDecodedInnerText(yieldHtmlNode.Descendants("span")
					.First(x => x.GetAttributeValue("class", "nothing") == "yields-amount"))
				.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
			return yield;
		}

		public override IDictionary<string, List<Ingredient>> GetIngredients()
		{
			var ingredientsDictionary = new Dictionary<string, List<Ingredient>>();
			var ingredientsBodyNode = HtmlDocument.DocumentNode
				.Descendants("div").First(x => x.GetAttributeValue("class", "nothing") == "ingredients-body");
			foreach (var ingredientSectionHtmlNode in ingredientsBodyNode.Descendants()
				.Where(x => x.GetAttributeValue("class", "nothing").Contains("ingredient-section")))
			{
				var ingredientsUse = "";
				var ingredientTitleList = ingredientSectionHtmlNode.Descendants()
					.Where(x => x.GetAttributeValue("class", "nothing") == "ingredient-title").ToList();
				if (ingredientTitleList.Count > 0 && !string.IsNullOrWhiteSpace(ingredientTitleList.First().InnerText))
				{
					var numberWordsToSkip = 2;
					if (ingredientTitleList.First().InnerText
						.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)[1] != "The")
					{
						numberWordsToSkip--;
					}

					ingredientsUse = string.Join(" ",
						GetDecodedInnerText(ingredientTitleList.First())
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Skip(numberWordsToSkip));
				}

				foreach (var ingredientHtmlNode in ingredientSectionHtmlNode.Descendants()
					.First(x => x.GetAttributeValue("class", "nothing") == "ingredient-lists").Descendants("div"))
				{
					var amountHtmlNode = ingredientHtmlNode.Descendants("span")
						.Where(x => x.GetAttributeValue("class", "nothing") == "ingredient-amount").ToList();
					var amount = 0.0;
					var measurement = ConvertStringToMeasurement("");
					if (amountHtmlNode.Count != 0)
					{
						var amountSplit = GetDecodedInnerText(amountHtmlNode[0])
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

					var ingredientName = GetDecodedInnerText(ingredientHtmlNode.Descendants("span")
						.First(x => x.GetAttributeValue("class", "nothing") == "ingredient-description"));
					AddIngredientToDictionary(ingredientsUse,
						new Ingredient {Quantity = amount, Name = ingredientName, Measurement = measurement},
						ingredientsDictionary);
				}
			}

			return ingredientsDictionary;
		}

		public override IList<string> GetInstructions()
		{
			var instructionsReturn = new List<string>();
			var instructionsBodyNode = HtmlDocument.DocumentNode
				.Descendants("div").First(x => x.GetAttributeValue("class", "nothing") == "directions-body");
			foreach (var instructionSectionHtmlNode in instructionsBodyNode.Descendants()
				.Where(x => x.GetAttributeValue("class", "nothing").Contains("direction-section")))
			{
				var instructionsUse = "";
				var instructionTitleList = instructionSectionHtmlNode.Descendants()
					.Where(x => x.GetAttributeValue("class", "nothing") == "direction-title").ToList();
				if (instructionTitleList.Count > 0)
				{
					instructionsUse = string.Join(" ",
						GetDecodedInnerText(instructionTitleList.First())
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
				}

				var instructions = new List<string>();
				foreach (var instructionHtmlNode in instructionSectionHtmlNode.Descendants()
					.First(x => x.GetAttributeValue("class", "nothing") == "direction-lists").Descendants("li"))
				{
					instructions.Add(GetDecodedInnerText(instructionHtmlNode));
				}

				instructionsReturn.Add((!string.IsNullOrWhiteSpace(instructionsUse) ? instructionsUse + ": " : "") +
				                       string.Join(Environment.NewLine, instructions.ToArray()));
			}

			return instructionsReturn;
		}

		public override IList<string> GetNotes()
		{
			return new List<string>();
		}
	}
}