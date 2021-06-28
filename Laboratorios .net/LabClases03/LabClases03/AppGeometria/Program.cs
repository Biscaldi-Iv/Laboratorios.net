using System;
using Geometria;

namespace AppGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo t = new Triangulo(10, 10);
            Circulo cir = new Circulo(10);
            Rectangulo r = new Rectangulo(10, 20);
            Cuadrado cuad = new Cuadrado(10);
            Poligono pcuad = new Poligono(4, 10);
            Poligono pent = new Poligono(5, 10);

            Console.WriteLine(
                $"Circulo(r=10): Perimetro:{cir.CalcularPerimetro()} Area:{cir.CalcularSuperficie()}\n" +
                $"Triangulo(b=a=10): Preimetro:{t.CalcularPerimetro()} Area:{t.CalcularSuperficie()}\n" +
                $"Rectangulo(10x20): Perimetro:{r.CalcularPerimetro()} Area:{r.CalcularSuperficie()}\n" +
                $"Cuadrado(l=10): Perimetro:{cuad.CalcularPerimetro()} Area:{cuad.CalcularSuperficie()}\n"+
                $"Cuadrado<Poligono>(l=10): Perimetro:{pcuad.CalcularPerimetro()} Area:{pcuad.CalcularSuperficie()}\n" +
                $"Pentagono(l=10): Perimetro:{pent.CalcularPerimetro()} Area:{pent.CalcularSuperficie()}\n");
            Console.ReadKey();

        }
    }
}
