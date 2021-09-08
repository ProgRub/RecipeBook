using System;
using System.Collections.Generic;
using System.Linq;
using Database.Entities;

namespace Services.Scrapers
{
	public class WPRMRecipeScraper : RecipeScraper
	{
		private WPRMRecipeScraper()
		{
		}

		public static RecipeScraper Instance { get; } = new WPRMRecipeScraper();

		public override TimeSpan GetCookTime()
		{
			return ConvertStringToTimeSpan(GetDecodedInnerText(HtmlDocument.DocumentNode.Descendants("div")
				.First(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-cook-time-container"))
				.Descendants("span").Where(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-time"))
				.ToList()[1]));
		}

		public override TimeSpan GetPrepTime()
		{
			return ConvertStringToTimeSpan(GetDecodedInnerText(HtmlDocument.DocumentNode.Descendants("div")
				.First(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-prep-time-container"))
				.Descendants("span").Where(x => x.GetAttributeValue("class", "").Contains("wprm-recipe-time"))
				.ToList()[1]));
		}

		public override string GetRecipeName()
		{
			return GetDecodedInnerText(HtmlDocument.DocumentNode.Descendants("h2").First());
		}

		public override string GetYield()
		{
			return HtmlDocument.DocumentNode.Descendants("input")
				       .First(x => x.GetAttributeValue("id", "") == "wprm-print-servings")
				       .GetAttributeValue("value", "") +
			       " servings";
		}

		public override IDictionary<string,List<Ingredient>> GetIngredients()
		{
			var ingredientsDictionary = new Dictionary<string, List<Ingredient>>();
			foreach (var ingredientsSection in HtmlDocument.DocumentNode.Descendants("div")
				.Where(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-group"))
			{
				var ingredientsUse = "";
				if (ingredientsSection.Descendants("h4").Any())
				{

					var numberWordsToSkip = 2;
					if (ingredientsSection.Descendants("h4").First().InnerText
						.Split(new char[0], StringSplitOptions.RemoveEmptyEntries)[1] != "the")
					{
						numberWordsToSkip--;
					}

					ingredientsUse = string.Join(" ",
						GetDecodedInnerText(ingredientsSection.Descendants("h4").First())
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries).Skip(numberWordsToSkip));
					ingredientsUse = ingredientsUse.First().ToString().ToUpper() + ingredientsUse.Substring(1);

					if (ingredientsUse.Last() == ':')
					{
						ingredientsUse = ingredientsUse.Remove(ingredientsUse.Length - 1);
					}
				}

				foreach (var ingredientHtmlNode in ingredientsSection.Descendants("li"))
				{
					var amount = 0.0;
					var measurement = Measurement.Unit;
					try
					{
						amount = ConvertFactionToDouble(ingredientHtmlNode.Descendants("span")
							.First(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-amount").InnerText
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries));
					}
					catch (FormatException)
					{
						var innerTextSplit = GetDecodedInnerText(ingredientHtmlNode.Descendants("span")
								.First(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-amount"))
							.Split(new char[0], StringSplitOptions.RemoveEmptyEntries);
						amount = ConvertFactionToDouble(innerTextSplit[0]);
						measurement = ConvertStringToMeasurement(innerTextSplit[1]);
					}

					var name = "";
					if (ingredientHtmlNode.Descendants("span").Any(x =>
						x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit"))
					{
						if (ingredientHtmlNode.Descendants("span").First(x =>
								x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit").InnerText
							.Contains("clove"))
						{
							name += GetDecodedInnerText(ingredientHtmlNode.Descendants("span").First(x =>
								x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit")) + " ";
						}

						measurement = ConvertStringToMeasurement(ingredientHtmlNode.Descendants("span").First(x =>
							x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-unit").InnerText);
					}

					name += GetDecodedInnerText(ingredientHtmlNode.Descendants("span")
						.First(x => x.GetAttributeValue("class", "") == "wprm-recipe-ingredient-name"));
					if (ingredientHtmlNode.Descendants("span").Any(x =>
						x.GetAttributeValue("class", "") == " wprm-recipe-ingredient-notes"))
					{
						name += " " + GetDecodedInnerText(ingredientHtmlNode.Descendants("span").First(x =>
							x.GetAttributeValue("class", "") == " wprm-recipe-ingredient-notes"));
					}
					
					AddIngredientToDictionary(ingredientsUse,
						new Ingredient {Quantity = amount, Name = name, Measurement = measurement},
						ingredientsDictionary);
				}
			}

			return ingredientsDictionary;
		}

		public override IList<string> GetInstructions()
		{
			return HtmlDocument.DocumentNode.Descendants("div")
				.Where(x => x.GetAttributeValue("class", "") == "wprm-recipe-instruction-text")
				.Select(instructionNode => GetDecodedInnerText(instructionNode))
				.ToList();
		}

		public override  IList<string> GetNotes()
		{
			return HtmlDocument.DocumentNode.Descendants("div")
				.Where(x => x.GetAttributeValue("class", "") == "wprm-recipe-notes")
				.Select(noteNode => GetDecodedInnerText(noteNode))
				.ToList();
		}
	}
}