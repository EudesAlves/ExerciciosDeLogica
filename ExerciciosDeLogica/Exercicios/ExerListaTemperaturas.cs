using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosDeLogica.Helpers;

namespace ExerciciosDeLogica.Exercicios
{
    public class ExerListaTemperaturas
    {
        List<double> temperaturasEntrada;
        List<double> temperaturasConvertidas;
        ConversorTemperaturas conversor;

        public ExerListaTemperaturas()
        {
            ConverterLista();
        }

        public void ConverterLista()
        {
            Console.WriteLine("Informe a Lista de Temperaturas separadas por espaço:");
            Console.WriteLine("1º item será convertido de Celsius para Fahrenheit, 2º item de Fahrenheit para Celsius, e assim por diante");
            Console.WriteLine("O último item será convertido de Kelvin para Fahrenheit");
            temperaturasEntrada = new List<double>();
            temperaturasConvertidas = new List<double>();
            conversor = new ConversorTemperaturas();
            try
            {
                var entrada = Console.ReadLine();
                string[] tempArray = entrada.Split(' ');
                foreach (string temp in tempArray)
                    temperaturasEntrada.Add(Convert.ToDouble(temp));
                int i = 0;
                for(i = 0; i < temperaturasEntrada.Count; i++)
                {
                    // Kelvin
                    if(i == temperaturasEntrada.Count-1)
                    {
                        var kelvin = temperaturasEntrada[i];
                        temperaturasConvertidas.Add(conversor.ConverterKelvinParaFahrenheit(kelvin));
                    }
                    else
                    {
                        var celsius = temperaturasEntrada[i];
                        temperaturasConvertidas.Add(conversor.ConverterCelsiusParaFahrenheit(celsius));
                        if (i+1 == temperaturasEntrada.Count - 1)
                        {
                            var kelvin = temperaturasEntrada[i+1];
                            temperaturasConvertidas.Add(conversor.ConverterKelvinParaFahrenheit(kelvin));
                        }
                        else
                        {
                            var fahrenheit = temperaturasEntrada[i+1];
                            temperaturasConvertidas.Add(conversor.ConverterFahrenheitParaCelsius(fahrenheit));
                        }
                        i += 1;
                    }
                }

                Console.WriteLine("Temperaturas convertidas:");
                foreach(var temp in temperaturasConvertidas)
                {
                    Console.Write(temp + " ");
                }
                Console.WriteLine("");
                Console.ReadKey();
                Console.WriteLine("Digite 0 para Voltar Menu ou qualquer Tecla para inserir nova lista:");
                var opcao = Console.ReadLine();
                Console.Clear();
                if(opcao == "0")
                    Program.Menu();
                else
                    ConverterLista();
            }
            catch
            {
                Console.WriteLine("Informe apenas Temperaturas válidas.");
                ConverterLista();
            }
        }
    }
}
