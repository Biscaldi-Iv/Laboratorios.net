using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Rectangulo : Poligono
    {
        private double _base;
        private double _altura;


        public Rectangulo(double base_, double altura) : base(0,0)
        {
            this.Base = base_;
            this.Altura = altura;
        }

        public double Base
        {
            get { return this._base; }
            set { this._base = value; }
        }

        public double Altura
        {
            get { return this._altura; }
            set { this._altura = value; }
        }

        public new double CalcularPerimetro()
        {
            return (this.Base * 2) + (this.Altura * 2);
        }

        public new double CalcularSuperficie()
        {
            return this.Base * this.Altura;
        }
    }
}