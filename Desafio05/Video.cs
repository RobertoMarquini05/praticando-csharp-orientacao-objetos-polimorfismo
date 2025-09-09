using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    public class Video : Midia
    {
        public int Duracao { get; set; } // em minutos

        public Video(string nome, int duracao) : base(nome)
        {
            Duracao = duracao;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Vídeo: {Nome} - Duração: {Duracao} minutos");
        }
    }
}
