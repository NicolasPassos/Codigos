using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1___ByteBank__Parte_2_CSharp_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Aula 1 Alura - ByteBank (Parte 2 C#)");

            
            ContaCorrente contaDoNicolas = new ContaCorrente();

            contaDoNicolas.titularConta = "Nicolas Duarte Dos Passos";
            contaDoNicolas.agenciaConta = 0001;
            contaDoNicolas.numeroConta = 1;
            contaDoNicolas.saldoConta = 1000.0;

            Console.WriteLine("Nome do titular: " + contaDoNicolas.titularConta);
            Console.WriteLine("Número da agência: " + contaDoNicolas.agenciaConta);
            Console.WriteLine("Número da conta: " + contaDoNicolas.numeroConta);
            Console.WriteLine("Saldo atual: " + contaDoNicolas.saldoConta);
            Console.ReadLine();


        }
    }
}
