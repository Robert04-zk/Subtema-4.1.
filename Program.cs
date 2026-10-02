using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtema_4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string codigo="", carrera="", saludo="";
            do
            {
                Console.Clear();
                Console.WriteLine("-------MENU DE OPCCIONES-------");
                Console.WriteLine("1.leer código de estudiante y carrera");
                Console.WriteLine("2.Formar una nueva etiqueta textual con ambos (concatenado).");
                Console.WriteLine("3.Mostrar longitud de caracteres del código, carrera y etiqueta.");
                Console.WriteLine("4.Mostrar el primer y último carácter del código");
                Console.WriteLine("5.Imprimir la carrera carácter por carácter.");
                Console.WriteLine("6.Cree una nueva etiqueta de bienvenida");
                Console.WriteLine("7. Salir del menu");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el codigo");
                        codigo = Console.ReadLine();
                        Console.WriteLine("Carrera");
                        carrera = Console.ReadLine();
                        break;

                    case 2:
                        saludo = codigo + "|carrera: " + carrera;
                        Console.WriteLine("Etiqueta generada : " + saludo);
                        break;

                    case 3:
                        Console.WriteLine("La longitud de codigo es: " + codigo.Length);
                        Console.WriteLine("La longitud de la carrera es: " + carrera.Length);
                        Console.WriteLine("La longitud del saludo es: " + saludo.Length);
                        break;

                    case 4:
                        Console.WriteLine("el primer caracter es: " + carrera[0]);
                        Console.WriteLine("el ultimo caracter es: " + carrera[carrera.Length - 1]);

                        break;

                    case 7:Console.WriteLine("Saliendo...");

                        break;

                    default: Console.WriteLine("opcion no valida");
                        break;


                }
                Console.ReadKey();

            } while (opcion!=7);// > < >= <= == !=(distinto a)

        }
    }
}
