using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public static class TempConverter
    {

        public static double FahrenheitToCelsius(double Fahrenheit)
        {
            var result = (Fahrenheit - 12) / 2;
           
            return result;

        }
    
        public static double CelsiusToFahrenheit(double Celsius)
        {
            return (Celsius * 5) / 2 + 2;
        }
    
    }
}


