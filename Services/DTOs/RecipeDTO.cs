using System;
using System.Collections.Generic;
using System.Linq;
using Database.Entities;

namespace Services.DTOs
{
	public class RecipeDTO
	{
		public TimeSpan CookTime { get; set; }
		public TimeSpan PrepTime { get; set; }
		public IDictionary<string,List<IngredientDTO>> IngredientsByComponent { get; set; }
		public IList<string> Instructions { get; set; }
		public IList<string> Notes { get; set; }
		public string Name  { get; set; }
		public string Yield  { get; set; }
		public string Url  { get; set; }

		internal static RecipeDTO ConvertRecipeToDTO(Recipe recipe)
		{
			var ingredients = new Dictionary<string, List<IngredientDTO>>();
			foreach (var component in recipe.IngredientsByComponent.Keys)
			{
				if (!ingredients.ContainsKey(component))
				{
					ingredients.Add(component, new List<IngredientDTO>());
				}

				foreach (var ingredient in recipe.IngredientsByComponent[component])
				{
					ingredients[component].Add(IngredientDTO.ConvertIngredientToDTO(ingredient));
				}
			}
			return new RecipeDTO()
			{
				CookTime = recipe.CookTime, IngredientsByComponent = ingredients,
				Instructions = recipe.Instructions, Name = recipe.Name, Notes = recipe.Notes,
				PrepTime = recipe.PrepTime, Url = recipe.Url, Yield = recipe.Yield
			};
		}
		internal RecipeDTO Clone()
		{
			var ingredients = new Dictionary<string, List<IngredientDTO>>();
			foreach (var component in IngredientsByComponent.Keys)
			{
				if (!ingredients.ContainsKey(component))
				{
					ingredients.Add(component, new List<IngredientDTO>());
				}

				foreach (var ingredient in IngredientsByComponent[component])
				{
					ingredients[component].Add(ingredient.Clone());
				}
			}
			return new()
			{
				CookTime = CookTime, IngredientsByComponent = ingredients,
				Instructions = Instructions, Name = Name, Notes = Notes,
				PrepTime = PrepTime, Url = Url, Yield = Yield
			};
		}
	}
}