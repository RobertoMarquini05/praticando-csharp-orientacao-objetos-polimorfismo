using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    public class MaterialComplementar : Conteudo
    {
        public int Paginas { get; set; }

        public MaterialComplementar(string titulo, int paginas) : base(titulo)
        {
            Paginas = paginas;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Páginas: {Paginas}\n");
        }
    }
}
