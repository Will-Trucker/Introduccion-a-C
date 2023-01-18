// See https://aka.ms/new-console-template for more information
using System;
//Programa Realizado por
//Dia: 18 de enero 2022
Console.WindowHeight = 25; // alto de la ventana
Console.WindowWidth = 70; // ancho de la ventana
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.Title = "Programa con operadores matematicos - numeros enteros";
Console.Write("\nGuia#1 Ejemplo1");
//Declaración de variables
int n1, n2, s, r, m, d, modulito;
//Entrada de datos
Console.Write("\n\n");
Console.Write("\tDigitar el primer numero  : ");
n1 = int.Parse(Console.ReadLine());
Console.Write("\tDigitar el segundo numero : ");
n2 = int.Parse(Console.ReadLine());
Console.Write("\n");
//Proceso de los datos
s = n1 + n2; //Calculamos la suma
r = n1 - n2; //Calculamos la resta
m = n1 * n2; //Calculamos la multiplicacion
d = n1 / n2; //Calculamos la Division
modulito = n1 % n2; //Calculamos el modulo de la division
//Salida de los datos
Console.WriteLine("\t********************************************");
Console.WriteLine("\t La suma de los numeros es........... :  " + s);
Console.WriteLine("\t La resta de los numeros es........... : "       + r);
Console.WriteLine("\t La multiplicación de los numeros es........... : " + m);
Console.WriteLine("\t La division de los numeros es........... :      " + d);
Console.WriteLine("\t El modulo de los numeros es........... : " + modulito);
Console.WriteLine("\t********************************************");
Console.WriteLine("\n\n");
//Pantalla opcional
Console.Write("\t");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("*********************************************");
Console.ForegroundColor = ConsoleColor.Black;
Console.BackgroundColor = ConsoleColor.White;
Console.WriteLine("\t* *");
Console.WriteLine("\t* Este programa fue diseñado por: *");
Console.WriteLine("\t*                                 *");
Console.WriteLine("\t*         Will Mazariego          *");
Console.WriteLine("\t*                                 *");
Console.Write("\t");
Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Red;
Console.WriteLine("*********************************************");
Console.ForegroundColor = ConsoleColor.Black;
Console.ForegroundColor = ConsoleColor.White;
Console.Write("\t");
Console.WriteLine("--> Fin del Programa");
Console.Write("\t");
Console.ReadKey();