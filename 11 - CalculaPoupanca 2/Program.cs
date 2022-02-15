using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11___CalculaPoupanca_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando a Aula 11 Alura - Calcula Poupança 2");

            double valorInvestido = 1000;

            for (int contMes = 1; contMes <= 12; contMes = contMes + 1)
            {
                valorInvestido = valorInvestido + valorInvestido * 0.0036;
                Console.WriteLine("Após " + contMes + " meses, você terá " + valorInvestido);
            }
           Console.ReadLine(); 
        }
    }
}
