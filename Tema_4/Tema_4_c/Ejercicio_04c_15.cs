/*
 * Programa que muestra el texto que escriba el usuario subrayado
 */
 
 using System;
 class Ejercicio_04_15
 {
	static void Main()
	{
		string frase;
		Console.WriteLine("Escribe una frase: ");
		frase=Console.ReadLine();
		Console.WriteLine(new String('-',frase.Length));
	}
}
