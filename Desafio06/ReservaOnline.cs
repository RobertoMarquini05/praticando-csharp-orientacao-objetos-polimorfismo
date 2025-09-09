using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    public class ReservaOnline : Reserva
    {
        public ReservaOnline(string nomeAtividade) : base(nomeAtividade) { }

        public override void Confirmar()
        {
            Console.WriteLine($"Confirmando reserva online: {NomeAtividade}");
            Console.WriteLine("Link de acesso enviado por e-mail!");
        }
    }
}
