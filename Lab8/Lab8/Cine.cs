using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Cine:LocalComercial
    {
        public int numeroSalas;

        public Cine(string ownerName, int id, string horario, int numeroSalas) : base(ownerName, id, horario)
        {
            this.numeroSalas = numeroSalas;
        }
    }
}
