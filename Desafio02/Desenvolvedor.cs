using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    public class Desenvolvedor : Funcionario
    {
        public override string GerarRelatorio()
        {
            return "Relatório do desenvolvedor: escreve código e corrige bugs.";
        }
    }
}
