using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    public class ExcluirAcao : IAcaoBotao
    {
        public void Executar()
        {
            Console.WriteLine("Excluindo registro do sistema...");
        }
    }
}
