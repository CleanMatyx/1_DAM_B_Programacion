//Programa tabla multiplicar
using System;
class Ejercicio_1_08
{
    static void Main()
    {
        int a, b;
        Console.Write("Introducir número para obtener su tabla de multiplicar --> ");
        a=Convert.ToInt32(Console.ReadLine());
        b = 0;
        Console.WriteLine("{0} * 0 = {1}", a,  a * 0);
        Console.WriteLine("{0} * 1 = {1}", a,  (a * 1));
        Console.WriteLine("{0} * 2 = {1}", a,  (a * 2));
        Console.WriteLine("{0} * 3 = {1}", a,  (a * 3));
        Console.WriteLine("{0} * 4 = {1}", a,  (a * 4));
        Console.WriteLine("{0} * 5 = {1}", a,  (a * 5));
        Console.WriteLine("{0} * 6 = {1}", a,  (a * 6));
        Console.WriteLine("{0} * 7 = {1}", a,  (a * 7));
        Console.WriteLine("{0} * 8 = {1}", a,  (a * 8));
        Console.WriteLine("{0} * 9 = {1}", a,  (a * 9));
        Console.WriteLine("{0} * 10 = {1}", a,  (a * 10));
    }
}