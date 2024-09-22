using Database.Entities;

namespace WebApp.Models
{
    public class Ingredient
    {
        public double Quantity { get; set; }
        public string Name { get; set; }
        public Measurement Measurement { get; set; }
    }
}