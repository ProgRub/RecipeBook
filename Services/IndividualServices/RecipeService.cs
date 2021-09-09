using System;
using System.Collections.Generic;
using System.Linq;
using Components.RecipeScrapers;
using Database;
using Database.Entities;
using Services.DTOs;
using Services.Scrapers;

namespace Services.IndividualServices
{
	public class RecipeService
	{
		private RecipeService()
		{
			//_lastUsedMultiplier = 1;
		}

		private static Dictionary<ConversionType, double> _conversionTable = new Dictionary<ConversionType, double>
		{
			{ConversionType.TableSpoon_To_TeaSpoon, 3},
			{ConversionType.Cup_To_TableSpoon, 16},
			{ConversionType.Cup_To_TeaSpoon, 48},
			{ConversionType.Cup_To_FluidOunce, 8},
			{ConversionType.Gallon_To_Quart, 4},
			{ConversionType.Quart_To_Pint, 2},
			{ConversionType.Pint_To_Cup, 2},
			{ConversionType.Celsius_To_Fahrenheit, 33.8},
			{ConversionType.Ounce_To_Gram, 28},
			{ConversionType.Kilogram_To_Gram, 1000},
			{ConversionType.TeaSpoon_To_Milliliter, 5},
			{ConversionType.TableSpoon_To_Milliliter, 15},
			{ConversionType.Cup_To_Milliliter, 237},
			{ConversionType.Gallon_To_Liter, 3.8},
			{ConversionType.Pound_To_Gram, 454}
		};

		internal static RecipeService Instance { get; } = new RecipeService();
		internal RecipeDTO SelectedRecipe { get; set; }

		internal RecipeDTO GetRecipe(string url)
		{
			foreach (var item in DatabaseContext.Recipes)
			{
				if (item.Url == url)
				{
					return RecipeDTO.ConvertRecipeToDTO(item);
				}
			}

			if (url.Contains("gimmesomeoven") || url.Contains("pinchofyum"))
			{
				return RecipeDTO.ConvertRecipeToDTO(TastyRecipeScraper.Instance.ScrapeRecipe(url));
			}

			if (url.Contains("delish"))
			{
				return RecipeDTO.ConvertRecipeToDTO(DelishRecipeScraper.Instance.ScrapeRecipe(url));
			}

			if (url.Contains("wprm_print"))
			{
				return RecipeDTO.ConvertRecipeToDTO(WPRMRecipeScraper.Instance.ScrapeRecipe(url));
			}

			return null;
		}

		internal IEnumerable<RecipeDTO> GetAllRecipes() => DatabaseContext.Recipes.Select(RecipeDTO.ConvertRecipeToDTO);

		internal RecipeDTO ScaleRecipe(RecipeDTO recipe, double multiplier)
		{
			var returnRecipe = recipe.Clone();
			var yieldSplit = returnRecipe.Yield.Split(null);
			for (var index = 0; index < yieldSplit.Length; index++)
			{
				if (yieldSplit[index].Contains("-"))
				{
					var aux = yieldSplit[index].Split('-');
					for (var i = 0; i < aux.Length; i++)
					{
						aux[i] = (double.Parse(aux[i]) * multiplier).ToString();
					}

					yieldSplit[index] = string.Join('-', aux);
				}
				else
				{
					if (double.TryParse(yieldSplit[index], out var number))
					{
						yieldSplit[index] = (number * multiplier).ToString();
					}
				}
			}

			returnRecipe.Yield = string.Join(' ', yieldSplit);
			foreach (var key in returnRecipe.IngredientsByComponent.Keys)
			{
				foreach (var ingredient in returnRecipe.IngredientsByComponent[key])
				{
					ingredient.Quantity *= multiplier;
				}
			}

			return returnRecipe;
		}

		internal RecipeDTO ConvertRecipeMeasurements(RecipeDTO recipe, ConversionType conversionType,
			bool reverseConversion)
		{
			var returnRecipe = recipe.Clone();
			foreach (var ingredientList in returnRecipe.IngredientsByComponent.Values)
			{
				foreach (var ingredient in ingredientList)
				{
					var conversionTypeString = conversionType.ToString();
					var conversionTypeStringSplit = conversionTypeString.Split('_');
					var leftMeasurement =
						(Measurement) Enum.Parse(typeof(Measurement), conversionTypeStringSplit.First());
					var rightMeasurement =
						(Measurement) Enum.Parse(typeof(Measurement), conversionTypeStringSplit.Last());
					if ((reverseConversion && ingredient.Measurement != rightMeasurement) ||
					    (!reverseConversion && ingredient.Measurement != leftMeasurement)) continue;
					if (!reverseConversion)
					{
						ingredient.Quantity *= _conversionTable[conversionType];
						ingredient.Measurement = rightMeasurement;
					}
					else
					{
						ingredient.Quantity *= 1 / _conversionTable[conversionType];
						ingredient.Measurement = leftMeasurement;
					}
				}
			}

			return returnRecipe;
		}
	}
}