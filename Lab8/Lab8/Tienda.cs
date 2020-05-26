using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Tienda:LocalComercial
    {
        public List<string> categorias;

        public Tienda(string ownerName, int id, string horario,List<string> categorias):base(ownerName, id, horario)
        {
            this.categorias = categorias;
        }
    }
}
