using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Venda
    {
        int peixe;
        int id;
        double precoTotal;
        int quantidade;

        public int Peixe { get => peixe; set => peixe = value; }
        public int Id { get => id; set => id = value; }
        public double PrecoTotal { get => precoTotal; set => precoTotal = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
    }
}
