﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{

  public class Program
    {
        static void Main(string[] args)
        {
            Restaurant miRestaurant = new Restaurant("La farola", "41234567", "Calle Falsa 123", 2);
            
            miRestaurant.mostrarRestaurant();

            miRestaurant.mesasDisponibles();

            miRestaurant.reservarMesa();            

            miRestaurant.reservarMesa();

            miRestaurant.reservarMesa();


            /*
              string comida;
            Console.WriteLine("Que plato quiere agregar al menu? ");
            comida = Console.ReadLine();
            miRestaurant.agregarComida(comida);

            */

            Console.ReadKey();
        }
    }

}
