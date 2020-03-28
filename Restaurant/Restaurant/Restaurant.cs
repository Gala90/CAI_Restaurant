using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
     public class Restaurant
     {             
            private String nombre;
            private String direccion;
            private String telefono;
            private int cantMesas;
            private int[] mesas;
            private List<String> menu;


            public Restaurant(string nombre, string telefono, string direccion, int cantMesas)
            {
                this.nombre = nombre;
                this.telefono = telefono;
                this.direccion = direccion;
                this.cantMesas = cantMesas;
            
            }

            public String NombreRestaurant
            {
            get {
                return this.nombre;
            }
            set { this.nombre = value; }
            }

           public String TelefonoRestaurant
           {
            get
            {
                return this.telefono;
            } set { this.telefono = value; }
            }


           public String DireccionRestaurant
           {
            get
            {
                return this.direccion;
            }
            set { this.direccion = value; }
           }

        public String MenuRestaurant
        {
            get
            {
                return this.direccion;
            }
            set { this.direccion = value; }
        }

        public void mostrarRestaurant() {

            Console.WriteLine("Nombre: " + NombreRestaurant + " Telefono: " + TelefonoRestaurant + " Direccion: " + DireccionRestaurant);

            }


        public void reservarMesa()
        {

        }

        /*
        public void agregarComida (string comida)
            {
            menu.Add(comida);                         
            }

        
        public void mostrarMenu()
        {
            foreach (string comida in menu)
            {
                Console.WriteLine(comida);
            }
        }
            


    */
    }
}
