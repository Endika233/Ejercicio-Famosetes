using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Famosetes
{
    class CantanteFamoso
    {
        private string nombre, discoConMasVentas;
        
        public CantanteFamoso(string nombre,string discoConMasVentas)
        {
            this.nombre = nombre;
            this.discoConMasVentas = discoConMasVentas;
        }
        public CantanteFamoso()
        {
        }
        public void AñadirCant(string nombre)
        {
            this.nombre = nombre;
        }
        public void AñadirDisco(string discoConMasVentas)
        {
            this.discoConMasVentas = discoConMasVentas;
        }
        public string GetCant()
        {
            return nombre;
        }
        public string GetDisco()
        {
            return discoConMasVentas;
        }
    }
}
