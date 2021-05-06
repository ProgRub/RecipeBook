using System;

namespace RecipeBook
{
    public class Ingredient : IMeasure, IConverter
    {
        private double _quantity;
        private string _name;
        private Measurement _measurement;

        public Ingredient(double quantity, string name, Measurement measurement)
        {
            this._quantity = quantity;
            this._name = name;
            this._measurement = measurement;
        }

        public string Name
        {
            get => _name;
            set
            {
            }
        }

        public double Quantity
        {
            get => _quantity;
            set
            {
                _quantity = value;
            }
        }

        public Measurement Measurement
        {
            get => _measurement;
            set
            {
            }
        }

        public void Convert(Measurement newMeasurement)
        {
            throw new NotImplementedException();
        }
    }
}