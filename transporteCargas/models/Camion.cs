using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace transporteCargas.models
{
    public  class Camion
    {
        public int idCamion { get; set; }
        public string patente { get; set; }
        public int idEstado { get; set; }
        public decimal pesoMax { get; set; }

        //Lista cargas
        public List<Carga> cargas { get; set; }
        public Camion()
        {
            cargas = new List<Carga>();
        }

        public void agregarCarga(Carga carga)
        {
            cargas.Add(carga);
        }

        public void QuitarCarga(int indice)
        {
            cargas.RemoveAt(indice);
        }


        public decimal pesoDisponible()
        {
            try
            {
            decimal total = 0;
            foreach (Carga carga in cargas)
            {
                total += carga.peso;
            }
            return pesoMax - total;
            }
            catch
            {
                return pesoMax;
            }
        }
        
        public bool listoPartir()
        {
            decimal pesoActual = pesoMax - pesoDisponible();
            if ( (pesoMax * Convert.ToDecimal(0.75)) <= pesoActual)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}//max 1000 ocup 700 disp 300
