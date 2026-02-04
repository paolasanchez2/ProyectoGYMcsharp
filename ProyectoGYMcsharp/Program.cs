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
                Console.WriteLine("4.Inscribirte ACTIVE GYM");
                Console.WriteLine("------------------------------");
                Console.Write("\n elige una opcion (1-4):");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("-----Planes de membresia-----");

                        Console.WriteLine("Mes $599\n"); 
                        Console.WriteLine("Estudiante $450\n");
                        Console.WriteLine("Semana $350\n");
                        Console.WriteLine("Dia $99\n");
                        Console.WriteLine("Quincena $400\n");
                        Console.WriteLine("Semestral $2999\n");
                        Console.WriteLine("Anual $4999\n");
                        Console.WriteLine("Trimestral $1499\n");
                        break;

                    case "2":
                        Console.WriteLine("-----Horarios-----");
                        Console.WriteLine("Lunes a viernes 5:00 am a 12:00 am\n");
                        Console.WriteLine("Sabados 6:00 am a 10:00 pm\n");
                        Console.WriteLine("Domingos 8:00 am a 8:00 pm\n");
                        break;

                    case"3":

                        Console.WriteLine("-----Entrenadores personalizados-----");

                        Console.WriteLine("Paola Sanchez\nCorreo= Pao_Snchz@Gmail.com");

                        Console.WriteLine("Luis Ramirez\nCorreo= Luis_Rmz@Gmail.com");

                        Console.WriteLine("Ana Lopez\nCorreo= Ana_lpz@Gmail.com");
                        break;

                        case"4":

                        Console.WriteLine("-----Inscripcion ACTIVE GYM-----");
                        Console.WriteLine("INGRESA TU NOMBRE:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("INGRESA TU EDAD:");
                        string edad = Console.ReadLine();
                        Console.WriteLine("INGRESA FECHA DE NACIMIENTO:");
                        string fechaNacimiento = Console.ReadLine();
                        Console.WriteLine("Numero de emergencia");
                        string numeroEmergencia = Console.ReadLine();
                        Console.WriteLine("Gracias por inscribirte " + nombre + ", bienvenido a ACTIVE GYM!");
                        break;

                    default:
                        Console.WriteLine("elige una opcion disponible");
                        break;

                }
            } while (true);
        }
    }
}
