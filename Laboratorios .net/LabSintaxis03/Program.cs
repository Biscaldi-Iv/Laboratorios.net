using System;

namespace LabSintaxis03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresar cant iteraciones:");
            int cantIteraciones = int.Parse(Console.ReadLine());
            string[] arreglo = new string[cantIteraciones];

            for (int i = 0; i < cantIteraciones; i++) 
            {
                
                Console.Write("Ingresar cadena: ");
                arreglo[i] = Console.ReadLine();

            }

            Console.WriteLine("\nMuestra en reversa:\n");

            for (int i = cantIteraciones-1; i >= 0; i--) 
            {
                Console.WriteLine(arreglo[i]);
            }

        }
    }
}
