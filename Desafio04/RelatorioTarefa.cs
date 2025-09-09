using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class RelatorioTarefa : TarefaAgendada
    {
        public override void Executar()
        {
            Console.WriteLine("Gerando e enviando relatório diário...");
        }
    }
}
