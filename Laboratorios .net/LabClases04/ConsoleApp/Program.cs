using System;
using System.Collections.Generic;
using Clase_Persona;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (menu()) { }
        }

        static List<Persona> listado = new List<Persona>();

        static bool menu()
        {
            Console.Clear();
            Console.WriteLine("\n\n" +
                "\t\t1-Crear Persona" +
                "\n\t\t2-Borrar Persona" +
                "\n\t\t3-Ver Personas" +
                "\n\t\tOtro-Salir" +
                "\nOPCION:");
            int n = int.Parse(Console.ReadLine());
            Console.Clear();
            switch (n) 
            { 
                case 1: 
                    {
                        Console.Write("Nombre: ");
                        string nombre = Console.ReadLine(); 
                        Console.Write("Apellido: ");
                        string apellido = Console.ReadLine();
                        Console.Write("DNI :");
                        int dni = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Fecha de nacimiento:");
                        Console.Write("\tDia: ");
                        int dia = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\tMes: ");
                        int mes = Convert.ToInt16(Console.ReadLine());
                        Console.Write("\tAño: ");
                        int año = Convert.ToInt16(Console.ReadLine());
                        Persona p = new Persona(nombre, apellido, new DateTime(año, mes, dia, 0, 0, 0), dni);
                        listado.Add(p);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Ingresar dni: ");
                        int dni= Convert.ToInt32(Console.ReadLine());
                        bool mensaje = true;//mensaje de no existencia
                        foreach (Persona p in listado) 
                        {
                            if (p.DNI == dni) 
                            {
                                mensaje = false;//existe
                                listado.Remove(p);
                                break;
                            }
                        }
                        if (mensaje) 
                        {
                            Console.WriteLine($"No hay personas con dni={dni}");
                        }
                        
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("\tNombre \t\tDNI \t\tEdad");
                        foreach(Persona p in listado)
                        {
                            Console.WriteLine($"\t{p.GetFullName()} \t\t{ p.DNI} \t\t{ p.GetAge()}");
                        }
                        break;
                    }
                default: return false; 
            }
            Console.ReadKey();
            return true;
        }



    }



 
}
