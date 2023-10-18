/*
 * Programa que pide al usuario una frase y se devuelve mensaje indicando
 * si tiene alguna 'a' minuscula o no.
 */
 
 using System;
 class Ejercicio_03c_07
 {
	static void Main()
	{
		string frase;
		bool valor=false;
		Console.WriteLine("Escribe una frase:");
		frase=Console.ReadLine();
		foreach (char letra in frase)
		{
			if (letra=='a')
			{
				valor=true;
			}
		}
		if (!valor)
		{
			Console.WriteLine("No hay 'a' minúscula");
		}
		else
		{
			Console.WriteLine("Hay 'a' minúscula");
		}
	}
}
