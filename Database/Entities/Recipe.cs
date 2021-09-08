using System;
using System.Collections.Generic;

namespace Database.Entities
{
	public class Recipe
	{
		public TimeSpan CookTime { get; set; }
		public TimeSpan PrepTime { get; set; }
		public IDictionary<string,List<Ingredient>> IngredientsByComponent { get; set; }
		public IList<string> Instructions { get; set; }
		public IList<string> Notes { get; set; }
		public string Name  { get; set; }
		public string Yield  { get; set; }
		public string Url  { get; set; }

	}
}