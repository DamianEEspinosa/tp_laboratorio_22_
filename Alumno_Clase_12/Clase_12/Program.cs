using Clase_12_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Clase_12
{
    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        static void Main(string[] args)
        {
            Concesionaria concesionaria = new Concesionaria(5);

            Camion c1 = new Camion(Vehiculo.EMarca.Scania, "ASD012", ConsoleColor.Black);
            Camion c2 = new Camion(Vehiculo.EMarca.Iveco, "ASD913", ConsoleColor.Red);
            Moto m1 = new Moto(Vehiculo.EMarca.BMW, "HJK789", ConsoleColor.White);
            Moto m2 = new Moto(Vehiculo.EMarca.Yamaha, "IOP852", ConsoleColor.Blue);
            Automovil a1 = new Automovil(Vehiculo.EMarca.Chevrolet, "QWE968", ConsoleColor.Gray);
            Automovil a2 = new Automovil(Vehiculo.EMarca.Ford, "TYU426", ConsoleColor.DarkBlue);
            Automovil a3 = new Automovil(Vehiculo.EMarca.Scania, "IOP852", ConsoleColor.Green);

            // Agrego 6 ítems (los últimos 2 no deberían poder agregarse) y muestro
            concesionaria += c1;
            concesionaria += c2;
            concesionaria += m1;
            concesionaria += m2;
            concesionaria += a1;
            concesionaria += a2;
            concesionaria += a3;

            Console.WriteLine(concesionaria.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Quito un item y muestro
            concesionaria -= c1;

            Console.WriteLine(concesionaria.ToString());
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Motos
            Console.WriteLine(Concesionaria.Mostrar(concesionaria, Concesionaria.ETipo.Moto));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Camiones
            Console.WriteLine(Concesionaria.Mostrar(concesionaria, Concesionaria.ETipo.Camion));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
            Console.Clear();

            // Muestro solo Automoviles
            Console.WriteLine(Concesionaria.Mostrar(concesionaria, Concesionaria.ETipo.Automovil));
            Console.WriteLine("<---------------------------------------------->");
            Console.ReadKey();
        }
    }
}
