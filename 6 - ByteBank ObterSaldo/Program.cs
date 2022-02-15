﻿using System;
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
            nicolas.profissao = "Assistente de projetos";

            ContaCorrente contaDoNicolas = new ContaCorrente();

            contaDoNicolas.titular = nicolas;
            contaDoNicolas.agenciaConta = 0001;
            contaDoNicolas.numeroConta = 1;

            contaDoNicolas.Depositar(100);

            Console.WriteLine(contaDoNicolas.titular.nome);
            Console.WriteLine(contaDoNicolas.ObterSaldo());

            Console.ReadLine();
        }
    }
}
