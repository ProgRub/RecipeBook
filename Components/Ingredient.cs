using System;

namespace Components
{
    public class Ingredient : IMeasure, IConverter
    {
        private double _quantity;
        private string _name;
        private Measurement _measurement;

        public Ingredient(double quantity, string name, Measurement measurement)
        {
            _quantity = quantity;
            _name = name;
            _measurement = measurement;
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