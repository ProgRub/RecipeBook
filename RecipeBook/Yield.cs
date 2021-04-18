using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeBook
{
    public class Yield : IMeasure
    {
        private Measurement _measurement;

        private double _quantity;

        public Yield(Measurement measurement, double quantity)
        {
            this._measurement = measurement;
            this._quantity = quantity;
        }
        public Measurement Measurement { get => _measurement; set => throw new NotImplementedException(); }
        public double Quantity { get => _quantity; set => throw new NotImplementedException(); }
    }
}