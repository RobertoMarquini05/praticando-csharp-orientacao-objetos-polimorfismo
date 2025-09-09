using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio05
{
    public class Imagem : Midia
    {
        public string Resolucao { get; set; }

        public Imagem(string nome, string resolucao) : base(nome)
        {
            Resolucao = resolucao;
        }

        public override void ExibirDetalhes()
        {
            Console.WriteLine($"Imagem: {Nome} - Resolução: {Resolucao}");
        }
    }
}
