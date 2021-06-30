using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_objets
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] provincias = { "Buenos Aires", "Catamarca", "Chaco","Chubut", "Cordoba",
                "Corrientes","Entre Rios", "Formosa","Jujuy","La Pampa","La Rioja", "Mendoza",
                "Misiones","Neuquen", "Rio Negro", "Salta","San Juan", "San Luis","Santa Cruz",
                "Santa Fe","Santiago del Estero","Tierra del Fuego","Tucuman"};

            var consulta = from p in provincias where p.First() == 'T' || p.First() == 'S' select p;

            Console.WriteLine("Provincias que empiezan con T o con S:");
            foreach(string p in consulta)
            {
                Console.WriteLine($"- {p}");
            }
            Console.ReadKey();
        }
    }
}
