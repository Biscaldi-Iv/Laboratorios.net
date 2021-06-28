using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Circulo
    {
        private double _radio;

        public Circulo(double rad)
        {
            this.Radio = rad;
        }

        public double Radio
        {
            get { return this._radio; }
            set { this._radio = value; }
        }

        public double CalcularPerimetro()
        {
            return Math.PI * this.Radio;
        }

        public double CalcularSuperficie()
        {
            return Math.PI * Math.Pow(this.Radio, 2) / 2; 
        }
    }
}