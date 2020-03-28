using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{

    public class Restaurant : Attribute
    {
        public String nombre;
        public String direccion;
        public String telefono;
        public int cantMesas;
        public string[] mesas;
        public string[] menu;

        public Restaurant (string nombre, string telefono, string direccion, int cantMesas)
        {
            this.nombre = nombre;
            this.direccion =  direccion;
            this.telefono = telefono;
            this.cantMesas = cantMesas;


        }



    }
  
}
