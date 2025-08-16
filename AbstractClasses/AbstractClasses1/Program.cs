// Abstract classes (clases abstractas)
// Qué practicar: herencia + polimorfismo + métodos abstractos.

// Ejercicio
// Crea una clase abstracta Figura con Area() y Perimetro(). Implementa Rectangulo y Circulo. Recorre una lista de Figura e imprime área y perímetro.
// Solución (referencia)

using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Figura> Figuras = new List<Figura> { new Rectangulo(10, 2), new Circrulo(5) };

            foreach (Figura obj in Figuras)
            {
                
                Console.WriteLine(obj.GetType().Name + " Area : " + obj.Area() + ", Perimetro : " + obj.Perimetro() );
            }
            
            
        }

        public abstract class Figura
        {
            public abstract double Area();
            public abstract double Perimetro();
        }

        public class Rectangulo : Figura
        {
            private double Altura;
            private double Base;

            public double GetAltura => Altura;
            public double GetbASE => Base;
            public override double Area()
            {
                return Base * Altura;
            }

            public override double Perimetro()
            {
                return Base * 2 + Altura * 2;
            }

            public Rectangulo(double Altura, double Base)
            {
                this.Altura = Altura;
                this.Base = Base;
            }
        }

        public class Circrulo : Figura
        {
            private double Pi = 3.1416;
            private double radio;

            public double GetPi => Pi;
            public double GetRadio => radio;

            public override double Area()
            {
                return Pi * Math.Pow(radio, 2);

            }

            public override double Perimetro()
            {
                return 2 * Pi * radio;
            }

            public Circrulo (double radio)
           {
                this.radio = radio;
           }
        }
    }
}