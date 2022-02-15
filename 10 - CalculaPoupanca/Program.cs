using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10___CalculaPoupanca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Aula Alura 10 - Calcula Poupança");
            
            double valorInvestido = 1000;
            int contMes = 1;
            int contAno = 0;

            while (valorInvestido <= 2000) 
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                contMes = contMes + 1;
      
            }
            if (contMes >= 12)
            {
                contAno = contMes / 12;
                Console.WriteLine("O rendimento após " + contAno + " anos é de R$" + valorInvestido);
                }
            else
            { Console.WriteLine("O rendimento após " + contMes + " mês é de R$" + valorInvestido); }

            Console.ReadLine();
        }
    }
}
