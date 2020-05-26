using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Restaurante:LocalComercial
    {
        public bool exclusivo;

        public Restaurante(string ownerName, int id, string horario, bool exclusivo):base(ownerName, id, horario)
        {
            this.exclusivo = exclusivo;
        }
    }
}
