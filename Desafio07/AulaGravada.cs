using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio07
{
    public class AulaGravada : Conteudo
    {
        public int Duracao { get; set; } // em minutos

        public AulaGravada(string titulo, int duracao) : base(titulo)
        {
            Duracao = duracao;
        }

        public override void ExibirInfo()
        {
            Console.WriteLine($"Título: {Titulo}");
            Console.WriteLine($"Duração: {Duracao} min\n");
        }
    }
}
