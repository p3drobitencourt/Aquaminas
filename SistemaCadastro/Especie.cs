using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastro
{
    internal class Especie
    {
        string nome;
        int id;
        double preco;

        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
        public double Preco { get => preco; set => preco = value; }
    }
}
