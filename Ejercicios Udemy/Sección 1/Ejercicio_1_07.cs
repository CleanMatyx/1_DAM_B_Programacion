//Programa para convertir metros a millas terrestres
using System;
class Ejercicio_1_07
{
    static void Main()
    {
        int metros;
        Console.Write("Introduzca la cantidad de metros que desea pasar a millas terrestres: ");
        metros = Convert.ToInt32(Console.ReadLine());
        Console.Write(metros + " metros son ");
        Console.Write(metros / 1609.344);
        Console.Write(" millas terrestres");
    }
}