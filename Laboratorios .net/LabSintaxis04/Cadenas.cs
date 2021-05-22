using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis04
{
    public class Cadenas
    {
        public static void Claves(string password)
        {
            int intentos = 0;
            string clave;
            do
            {
                Console.Clear();
                intentos += 1;
                Console.Write("Ingresar clave:");
                clave = LectorClaves();
                if (clave == password)
                {
                    Console.WriteLine("\n\nClave Correcta!");
                    Console.WriteLine("Presionar alguna tecla para continuar");
                    Console.ReadKey();
                    break;
                }
                else 
                {
                    Console.WriteLine("\n\nClave Icorrecta!");
                    Console.WriteLine("Presionar alguna tecla para continuar");
                    Console.ReadKey();
                    continue;
                }
            } while (intentos < 4);
            return;
        }

        public static string LectorClaves()
        {
            string key="";
            ConsoleKey aux;
            do
            {
                aux=Console.ReadKey().Key;
                Console.Write("\b*");
                if (aux != ConsoleKey.Enter) key += aux.ToString();
            } while (aux != ConsoleKey.Enter);
            return key;
        }

        public static void Piramides()
        {
            Console.Write("Ingresar cantidad de filas: ");
            int n = 1;
            Console.Write("\n\n\n");
            for(int f = int.Parse(Console.ReadLine());f>0; f--)
            {
                String sp = new String(' ', f);
                String ast=new String('*',n);
                Console.WriteLine(sp+ast);
                n+=2;
            }
            Console.ReadKey();
        }
    }
}
