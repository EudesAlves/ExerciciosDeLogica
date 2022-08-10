using System;
using System.Collections.Generic;
using System.Text;
using ExerciciosDeLogica;

namespace ExerciciosDeLogica.Exercicios
{
    public class Exercicio1
    {
        public Exercicio1()
        {
            Conversoes();
        }

        public void Conversoes()
        {
            Console.WriteLine("Selecione a Conversão desejada:");
            Console.WriteLine("1 - Conversão de Celsius para Fahrenheit");
            Console.WriteLine("2 - Conversão de Fahrenheit para Celsius");
            Console.WriteLine("0 - Voltar ao Menu");
            int n;
            try
            {
                n = Convert.ToInt32(Console.ReadLine());
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
            }
            catch
            {
                Console.WriteLine("Informe apenas números de 0 a 2");
                Conversoes();
            }
        }

        public void ConverterCelsiusParaFahrenheit()
        {

        }
        public void ConverterFahrenheitParaCelsius()
        {

        }
    }
}
