/*
 * Programa que tiene una función 'Inicial' que recibe un texto y devolverá
 * la primera letra del texto.
 */
 
 using System;
 class Ejercicio_05a_05
 {
	static char Inicial(string texto)
	{
		return texto[0];
	}
    static void Main()
    {
        string texto;
        Console.WriteLine("Escribe un texto:");
        texto = Console.ReadLine();
        Console.WriteLine("La inicial es : "+Inicial(texto));
    }
}
