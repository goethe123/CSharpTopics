// Teoría
// Un struct es un tipo de valor (a diferencia de las clases que son tipos de referencia).
// Son más ligeros y se usan para representar entidades pequeñas que no necesitan herencia.
// Ejemplos: Point, DateTime.


// Ejercicio
// Crea un struct Punto con X y Y.
// Haz un método que calcule la distancia entre dos puntos usando el teorema de Pitágoras.

using System;
using System.Collections.Generic;

namespace structs2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Punto puntoA = new Punto(4, 6);
            Punto puntoB = new Punto(10, 2);

           Console.Write( Punto.Between(puntoA, puntoB));

        }

        public struct Punto
        {
            double X;
            double Y;

            public static double Between(Punto A, Punto B)
            {
                double DX = A.X - B.X;
                double DY = A.Y - B.Y;
                return Math.Sqrt((DX * DX) + (DY * DY));
            }

            public Punto(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }
        }
    }
}