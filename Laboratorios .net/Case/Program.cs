using System;


namespace Case
{
    class Program
    {
        const ConsoleKey A = ConsoleKey.D1;
        const ConsoleKey B = ConsoleKey.D2;
        const ConsoleKey C = ConsoleKey.D3;
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
                Console.Write(" Desea salir? s/n:");
                inputTexto = Console.ReadLine();
            } while (inputTexto != "s");
        }
        static void menu(string txt)
        {

            ConsoleKeyInfo opcion = lector();
            while (opcion.Key != ConsoleKey.Escape)
            {
                switch (opcion.Key)
                {
                    case A:
                        Console.WriteLine("Texto en mayusculas: " + txt.ToUpper());
                        break;
                    case B:
                        Console.WriteLine("Texto en minusculas: " + txt.ToLower());
                        break;
                    case C:
                        Console.WriteLine("Longitud del texto: " + txt.Length);
                        break;
                }

                Console.ReadKey();
                opcion = lector();
            }
            static ConsoleKeyInfo lector()
            {
                Console.Clear();
                Console.WriteLine("1-Texto en mayusculas");
                Console.WriteLine("2-Texto en minusculas");
                Console.WriteLine("3-Longitud del texto");
                Console.WriteLine("Esc- Salir");
                Console.WriteLine();
                Console.WriteLine("Ingresar opcion:");
                ConsoleKeyInfo opcion = Console.ReadKey();
                Console.Clear();
                return opcion;
            }
        }
    }
}
