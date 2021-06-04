using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    class B : A
    {
        public B() : base("Metodo de la clase B") 
        {
            //
        }
        
        public void M4()
        {
            Console.WriteLine("\nMetodo del hijo invocado\n");
        }
    }
}
