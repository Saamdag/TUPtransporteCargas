using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transporteCargas.models
{
    public class Carga
    {
        public int idTipo { get; set; }
        public decimal peso { get; set; }

        public Carga(int idTipo, decimal peso)
        {
            this.idTipo = idTipo;
            this.peso = peso;
        }
    }
    
}
