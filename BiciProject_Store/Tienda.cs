using System;
using System.Collections.Generic;

namespace BiciProject_Store
{
    class Tienda
    {
        static void Main()
        {
            
            Console.WriteLine("BIKE STORE, ¿Que acción desea ejecutar? : Presione! \n 1. Para Agregar una nueva Bici \n 2. Para enlistar los productos en Stock \n 0. Para Salir ");
            int opciones = Convert.ToInt32(Console.ReadLine());
            switch (opciones)
            {
                case 1: Add_Method();
                        break;
                case 2: List_Method();
                    break;
                case 3: Console.Clear();
                    Console.WriteLine("BIKE STORE Se encuentra cerrado");
                    break;
            }

        }        

        
        static void Add_Method()
        {
            LinkedList<Object> BikeList = new LinkedList<Object>();
            BCarrera BiciCarrera = new BCarrera();
            BCross BiciCross = new BCross();
            Console.WriteLine("Seleccione el tipo de Bicicleta que desea ingresar \n 1: Carreras \n 2: Bicicross");
            int opciones = Convert.ToInt32(Console.ReadLine());
            switch (opciones)
            {
                case 1: Console.WriteLine("Usted va a ingresar una Bicicleta de carreras");
                    Console.WriteLine("¿Rin de bicicleta?");
                    BiciCarrera.Rin = Convert.ToInt32(Console.ReadLine());
                    BikeList.AddLast(BiciCarrera.Rin);
                    Console.WriteLine("¿# Velocidades de bicicleta?");
                    BiciCarrera.Nvel = Convert.ToInt32(Console.ReadLine());
                    BikeList.AddLast(BiciCarrera.Nvel);
                    Console.WriteLine("¿Marce de la bicicleta?");
                    BiciCarrera.Marca = Console.ReadLine();
                    BikeList.AddLast(BiciCarrera.Marca);
                    Console.WriteLine("¿Peso de bicicleta?");
                    BiciCarrera.Peso = Convert.ToInt32(Console.ReadLine());
                    BikeList.AddLast(BiciCarrera.Peso);
                    break;

                case 2:
                    Console.WriteLine("Usted va a ingresar una Bicicleta de Cross");
                    Console.WriteLine("¿Rin de bicicleta?");
                    BiciCross.Rin = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("¿# Velocidades de bicicleta?");
                    BiciCross.Nvel = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("¿Marce de la bicicleta?");
                    BiciCross.Marca = Console.ReadLine();
                    Console.WriteLine("¿Peso de bicicleta?");
                    BiciCross.Material = Console.ReadLine();
                    break;
            }
        }

        static void List_Method()
        {
            

        }

        
    }
}
