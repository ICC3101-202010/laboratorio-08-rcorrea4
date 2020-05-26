using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class LocalComercial
    {
        private string ownerName;
        private int id;
        private string horario;

        public string OwnerName { get => ownerName; set => ownerName = value; }
        public int Id { get => id; set => id = value; }
        public string Horario { get => horario; set => horario = value; }
        
        public LocalComercial(string ownerName,int id,string horario)
        {
            this.ownerName = ownerName;
            this.id = id;
            this.horario = horario;
        }
    }
}
