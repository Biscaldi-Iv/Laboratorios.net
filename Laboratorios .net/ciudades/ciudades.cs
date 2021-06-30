using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ciudades
{
    public class ciudades
    {
        private int cod_postal;
        private string nombre;

        public int CPost
        {
            get => this.cod_postal;
            set { this.cod_postal = value; }
        }

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        public override string ToString()
        {
            return $"Cod. Postal:{this.CPost} Ciudad:{this.Nombre} ";
        }

    }
}
