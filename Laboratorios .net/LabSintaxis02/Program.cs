using System;

namespace LabSintaxis02
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTexto;

            do
            {
                Console.Write("Ingresar texto:");
                inputTexto = Console.ReadLine();
                Console.WriteLine();
                if (inputTexto.Length == 0)
                {
                    Console.WriteLine("No se ha ingresado texto!");
                }
                else
                {
                    menu(inputTexto);
                }
                Console.Clear();
                Console.Write("¿Desea salir? s/n:");
                inputTexto=Console.ReadLine();
            } while (inputTexto!="s");
        }
        static void menu( string txt ) 
        {

            ConsoleKeyInfo opcion=lector();
            while (opcion.Key != ConsoleKey.Escape)
            {
                if (opcion.Key== ConsoleKey.D1)
                {
                    Console.WriteLine("Texto en mayusculas: " + txt.ToUpper());
                }
                if (opcion.Key==ConsoleKey.D2)
                {
                    Console.WriteLine("Texto en minusculas: " + txt.ToLower());
                }
                if (opcion.Key==ConsoleKey.D3)
                {
                    Console.WriteLine("Longitud del texto: " + txt.Length);
                }
                Console.ReadKey();
                opcion = lector();
            } 
        }

        static ConsoleKeyInfo lector() 
        {
            Console.Clear();
            Console.WriteLine("1-Texto en mayusculas");
            Console.WriteLine("2-Texto en minusculas");
            Console.WriteLine("3-Longitud del texto");
            Console.WriteLine("S- Salir");
            Console.WriteLine();
            Console.WriteLine("Ingresar opcion:");
            ConsoleKeyInfo opcion = Console.ReadKey();
            Console.Clear();
            return opcion;
        }
    }
}
