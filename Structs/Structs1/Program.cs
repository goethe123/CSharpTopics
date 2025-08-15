using System;
using System.Collections.Generic;

namespace structs1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Persona Goethe = new Persona();
            Persona Allen = new Persona();
            Persona Bruce = new Persona();

            Goethe.Correr("goethe");
            Bruce.Correr("bruce"); 
        }

        struct Persona
        {
            public  int id;
            public  string name;
            public  int age;

            public  void Correr(string name)
            {
                System.Console.WriteLine("estoy corriendo! \n - " + name);
            }
        }
        
    }

}


// 2) Structs

// Qué practicar: tipos por valor, inmutabilidad ligera, métodos en struct.
// Ejercicio
// Crea un struct Punto2D inmutable con X, Y, método DistanciaA(Punto2D otro) y Mover(dx,dy) que devuelva un nuevo punto.
// Solución (referencia)
