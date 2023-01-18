using System;

namespace Practica2
{
    class Program
    {
        static void Main(string[] args){
            double radio, volumen, pi;
            pi = 3.1416;

            Console.WriteLine("Ingrese el Radio");
            radio = double.Parse(Console.ReadLine());

            volumen = ((4 * pi) * (radio * radio * radio) / 3);

            Console.WriteLine("El resultado es .... " + volumen);

            Console.ReadKey();
        }
    }
}
