using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelecaoCampeao
{
    public class Campeao
    {
        public string nomeCampeao;
        public string complemento;
        public string tipoDano;
        public string sexoCampeao;

        public bool Tratar(string tratamento)
        {
            if (this.sexoCampeao == tratamento)
            {
                return true;
            }
            else
                return false;
        }
    }
}
