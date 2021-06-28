using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Poligono 
        //poligono regular
    {
        private int cantLados;
        private double longLados;

        public Poligono(int cantL, double longL)
        {
            this.CantLados = cantL;
            this.Long_Lados = longL;
        }

        public int CantLados
        {
            get { return this.cantLados; }
            set { this.cantLados = value; }
        }

        public double Long_Lados
        {
            get { return this.longLados; }
            set { this.longLados = value; }
        }

        public  double CalcularPerimetro() 
        {
            return this.CantLados * this.Long_Lados;
        }

        public  double CalcularSuperficie() 
        {
            double toRadians(double n) { return n * Math.PI / 180; }
            //double toDeg(double n) { return 180*n/Math.PI; } No necesario

            #region apotema
            double k = Math.Sin(toRadians(180 / this.CantLados ) ) ;
            double rad = this.Long_Lados / (2 * k);
            double apot = Math.Sqrt(Math.Pow(rad, 2) - Math.Pow( (this.Long_Lados / 2), 2));
            #endregion
            double t = new Triangulo(this.longLados,apot).CalcularSuperficie();
            return t * this.CantLados;
        }
    }
}