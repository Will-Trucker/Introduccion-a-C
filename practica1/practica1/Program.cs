// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace practica1
{
    class Program
    {
        static void Main(String[] args)
        {
            //declaro la variable
            Double b1, h2, formula;
            Console.WriteLine("Digite la base: ");
            b1 = double.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Digite la altura");
            h2= double.Parse(Console.ReadLine());

            Console.Clear();

            formula = b1 * h2 / 2;

            Console.WriteLine("El resultado es: ...... " + formula);

            Console.ReadKey();

        }
    }
}