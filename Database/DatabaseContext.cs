using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;
using Database.Entities;

namespace Database
{
	public class DatabaseContext
	{
		private static readonly string FilePath = Path.Combine(Directory.GetCurrentDirectory(), "Recipes.xml");

		public static void Load()
		{
			if (!File.Exists(FilePath))
			{
				File.Create(FilePath).Close();
				XDocument newDocument = new();
				newDocument.Add(new XElement("root", newDocument.Root));
				newDocument.Save(FilePath);
				return;
			}

			var xmlDocument = XDocument.Load(FilePath);

			foreach (var recipeElement in xmlDocument.Root.Elements("Recipe"))
			{
				var prepTimeString = recipeElement.Attribute("prepTime").Value;
				var prepTimeStringSplit = prepTimeString.Split(":");
				var cookTimeString = recipeElement.Attribute("cookTime").Value;
				var cookTimeStringSplit = cookTimeString.Split(":");
				var recipe = new Recipe
				{
					Name = recipeElement.Attribute("name").Value,
					PrepTime = new TimeSpan(int.Parse(prepTimeStringSplit[0]), int.Parse(prepTimeStringSplit[1]),
						int.Parse(prepTimeStringSplit[2])),
					CookTime = new TimeSpan(int.Parse(cookTimeStringSplit[0]), int.Parse(cookTimeStringSplit[1]),
						int.Parse(cookTimeStringSplit[2])),
					Yield = recipeElement.Attribute("yield").Value,
					Url = recipeElement.Attribute("url").Value, Instructions = new List<string>(),
					Notes = new List<string>()
				};
				recipe.IngredientsByComponent = new Dictionary<string, List<Ingredient>>();
				foreach (var ingredient in recipeElement.Descendants("Ingredient"))
				{
					var key = ingredient.Attribute("for").Value;
					if (!recipe.IngredientsByComponent.ContainsKey(key))
					{
						recipe.IngredientsByComponent.Add(key, new List<Ingredient>());
					}
						recipe.IngredientsByComponent[key].Add(new Ingredient
						{
							Quantity = double.Parse(ingredient.Attribute("quantity").Value),
							Name = ingredient.Value,
							Measurement = (Measurement)Enum.Parse(typeof(Measurement),
								ingredient.Attribute("measurement").Value)
						});
				}

				;
				foreach (var instruction in recipeElement.Descendants("Instruction"))
				{
					recipe.Instructions.Add(instruction.Value);
				}

				foreach (var note in recipeElement.Descendants("Note"))
				{
					recipe.Notes.Add(note.Value);
				}

				Recipes.Add(recipe);
			}
		}

		public static void Save()
		{
			var xmlDocument = XDocument.Load(FilePath);
			xmlDocument.Root.RemoveAll();
			foreach (var recipe in Recipes)
			{
				var xElementRecipe = new XElement("Recipe");
				xElementRecipe.SetAttributeValue("name", recipe.Name);
				xElementRecipe.SetAttributeValue("prepTime", recipe.PrepTime.ToString());
				xElementRecipe.SetAttributeValue("cookTime", recipe.CookTime.ToString());
				xElementRecipe.SetAttributeValue("yield", recipe.Yield);
				xElementRecipe.SetAttributeValue("url", recipe.Url);
				foreach (var key in recipe.IngredientsByComponent.Keys)
				{
					foreach (var ingredient in recipe.IngredientsByComponent[key])
					{
						var xElementIngredient = new XElement("Ingredient");
						xElementIngredient.SetAttributeValue("measurement", ingredient.Measurement);
						xElementIngredient.SetAttributeValue("quantity", ingredient.Quantity);
						xElementIngredient.SetAttributeValue("for", key);
						xElementIngredient.Value = ingredient.Name;
						xElementRecipe.Add(xElementIngredient);
					}
				}

				foreach (var instruction in recipe.Instructions)
				{
					var xElementInstruction = new XElement("Instruction", instruction);
					xElementRecipe.Add(xElementInstruction);
				}

				foreach (var note in recipe.Notes)
				{
					var xElementNote = new XElement("Note", note);
					xElementRecipe.Add(xElementNote);
				}

				xmlDocument.Root.Add(xElementRecipe);
			}

			xmlDocument.Save(FilePath);
		}

		public static ISet<Recipe> Recipes = new HashSet<Recipe>();

		public static void SaveRecipe(Recipe recipe)
		{
			Recipes.Add(recipe);
		}
	}
}