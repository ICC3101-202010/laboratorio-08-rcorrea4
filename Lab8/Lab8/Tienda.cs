using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Tienda:LocalComercial
    {
        public List<string> categorias=new List<string>();

        public Tienda(string ownerName, int id, string horario):base(ownerName, id, horario)
        {
            
        }
    }
}
