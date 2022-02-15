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

            nicolas.nome = "Nicolas Duarte Dos Passos";
            nicolas.cpf = "02618720105";
            nicolas.profissao = "Assistente de projetos";

            ContaCorrente contaDoNicolas = new ContaCorrente();

            contaDoNicolas.titular = nicolas;
            contaDoNicolas.saldoConta = 1000;
            contaDoNicolas.agenciaConta = 0001;
            contaDoNicolas.numeroConta = 1;


            Console.WriteLine(contaDoNicolas.titular.nome);

            Console.ReadLine();
        }
    }
}
