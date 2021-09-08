using Database.Entities;

namespace Services.DTOs
{
	public class IngredientDTO
	{
		public double Quantity { get; set; }
		public string Name  { get; set; }
		public Measurement Measurement  { get; set; }

		internal static IngredientDTO ConvertIngredientToDTO(Ingredient ingredient)
		{
			return new()
			{
				Quantity = ingredient.Quantity,Name = ingredient.Name,Measurement = ingredient.Measurement
			};
		}

		internal IngredientDTO Clone()
		{
			return new()
			{
				Measurement = Measurement, Name = Name, Quantity = Quantity
			};
		}
	}
}