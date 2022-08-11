using System;
using System.Collections.Generic;
using System.Text;

namespace ExerciciosDeLogica.Exercicios
{
    public class ExerIdentificacaoCartoesMagneticos
    {
        private List<string> trilhasCartoes;
        public ExerIdentificacaoCartoesMagneticos()
        {
            PreencherListaCartoes();
            IdentificarCartoesMagneticos();
        }

        public void IdentificarCartoesMagneticos()
        {
            List<string> cartoesKappa = new List<string>();
            List<string> cartoesGamma = new List<string>();
            List<string> cartoesKappaExpir = new List<string>();
            List<string> cartoesGammaExpir = new List<string>();
            foreach (var trilha in trilhasCartoes)
            {
                var index = trilha.IndexOf("=");
                var ano = Convert.ToInt32(trilha.Substring(index + 1, 2));
                var mes = Convert.ToInt32(trilha.Substring(index + 3, 2));
                if (trilha[1].ToString() == "2".ToString())
                {
                    cartoesKappa.Add(trilha);
                    if(ano < 20)
                        cartoesKappaExpir.Add(trilha);
                    if (ano == 20 && mes < 12)
                        cartoesKappaExpir.Add(trilha);
                    //Console.WriteLine(ano + " " +mes);
                }
                if (trilha[1].ToString() == ("7") && (trilha[2].ToString() == ("2") || trilha[2].ToString() == ("6")))
                {
                    cartoesGamma.Add(trilha);
                    if (ano < 20)
                        cartoesGammaExpir.Add(trilha);
                    if (ano == 20 && mes < 12)
                        cartoesGammaExpir.Add(trilha);
                    //Console.WriteLine(ano + " " + mes);
                }
            }
            Console.WriteLine("Trilhas de Cartões Kappa e Gamma:");
            Console.WriteLine("");
            Console.WriteLine("Trilhas Kappa:");
            foreach (var trilha in cartoesKappa)
            {
                Console.WriteLine(trilha);
            }
            Console.WriteLine("");
            Console.WriteLine("Trilhas Kappa Expirados:");
            foreach (var trilha in cartoesKappaExpir)
            {
                Console.WriteLine(trilha);
            }
            Console.WriteLine("");
            Console.WriteLine("Trilhas Gamma:");
            foreach (var trilha in cartoesGamma)
            {
                Console.WriteLine(trilha);
            }
            Console.WriteLine("");
            Console.WriteLine("Trilhas Gamma Expirados:");
            foreach (var trilha in cartoesGammaExpir)
            {
                Console.WriteLine(trilha);
            }
            Console.ReadKey();
        }

        public void PreencherListaCartoes()
        {
            trilhasCartoes = new List<string>();
            trilhasCartoes.Add(";854922420655947=20087011490683843?");
            trilhasCartoes.Add(";722792821249=190220153666234? ");
            trilhasCartoes.Add(";8657607910110=2209701507597562? ");
            trilhasCartoes.Add(";6034523459017=24032012187993726? ");
            trilhasCartoes.Add(";83407977524115=2010701164703842? ");
            trilhasCartoes.Add(";22554987787910=1903201221224791?");
            trilhasCartoes.Add(";7621767951747=21112018460506111?");
            trilhasCartoes.Add(";24478927568913=230470179307259?");
            trilhasCartoes.Add(";88674481889649=19062014166695784?");
            trilhasCartoes.Add(";76985229117350=1805701127970335?");
            trilhasCartoes.Add(";2147686439882=2712701977197697?");
            trilhasCartoes.Add(";86392841965929=2108201878359745?");
        }
    }
}
