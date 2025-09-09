using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio09
{
    public class EmprestimoAposentado : IEmprestimo
    {
        public decimal CalcularValorFinal(decimal valor, int meses)
        {
            decimal taxa = 0.015m;
            return valor + (valor * taxa * meses);
        }
    }
}
