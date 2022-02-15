using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12___CalculaInvestimentoLongoPrazo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Aula 12 Alura - Calcula Investimento Longo Prazo");

            double fatorRendimento = 1.0036;
            double valorInvestido = 1000;

            for (int contAno = 1; contAno <= 5; contAno++)
            {
                for (int contMes = 1; contMes <= 12; contMes++)
                {
                    valorInvestido *= fatorRendimento;

                }
                fatorRendimento += 0.0010;
                
            }


            Console.WriteLine(" Ao término do investimento, você terá R$" + valorInvestido);
            Console.ReadLine();
        }
    }
}
