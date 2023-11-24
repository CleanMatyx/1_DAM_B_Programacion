/*
 * Programa con función 'ContarLetra' que recibe un carácter tipo 'char' y un 
 * texto como parámetros devolviendo la cantidad de caracteres presentes en
 * él.
 */

using System;
class Ejercicio_05a_08
{
	static int ContarLetra(char caracter, string texto)
	{
		int contador=0;
		for(int i=0;i<texto.Length;i++)
		{
			if(texto[i]==caracter)
				contador++;
		}
		return contador;
	}
	static void Main()
	{
		Console.Write("Ingrese caracter a contar: ");
		char caracter=Convert.ToChar(Console.ReadLine());
		Console.WriteLine("Ingrese texto: ");
		string texto=Console.ReadLine();
		int cantidad=ContarLetra(caracter,texto);
		Console.WriteLine("En el texto hay {0} letras {1}.",cantidad,caracter);
	}
}
