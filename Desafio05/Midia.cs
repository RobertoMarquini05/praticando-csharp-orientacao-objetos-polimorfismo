using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    public class Midia
    {
        public string Nome { get; set; }

        public Midia(string nome)
        {
            Nome = nome;
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Mídia: {Nome}");
        }
    }
}
