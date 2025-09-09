using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio09
{
    public interface IEmprestimo
    {
        decimal CalcularValorFinal(decimal valor, int meses);
    }
}
