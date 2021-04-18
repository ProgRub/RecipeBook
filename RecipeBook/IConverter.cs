using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RecipeBook
{
    public interface IConverter
    {
        public static Dictionary<string, double> ConversionTable = new Dictionary<string, double> {
            { "TableSpoon_To_TeaSpoon",3},
        { "Cup_To_TableSpoon",16},
        { "Cup_To_TeaSpoon",48},
        { "Cup_To_FluidOunce",8},
        { "Gallon_To_Quarts",4},
        { "Quart_To_Pint",2},
        { "Pint_To_Cup",2},
        { "Celsius_To_Fahrenheit",33.8},
        { "Ounce_To_Gram",28},
        { "Kilogram_To_Gram",1000},
        { "TeaSpoon_To_Milliliter",5},
        { "TableSpoon_To_Milliliter",15},
        { "Cup_To_Milliliter",237},
        { "Gallon_To_Liter",3.8},
        { "Pound_To_Gram",454}};
        void Convert( Measurement newMeasurement);
    }
}