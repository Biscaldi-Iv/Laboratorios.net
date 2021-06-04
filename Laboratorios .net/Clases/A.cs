using System;

namespace Clases
{
    public class A
    {
        private String _nombreInstancia;

        public String NombreInstancia
        {
            get{ return this._nombreInstancia; }
            set { this._nombreInstancia = value; }
        }
        #region Constructores
        public A()
        {
            this.NombreInstancia = "Instancia sin nombre";
        }

        public A(String nombre)
        {
            this.NombreInstancia = nombre;
        }
        #endregion
        #region Metodos
        public void MostrarNombre()
        {
            Console.WriteLine(this.NombreInstancia);
        }

        public void M1()
        {
            Console.WriteLine("\nInvocaste el metodo M1\n");
        }

        public void M2()
        {
            Console.WriteLine("\nInvocaste el metodo M2\n");
        }

        public void M3()
        {
            Console.WriteLine("\nInvocaste el metodo M3\n");
        }
        #endregion
    }
}
