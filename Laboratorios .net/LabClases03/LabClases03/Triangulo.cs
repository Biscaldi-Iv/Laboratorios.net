using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Triangulo
    {
        private double _base;
        private double _altura;

        public Triangulo(double base_,double altura)
        {
            this.Altura = altura;
            this.Base = base_;
        }

        public double Altura
        {
            get { return this._altura; }
            set { this._altura = value; }
        }

        public double Base
        {
            get { return this._base; }
            set { this._base = value; }
        }

        public double CalcularSuperficie()
        {
            return this.Base * this.Altura / 2;
        }

        public double CalcularPerimetro()
        {
            return this.Base+this.Altura+(this.Base / (Math.Cos(Math.Atan(this.Altura / this.Base))));
        }
    }
}