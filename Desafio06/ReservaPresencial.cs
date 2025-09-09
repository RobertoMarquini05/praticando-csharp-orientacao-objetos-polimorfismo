using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    public class ReservaPresencial : Reserva
    {
        public ReservaPresencial(string nomeAtividade) : base(nomeAtividade) { }

        public override void Confirmar()
        {
            Console.WriteLine($"Confirmando reserva presencial: {NomeAtividade}");
            Console.WriteLine("Ponto de encontro: Praça Central, às 8h");
        }
    }
}
