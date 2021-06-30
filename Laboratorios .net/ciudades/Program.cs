using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ciudades;
using System.Collections;

namespace ciudades
{
    class Program
    {
        static void Main(string[] args)
        {
            //3)	Dado un ArrayList que incluya al menos 10 Ciudades de Argentina incluyendo
            //Nombre y Código Postal usar LINQ para obtener y mostrar por Consola el Código Postal
            //de aquellas ciudades que incluyan dentro de su nombre una expresión de busqueda de tres
            //caracteres, sin respetar mayusculas o minusculas. Por ejemplo, si se ingresa “ros” y el
            //ArrayList incluye Rosario entonces debe mostrarse el Código Postal de Rosario.
            ArrayList cities = new ArrayList();

            #region ciudades_memoria
            cities.Add(new ciudades { CPost = 2000, Nombre = "Rosario" });
            cities.Add(new ciudades { CPost = 2152, Nombre = "Granadero Baigorria" });
            cities.Add(new ciudades { CPost = 2124, Nombre = "Villa Gobernador Galvez" });
            cities.Add(new ciudades { CPost = 2121, Nombre = "Perez" });
            cities.Add(new ciudades { CPost = 2132, Nombre = "Funes" });
            cities.Add(new ciudades { CPost = 2128, Nombre = "Arroyo Seco" });
            cities.Add(new ciudades { CPost = 2126, Nombre = "Pueblo Esther" });
            cities.Add(new ciudades { CPost = 2107, Nombre = "Alvarez" });
            cities.Add(new ciudades { CPost = 2109, Nombre = "Aceval" });
            cities.Add(new ciudades { CPost = 2123, Nombre = "Zaballa" });
            cities.Add(new ciudades { CPost = 2126, Nombre = "Fighiera" });
            cities.Add(new ciudades { CPost = 2130, Nombre = "Alvear" });
            #endregion

            Console.Write("Inregar caracteres de busqueda(3): ");
            string search = Console.ReadLine().Substring(0, 3).ToLower();
            var query = from ciudades c in cities where c.Nombre.ToLower().Contains(search) select c;

            Console.WriteLine("Ciudades encontradas:");

            foreach(ciudades c in query)
            {
                Console.WriteLine(c);
            }

            Console.ReadKey();


        }

    }
}
