using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace praticando_csharp_orientacao_objetos_polimorfismo
{
    public class Calculadora
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Somar(int a, int b, int c)
        {
            return a + b + c;
        }

        public double Somar(double a, double b)
        {
            return a + b;
        }
    }
}
