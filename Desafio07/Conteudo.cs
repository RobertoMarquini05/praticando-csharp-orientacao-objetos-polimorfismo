using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    public class Conteudo
    {
        public string Titulo { get; set; }

        public Conteudo(string titulo)
        {
            Titulo = titulo;
        }

        public virtual void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}");
        }
    }
}
