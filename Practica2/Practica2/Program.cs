using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2
{
    //Calcular el volumen de una esfera
    class Program
    {
        static void Main(string[] args){
            double radio, volumen;

            Console.WriteLine("Ingrese el Radio");
            radio = double.Parse(Console.ReadLine());

            /*volumen = ((4 * pi) * (radio * radio * radio) / 3);*/
            volumen = ((4 * Math.PI) * (Math.Pow(radio,3) / 3));

            Console.WriteLine("El resultado es .... " + volumen);

            Console.ReadKey();
        }
    }
}
