using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio08
{
    public class Bicicleta : Transporte
    {
        public override int CalcularTempo(int distanciaKm)
        {
            return distanciaKm * 4;
        }
    }
}
