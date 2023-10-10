/*
 * Programa que pide ingresar texto para contar la cantidad de "a" presentes
 * en él.
 */
 
 using System;
 class Ejercicio_02_09
{
	static void Main()
	{
		Console.Write("Escribe el texto a analizar: ");
		string texto=Console.ReadLine();
		int contador=0;
		foreach(char letra in texto)
		{
			if(letra=='a')
			{
				contador++;
			}
		}
		Console.WriteLine("Hay {0} 'a' minúsculas.",contador);
	}
}
