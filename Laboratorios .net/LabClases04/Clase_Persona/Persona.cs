using System;

namespace Clase_Persona
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fnac;
        private int _dni;

        public Persona(string nom, string ap, DateTime fnac, int dni_)
        {
            this.Nombre = nom;
            this.Apellido = ap;
            this.DNI = dni_;
            this.Fnac = fnac;

            Console.WriteLine($"Created Persona(Nombre={this.Nombre}, Apellido={this.Apellido}, DNI={this.DNI}, Fnac={this.Fnac.ToShortDateString()})");

        }

        ~Persona()
        {
            Console.WriteLine($"Deleted Persona(Nombre={this.Nombre}, Apellido={this.Apellido}, DNI={this.DNI}, Fnac={this.Fnac.ToShortDateString()})");
        }

        public string Nombre
        {
            get => this._nombre;
            set
            {
                this._nombre = value;
            }
        }

        public string Apellido
        {
            get => this._apellido;
            set
            {
                this._apellido = value;
            }
        }

        

        public int DNI
        {
            get => this._dni;
            set
            {
                this._dni = value;
            }
        }

        public DateTime Fnac
        {
            get => this._fnac;
            set
            {
                this._fnac = value;
            }
        }

        public string GetFullName()
        {
            return this.Apellido +" "+ this.Nombre;
        }

        public int GetAge()
        {
            DateTime now = DateTime.UtcNow;
            var age = now.Subtract(Fnac) - new TimeSpan(366, 0, 0, 0);//resta 1 año y 1 dia a la dif entre ahora y fnac
            DateTime edad = new DateTime(1, 1, 1) + age;//agrega un año y el resultado age a 1/1/1
            return edad.Year;
        }
    }
}
