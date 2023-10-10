/*
 * Mostrar en pantalla triangulo con asteriscos dada altura por usuario.
 */

using System;
class Ejercicio_02_05c
{
	static void Main()
	{
		int altura;
		Console.WriteLine("Ingrese valor altura triángulo: ");
		altura=Convert.ToInt32(Console.ReadLine());
		for(int i=1;i<=altura;i++)
		{
			for(int j=1;j<=i;j++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
}
