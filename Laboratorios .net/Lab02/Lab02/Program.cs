using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            string val1="Este es el valor 1";
            int val2 = 5;
            string val3 = val1;
            Console.WriteLine(val1);
            Console.WriteLine(val2);
            Console.WriteLine(val3);
            Console.WriteLine();
            Console.WriteLine("Presionar tecla para continuar");
            _ = Console.ReadKey();
        }
    }
}
