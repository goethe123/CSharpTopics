using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace AbstractClasses2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Figura> Figuras = new List<Figura>();

            Rectangulo rectangulo1 = new Rectangulo(5, 15);
            Rectangulo rectangulo2 = new Rectangulo(3, 12);
            Circulo circulo1 = new Circulo(7);
            Circulo circulo2 = new Circulo(4);

            Figuras.AddRange(new Figura[] { rectangulo1, rectangulo2, circulo1, circulo2 });

            foreach (Figura figure in Figuras)
            {
                Console.WriteLine(figure.GetType().Name);
                figure.Area();
                figure.Perimetro();
                Console.WriteLine("\n");
            }


           

        }
    }

    public abstract class Figura
    {
        public abstract void Area();

        public abstract void Perimetro();
    }

    public class Rectangulo : Figura
    {
        private double baseRectrangulo;
        private double alturaRectangulo;
        public override void Area()
        {
            Console.WriteLine("el area de tu reactangulo es " + (alturaRectangulo * baseRectrangulo));

        }

        public override void Perimetro()
        {
            Console.WriteLine("el perimetro de tu rectangulo es " + baseRectrangulo * 2 + alturaRectangulo * 2);

        }

        public void GetInfo()
        {
            Console.WriteLine($"la base del rectangulo es {baseRectrangulo} y la altura del rectangulo es {alturaRectangulo}");
        }

        public Rectangulo(double baseRectrangulo, double alturaRectangulo)
        {
            this.baseRectrangulo = baseRectrangulo;
            this.alturaRectangulo = alturaRectangulo;
        }
    }

    public class Circulo : Figura
    {
        private double Radio;
        private const double Pi = 3.1416;

        public override void Area()
        {
            Console.WriteLine("el area de tu circulo es : " + Pi * (Radio * Radio));
        }

        public override void Perimetro()
        {
            Console.WriteLine("el perimetro de tu circulo es " + 2 * Pi * Radio);
        }

        public void GetInfo()
        {
            Console.WriteLine("el Radio de tu circulo es " + Radio 
            );
        }

        public Circulo(int Radio)
        {
            this.Radio = Radio;
        }
    }
}

// Una clase abstracta es una clase que no se puede instanciar directamente.
// Sirve como plantilla para otras clases.
// Puede tener métodos abstractos (sin implementación) que obligan a las clases hijas a sobrescribirlos.

// Ejercicio
// Crea una clase abstracta Figura con métodos abstractos Area() y Perimetro().
// Implementa Rectangulo y Circulo que hereden de Figura.
// En el Main, guarda varias figuras en una lista y muestra sus áreas y perímetros.