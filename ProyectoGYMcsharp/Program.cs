using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoGYMcsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {

                Console.WriteLine("Bienvenido ACTIVE GYM");
                Console.WriteLine("1.Ver planes de membresia");
                Console.WriteLine("2.Consultar horarios");
                Console.WriteLine("3.Contactar a un entrenador");
                Console.Write("\n elige una opcion (1-3):");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("planes mes (500)\n semana(150)\n Dia (70) ");
                        break;

                    case "2":
                        Console.WriteLine("De 5:00 am a 12:00 am");
                        break;

                    case "3":
                        Console.WriteLine("contactando");
                        break;

                    default:
                        Console.WriteLine("elige una opcion disponible");
                        break;

                }
            } while (true);
        }
    }
}
