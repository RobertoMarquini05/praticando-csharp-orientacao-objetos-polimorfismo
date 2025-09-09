using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio02
{
    public class Gerente : Funcionario
    {
        public override string GerarRelatorio()
        {
            return "Relatório do gerente: supervisiona a equipe.";
        }
    }
}
