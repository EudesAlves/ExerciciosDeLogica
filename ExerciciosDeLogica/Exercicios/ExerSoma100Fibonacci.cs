using System;
using System.Numerics;

namespace ExerciciosDeLogica.Exercicios
{
    public class ExerSoma100Fibonacci
    {
        public ExerSoma100Fibonacci()
        {
            ExibirSoma100Fibonacci();
        }
        public void ExibirSoma100Fibonacci()
        {
            Console.WriteLine("Soma dos 100 primeiros elementos da série Fibonacci:");
            BigInteger soma = SomarElementosFibonacci(100);
            Console.WriteLine(soma.ToString());
            Console.WriteLine("Pressione Enter para voltar ao Menu");
            Console.ReadKey();
        }

        public BigInteger SomarElementosFibonacci(int quantiElementos)
        {
            BigInteger num1 = 1;
            BigInteger num2 = 1;
            BigInteger soma = num1 + num2; ;
            for (int i = 2; i < quantiElementos; i++)
            {
                var temp = num1 + num2;
                num1 = num2;
                num2 = temp;
                soma += temp;
            }
            return soma;
        }
    }
}
