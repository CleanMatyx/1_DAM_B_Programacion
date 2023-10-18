/*
 * Programa que pide al usuario que escriba su nombre. Si se llama 'Juan'
 * devuelva mensaje "Hola" o "No te conozco" si el nombre es otro.
 */
 
 using System;
 class Ejercicio_03c_03
 {
	static void Main()
	{
		string nombre;
		Console.WriteLine("Introduce tu nombre");
		nombre=Console.ReadLine();
		if (nombre!="Juan")
		{
			Console.WriteLine("\"No te conozco\"");
		}
		else
		{
			Console.WriteLine("\"Hola\"");
		}
	}
}
