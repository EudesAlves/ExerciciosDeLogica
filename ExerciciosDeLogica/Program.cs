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
            Console.WriteLine("2 - ");
            Console.WriteLine("3 - ");
            Console.WriteLine("4 - ");
            Console.WriteLine("5 - ");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
                switch (n) { 
                    case (int)1:
                        Console.WriteLine("");
                        var exerc = new Exercicio1();
                        break;
                }
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
