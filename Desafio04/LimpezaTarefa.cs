using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio04
{
    public class LimpezaTarefa : TarefaAgendada
    {
        public override void Executar()
        {
            Console.WriteLine("Limpando arquivos temporários do servidor...");
        }
    }
}
