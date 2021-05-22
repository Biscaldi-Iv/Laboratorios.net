using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis04
{
    class Numericos_simples
    {
        public static void Suma()
        {
            int x, y;
            Console.Clear();
            Console.WriteLine("Ingresar valor 1: ");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresar valor 2: ");
            y = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de " + x + " con " + y + " es %i " + (x + y));

        }

        public static void Bisiesto()
        {
            int anio;
            Console.Clear();
            Console.WriteLine("Ingresar año");
            anio = int.Parse(Console.ReadLine());

            if (anio < 1582)
            {
                Console.WriteLine("Año fuera de calendario gregoriano");
            }
            else if (anio % 4 != 0 || (anio % 100 == 0 && anio % 400 != 0))
            {
                Console.WriteLine("\nAño no bisiesto!\n");
            }
            else
            {
                Console.WriteLine("\nAño bisiesto!\n");
            }
        }



        public static void Pares()
        {
            Console.Clear();
            for (int i = 1; i < 100; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        public static void Mes()
        {
            Console.Clear();
            Console.Write("Ingresar nombre del mes:");
            string cad = Console.ReadLine().ToUpper();
            switch (cad)
                {
                case "ENERO":
                    Console.WriteLine(cad + "\t1");
                    break;
                case "FEBRERO":
                    Console.WriteLine(cad + "\t2");
                    break;
                case "MARZO":
                    Console.WriteLine(cad + "\t3");
                    break;
                case "ABRIL":
                    Console.WriteLine(cad + "\t4");
                    break;
                case "MAYO":
                    Console.WriteLine(cad + "\t5");
                    break;
                case "JUNIO":
                    Console.WriteLine(cad + "\t6");
                    break;
                case "JULIO":
                    Console.WriteLine(cad + "\t7");
                    break;
                case "AGOSTO":
                    Console.WriteLine(cad + "\t8");
                    break;
                case "SEPTIEMBRE":
                    Console.WriteLine(cad + "\t9");
                    break;
                case "OCTUBRE":
                    Console.WriteLine(cad + "\t10");
                    break;
                case "NOVIEMBRE":
                    Console.WriteLine(cad + "\t11");
                    break;
                case "DICIEMBRE":
                    Console.WriteLine(cad + "\t12");
                    break;
                default:
                    Console.WriteLine("Nombre de mes mal ingresado!");
                    break;
            }
            Console.ReadKey();
            return;

        }
    }
}
