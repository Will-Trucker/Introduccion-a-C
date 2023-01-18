// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Salida_Entrada_Pantalla
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de variables
            String Texto;
            //Acabamos de declarar una variable de tipo cadena para capturar
            //lo que digitamos en el teclado
            Console.WriteLine("Digitar un texto");
            //Ahora guardamos lo digitado
            //Lo almacenamos en la variable texto
            //Para esto utilizamos la siguiente instruccion
            Texto = Console.ReadLine();
            //Mostraremos el texto digitado, haciendo uso del operador de concatenación (+)
            //escribiendo el nombre de la variable que contiene el texto asi:
            Console.WriteLine("\n El texto digitado es: ..." + Texto);
            //Los simbolos \n significan un salto de linea
            //La siguiente  instruccion me proporciona una pausa para ver el resultado
            //permitiendo cerrar la ventana al presionar una tecla
            Console.ReadKey();

        }
    }
}
