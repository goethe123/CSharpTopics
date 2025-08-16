using System;

namespace Enum1
{
    public class Program
    {
        enum DiasDeLaSemana { lunes = 1, martes, miercoles, jueves, viernes, sabado, domingo };

        public static void Main(string[] args)
        {
            Console.WriteLine("Dame un número del 1 al 7:");
            int dia = Convert.ToInt32(Console.ReadLine());

            if (dia >= 1 && dia <= 7)
            {
                DiasDeLaSemana diaEnum = (DiasDeLaSemana)dia;
                Console.WriteLine($"El día es: {diaEnum}");
            }
            else
            {
                Console.WriteLine("Número inválido, debe estar entre 1 y 7.");
            }
        }
    }
}
