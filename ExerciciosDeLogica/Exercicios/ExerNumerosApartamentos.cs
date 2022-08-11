using System;

namespace ExerciciosDeLogica.Exercicios
{
    public class ExerNumerosApartamentos
    {
        public ExerNumerosApartamentos()
        {
            ExibirNumerosApartamentos();
        }

        public void ExibirNumerosApartamentos()
        {
            Console.WriteLine("Exibir Números de Apartamentos por Andar de um Prédio");
            Console.WriteLine("Informe o número de Andares:");
            int apartamentos;
            int andares;
            try
            {
                andares = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe o número de Apartamentos:");
                apartamentos = Convert.ToInt32(Console.ReadLine());
                if (andares == 0 || apartamentos == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Informe apenas números inteiros maiores que 0.");
                    ExibirNumerosApartamentos();
                }
                else
                    ExibirApartamentosPorAndares(andares, apartamentos);
            }
            catch
            {
                Console.WriteLine("Informe apenas números inteiros.");
                ExibirNumerosApartamentos();
            }
            Console.ReadKey();
            Console.WriteLine("Digite 0 para Voltar Menu ou qualquer Tecla para reinserir os Andares e Apartamentos :");
            var opcao = Console.ReadLine();
            Console.Clear();
            if (opcao == "0")
                Program.Menu();
            else
                ExibirNumerosApartamentos();
        }

        public void ExibirApartamentosPorAndares(int andares, int apartamentos)
        {
            for(int i = 1; i <= andares; i++)
            {
                var texto = "Andar " + i + ": ";
                Console.Write(texto);
                for (int j = 1; j <= apartamentos; j++)
                {
                    Console.Write((i * 10 + j).ToString() +" ");
                }
                Console.WriteLine("");
            }
        }
    }
}
