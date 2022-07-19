using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autocarro.Src
{
    internal class Tipos
    {
        public string Carro { get; set; }

        public int Tipo { get; set; }

        public int Preco { get; set; }

        public Tipos(string carro, int tipo, int preco)
        {
            Carro = carro;
            Tipo = tipo;
            Preco = preco;

        }
        public override string ToString()
        {
            return "O carro é um: " + Carro +"\n tipo do carro: "+ Tipo +"\n Preço do carro : " + Preco ;
        }


    }
}
