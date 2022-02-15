using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4___ByteBank_Saque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Aula 4 Alura - ByteBank Função Saque");

            ContaCorrente contaDoNicolas = new ContaCorrente();

            contaDoNicolas.titularConta = "Nicolas Duarte Dos Passos";
            contaDoNicolas.agenciaConta = 0001;
            contaDoNicolas.numeroConta = 1;
            contaDoNicolas.saldoConta = 1000.0;

            ContaCorrente contaDaClara = new ContaCorrente();

            contaDaClara.titularConta = "Clara Luiza De Assunção Morais";
            contaDaClara.agenciaConta = 0001;
            contaDaClara.numeroConta = 2;
            contaDaClara.saldoConta = 2000;

            Console.WriteLine("O saldo atual da conta é de:");
            Console.WriteLine(contaDoNicolas.saldoConta);
            
            //Exemplo Função Saque
            //obs: para usar em comparações, deve-se criar uma variável para um método ou função booleana escolhido. Como no exemplo abaixo.
            bool resultadoSaque = contaDoNicolas.Sacar(1000);

            if (resultadoSaque == false)
            {
                Console.WriteLine("Erro 001");
                Console.WriteLine("O valor de saque é maior que o saldo disponível na conta.");
            }
            else
            {
                Console.WriteLine("Saque realizado com sucesso, "+contaDoNicolas.titularConta+"! O saldo atual da sua conta é de:");
                Console.WriteLine(contaDoNicolas.saldoConta);
            }

            //Exemplo Função Depósito
            //obs: nessa não foi criado uma variável para comparação pois o método ou função não retorna valores (void).
            contaDoNicolas.Depositar(1000);
            Console.WriteLine("Depósito realizado com sucesso! O saldo atual da sua conta é de:");
            Console.WriteLine(contaDoNicolas.saldoConta);


            //Exemplo Função Transferência
            //obs: foi criado uma variável bool para poder utilizar o if assim como a função saque.
            bool validaTransferencia = contaDaClara.Transferir(500, contaDoNicolas);
            
            if (validaTransferencia == false)
            {
                Console.WriteLine("Erro 1");
                Console.WriteLine("O valor a ser transferido é maior que o saldo disponível");
            }
            else
            {
                Console.WriteLine("Transferência realizada com sucesso! O saldo disponível na conta de " + contaDaClara.titularConta + " é de:");
                Console.WriteLine(contaDaClara.saldoConta);
                Console.WriteLine(contaDoNicolas.titularConta + ", você recebeu uma transferência de " + contaDaClara.titularConta);
                Console.WriteLine("O saldo atual da conta de "+contaDoNicolas.titularConta+" é de:");
                Console.WriteLine(contaDoNicolas.saldoConta);
            }





            Console.ReadLine();

        }
    }
}
