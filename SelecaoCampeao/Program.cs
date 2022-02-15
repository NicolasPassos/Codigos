using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecaoCampeao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando teste de aprendizado - Seleção de campeão LOL");

            Campeao zoe = new Campeao();

            zoe.nomeCampeao = "Zoe";
            zoe.complemento = "o aspecto do crepúsculo";
            zoe.tipoDano = "mágico";
            zoe.sexoCampeao = "Feminino";

            Console.WriteLine();
            Console.WriteLine("Selecione o seu campeão!");
            Console.WriteLine();

            string campeaoselecionado = "Zoe";

            bool tratamentoCampeao = zoe.Tratar("Masculino");

            if (tratamentoCampeao == true)
            {
                if (campeaoselecionado == zoe.nomeCampeao)
                {
                    Console.WriteLine("Você selecionou a " + zoe.nomeCampeao + ", " + zoe.complemento);
                    Console.WriteLine("O tipo de dano dela é "+zoe.tipoDano);
                }
            }
            if (zoe.sexoCampeao == null)
            {
                Console.WriteLine("Campeão sem sexo informado");
            }
            if (tratamentoCampeao == false)
            {
                Console.WriteLine("O tratamento do campeão foi selecionado erroneamente");
            }





            Console.ReadLine();
        }
    }
}
