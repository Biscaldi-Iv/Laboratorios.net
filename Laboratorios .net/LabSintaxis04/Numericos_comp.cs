using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSintaxis04
{
    class Numericos_comp
    {
        public static void Llama_fib()
        {
            Console.Clear();
            Console.WriteLine("Ingresar num: ");
            int f = int.Parse(Console.ReadLine());
            int y = Fibonacci(f);

            Console.WriteLine("\n" + y + " es el " + f + "° numero de fibonacci\n");
        }

        private static int Fibonacci(int n)
        {
            if (n < 1) return 0;
            if (n < 3) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public static void Romanos()
        {
            Console.WriteLine("Ingresar numero entre 1 y 3999: ");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 3900) return;
            int um = numero / 1000;
            int cent = (numero - um * 1000) / 100;
            int dec = (numero - um * 1000 - cent * 100) / 10;
            int unidad = numero - um * 1000 - cent * 100 - dec * 10;

            if (um == 3) Console.Write("MMM");
            if (um == 2) Console.Write("MM");
            if (um == 1) Console.Write("M");

            if (cent == 9) Console.Write("CM");
            if (cent == 8) Console.Write("DCCC");
            if (cent == 7) Console.Write("DCC");
            if (cent == 6) Console.Write("DC");
            if (cent == 5) Console.Write("D");
            if (cent == 4) Console.Write("CD");
            if (cent == 3) Console.Write("CCC");
            if (cent == 2) Console.Write("CC");
            if (cent == 1) Console.Write("C");

            if (dec == 9) Console.Write("XC");
            if (dec == 8) Console.Write("LXXX");
            if (dec == 7) Console.Write("LXX");
            if (dec == 6) Console.Write("LX");
            if (dec == 5) Console.Write("L");
            if (dec == 4) Console.Write("XL");
            if (dec == 3) Console.Write("XXX");
            if (dec == 2) Console.Write("XX");
            if (dec == 1) Console.Write("X");

            if (unidad == 9) Console.Write("IX");
            if (unidad == 8) Console.Write("VIII");
            if (unidad == 7) Console.Write("VII");
            if (unidad == 6) Console.Write("VI");
            if (unidad == 5) Console.Write("V");
            if (unidad == 4) Console.Write("IV");
            if (unidad == 3) Console.Write("III");
            if (unidad == 2) Console.Write("II");
            if (unidad == 1) Console.Write("I");

        }

        public static void Primos()
        {
            Console.Clear();
            Console.Write("Ingresar numero: ");
            int numero = int.Parse(Console.ReadLine());
            bool b;
            int cont = 0;

            for (int i = 1; cont < numero; i++)
            {
                b = false;
                for (int r = i; r >= 1; r--)
                {
                    if (i % r == 0 && r != 1 && r != i)
                    {
                        b = true;
                        break;
                    }
                }
                if (b == false)
                {
                    Console.WriteLine(i);
                    cont++;
                }
            }
        }
    }
}
