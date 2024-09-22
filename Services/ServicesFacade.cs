using System;
using System.Collections;
using System.Collections.Generic;
using Database;
using Services.DTOs;
using Services.IndividualServices;

namespace Services
{
	public class ServicesFacade
	{
		private ServicesFacade(){}
		public static ServicesFacade Instance { get; } = new ServicesFacade();

		public static void LoadDatabase() => DatabaseContext.Load();
		public static void SaveDatabase() => DatabaseContext.Save();

		public static RecipeDTO GetRecipe(string recipeUrl) => RecipeService.Instance.GetRecipe(recipeUrl);

		public IEnumerable<RecipeDTO> GetAllRecipes() => RecipeService.Instance.GetAllRecipes();

		public void SetSelectedRecipe(RecipeDTO selectedRecipe) =>
			RecipeService.Instance.SelectedRecipe = selectedRecipe;

		public RecipeDTO GetSelectedRecipe() => RecipeService.Instance.SelectedRecipe;

		public static RecipeDTO GetScaledRecipe(RecipeDTO recipe, double scale) =>
			RecipeService.Instance.ScaleRecipe(recipe, scale);

		public static RecipeDTO ConvertRecipeMeasurements(RecipeDTO recipe, ConversionType conversionType,bool reverseConversion) =>
			RecipeService.Instance.ConvertRecipeMeasurements(recipe, conversionType,reverseConversion);
	}
}
