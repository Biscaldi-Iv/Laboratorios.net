using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace numeros
{
    class Program2
    {
        public static void Main(string[] args) 
        {
            //2)	Crear un programa que acepte una lista de números, los almacene en un objeto del tipo List<int>
            //y luego usando LINQ muestre por Consola aquellos que son mayores a 20.
            //
            List<int> nums = new List<int>();
            char c;
            do
            {
                Console.Write("Ingresar numero:");
                int n = Convert.ToInt32(Console.ReadLine());
                nums.Add(n);
                Console.Write("S- continuar/ otro- salir : ");
                c = Convert.ToChar(Console.ReadLine().ToLower().First());
            } while (c == 's');

            var n20 = from n in nums where n >= 20 select n;

            Console.WriteLine("Numeros mayores o iguales que 20 ingresados:");
            foreach(int n in n20)
            {
                Console.WriteLine($"-{n}");
            }
            Console.ReadKey();
        }
    }
}
