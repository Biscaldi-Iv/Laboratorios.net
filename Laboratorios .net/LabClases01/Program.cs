using System;
using Clases;

namespace LabClases01
{
    class Program
    {
        static void Main(string[] args)
        {
            A Ia = new A();
            A Ia2 = new A("ia2");
            B Ib = new B();

            Console.WriteLine("\nInstancia de A usando constructor por defecto");
            Console.Write("\nIa: ");
            Ia.MostrarNombre();
            Ia.M1();
            Ia.M2();
            Ia.M3();

            Console.WriteLine("\nInstancia de A usando constructor con parametro");
            Console.Write("\nIa2: ");
            Ia2.MostrarNombre();
            Ia2.M1();
            Ia2.M2();
            Ia2.M3();

            Console.WriteLine("\nInstancia de B usando constructor por defecto con herencia");
            Console.Write("\nIb: ");
            Ib.MostrarNombre();
            Ib.M1();
            Ib.M2();
            Ib.M3();
            Ib.M4();

        }
    }
}
