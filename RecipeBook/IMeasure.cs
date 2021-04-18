using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeBook
{
    public interface IMeasure
    {
        Measurement Measurement { get; set; }
        double Quantity { get; set; }
    }
}