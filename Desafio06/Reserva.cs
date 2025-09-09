using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio06
{
    public class Reserva
    {
        public string NomeAtividade { get; set; }

        public Reserva(string nomeAtividade)
        {
            NomeAtividade = nomeAtividade;
        }

        public virtual void Confirmar()
        {
            Console.WriteLine($"Confirmando reserva: {NomeAtividade}");
        }
    }
}
