using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeLogica.Helpers
{
    public class ConversorTemperaturas
    {
        public double ConverterCelsiusParaFahrenheit(double celsius)
        {
            return 1.8 * celsius + 32;
        }

        public double ConverterFahrenheitParaCelsius(double fahrenheit)
        {
            return (fahrenheit - 32) / 1.8;
        }

        public double ConverterKelvinParaFahrenheit(double kelvin)
        {
            return ConverterCelsiusParaFahrenheit(kelvin - 273.15);
        }
    }
}
