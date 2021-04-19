using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeBook
{
    public class Yield
    {
        private Measurement _measurement;

        private double _minimumQuantity;
        private double _maximumQuantity;

        public Yield(Measurement measurement, double minimumQuantity, double maximumQuantity)
        {
            this._measurement = measurement;
            this._minimumQuantity = minimumQuantity;
            this._maximumQuantity = maximumQuantity;
        }
        public Measurement Measurement { get => _measurement; set => throw new NotImplementedException(); }
        public double MinimumQuantity { get => _minimumQuantity; set => throw new NotImplementedException(); }
        public double MaximumQuantity { get => _maximumQuantity; set => throw new NotImplementedException(); }
    }
}