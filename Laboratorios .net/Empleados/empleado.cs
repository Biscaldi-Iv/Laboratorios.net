using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace empleados
{
    public class empleado
    {
        private int id;
        private string nombre;
        private decimal sueldo;
        private static int id_gen = 0;

        public int ID
        {
            get => this.id;
            set { this.id = value; }
        }

        public string Nombre
        {
            get => this.nombre;
            set => this.nombre = value;
        }

        public decimal Sueldo
        {
            get => this.sueldo;
            set => this.sueldo = value;
        }

        public override string ToString()
        {
            return $"ID:{this.ID}  Nombre:{this.Nombre}  sueldo:{this.sueldo}";
        }

        private static int IDGen()
        {
            id_gen += 1;
            return id_gen;
        }

        public empleado(string nombre_, decimal sueldo_)
        {
            this.ID = IDGen();
            this.Nombre = nombre_;
            this.Sueldo = sueldo_;
        }

    }
}
