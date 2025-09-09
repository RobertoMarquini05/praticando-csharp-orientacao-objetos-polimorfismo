using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class BackupTarefa : TarefaAgendada
    {
        public override void Executar()
        {
            Console.WriteLine("Executando tarefa de backup do sistema...");
        }
    }
}
