using System;
using ExerciciosDeLogica.Exercicios;

namespace ExerciciosDeLogica
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Selecione o Exercicio:");
            Console.WriteLine("1 - Conversão entre Celsius e Fahrenheit");
            Console.WriteLine("2 - Conversão de lista de Temperaturas");
            Console.WriteLine("3 - Números de Apartamentos");
            Console.WriteLine("4 - Soma de 100 elementos Fibonacci");
            Console.WriteLine("5 - Identificar Cartões Magnéticos");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                switch (n) { 
                    case (int)1:
                        Console.WriteLine("");
                        var exerc1 = new ExerCelsiusFahrenheit();
                        break;
                    case (int)2:
                        var exerc2 = new ExerListaTemperaturas();
                        break;
                    case (int)3:
                        var exerc3 = new ExerNumerosApartamentos();
                        break;
                    case (int)4:
                        var exerc4 = new ExerSoma100Fibonacci();
                        break;
                    case (int)5:
                        var exerc5 = new ExerIdentificacaoCartoesMagneticos();
                        break;
                }
                Console.Clear();
                Menu();
            }
            catch
            {
                Console.WriteLine("Informe apenas números de 1 a 5");
                Menu();
            }
        }
    }
}
