using ExerciciosDeLogica.Helpers;
using System;

namespace ExerciciosDeLogica.Exercicios
{
    public class ExerCelsiusFahrenheit
    {
        ConversorTemperaturas conversor;
        public ExerCelsiusFahrenheit()
        {
            Conversoes();
        }

        public void Conversoes()
        {
            Console.WriteLine("Selecione a Conversão desejada:");
            Console.WriteLine("1 - Conversão de Celsius para Fahrenheit");
            Console.WriteLine("2 - Conversão de Fahrenheit para Celsius");
            Console.WriteLine("0 - Voltar ao Menu");
            conversor = new ConversorTemperaturas();
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (n)
                {
                    case 0:
                        Console.Clear();
                        Program.Menu();
                        break;
                    case (int)1:
                        ConverterCelsiusParaFahrenheit();
                        break;
                    case (int)2:
                        ConverterFahrenheitParaCelsius();
                        break;
                }
                Console.ReadKey();
                Conversoes();
            }
            catch
            {
                Console.WriteLine("Informe apenas números de 0 a 2.");
                Conversoes();
            }
        }

        public void ConverterCelsiusParaFahrenheit()
        {
            Console.WriteLine("Informe o valor:");
            double celsius;
            try
            {
                celsius = Convert.ToDouble(Console.ReadLine());
                var fahren = conversor.ConverterCelsiusParaFahrenheit(celsius);
                Console.WriteLine("Celsius: "+celsius+" - Fahrenheit: " + fahren);
            }
            catch
            {
                Console.WriteLine("Informe um valor válido para Celsius.");
            }
        }
        public void ConverterFahrenheitParaCelsius()
        {
            Console.WriteLine("Informe o valor:");
            double  fahren;
            try
            {
                fahren = Convert.ToDouble(Console.ReadLine());
                var celsius = conversor.ConverterFahrenheitParaCelsius(fahren);
                Console.WriteLine("Celsius: " + celsius + " - Fahrenheit: " + fahren);
            }
            catch
            {
                Console.WriteLine("Informe um valor válido para Fahrenheit.");
            }
        }
    }
}
