using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio09
{
    public class EmprestimoEstudante : IEmprestimo
    {
        public decimal CalcularValorFinal(decimal valor, int meses)
        {
            decimal taxa = 0.01m;
            return valor + (valor * taxa * meses);
        }
    }
}
