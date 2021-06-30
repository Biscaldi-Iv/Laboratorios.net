using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using empleados;

namespace Empleados
{
    class Program
    {
        static void Main(string[] args)
        {
            //4)	Dada una List<Empleado> donde Empleado tiene las propiedades Id (int), Nombre (string),
            //Sueldo (decimal). Crear un programa que acepte dar de alta Empleados en esta lista y luego muestre
            //por Consola esta misma Lista ordenada por la propiedad Sueldo, tanto de manera ascendente como descendente.
            while (menu()) { }

        }

        public static bool menu()
        {
            Console.Clear();
            Console.WriteLine("\n\n\t\t1-Alta de empleado\n" +
                "\t\t2-Consulta");
            int m = Convert.ToInt32(Console.ReadLine());

            switch (m)
            {
                case 1:
                    {
                        emps.Add(newEmp());
                        break; 
                    }
                case 2: 
                    {
                        ver();
                        break;
                    }
                default: return false;
            }
            
            return true;
        }

        public static List<empleado> emps= new List<empleado>();

        public static empleado newEmp()
        {
            Console.Clear();
            Console.Write("Ingresar nombre: ");
            string nom = Console.ReadLine();
            Console.Write("Ingresar suledo: ");
            decimal s = Convert.ToDecimal(Console.ReadLine());

            return new empleado(nom,s);
        }

        public static void ver()
        {
            var query = from empleado e in emps orderby e.Sueldo ascending select e;
            var query2 = from empleado e in emps orderby e.Sueldo descending select e;

            Console.Clear();
            Console.WriteLine("Empleados en orden ascendente por sueldo:");
            foreach(empleado e in query)
            {
                Console.WriteLine(e);
            }

            Console.WriteLine("\nEmpleados en orden descendente por sueldo:");
            foreach (empleado e in query2)
            {
                Console.WriteLine(e);
            }
            Console.ReadKey();
        }
    }

}
