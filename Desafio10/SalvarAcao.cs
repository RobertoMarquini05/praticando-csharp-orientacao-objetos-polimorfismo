using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio10
{
    public class SalvarAcao : IAcaoBotao
    {
        public void Executar()
        {
            Console.WriteLine("Salvando dados no banco...");
        }
    }
}
