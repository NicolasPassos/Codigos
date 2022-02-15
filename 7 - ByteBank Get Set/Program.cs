using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5___ByteBank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente nicolas = new Cliente();

            ContaCorrente contaDoNicolas = new ContaCorrente(100, 101010);
            ContaCorrente contaDaClara = new ContaCorrente(110, 102010);
            ContaCorrente contaDaDiana = new ContaCorrente(100, 100010);

            contaDoNicolas.titular = nicolas;
            //contaDoNicolas.Agencia = 56;
            contaDoNicolas.numeroConta = 1;

            contaDoNicolas.Depositar(0);


            Console.WriteLine(contaDoNicolas.titular.Nome);
            Console.WriteLine(ContaCorrente.TotalContasCriadas);
            Console.WriteLine(contaDoNicolas.Agencia);

            Console.ReadLine();
        }
    }
}
