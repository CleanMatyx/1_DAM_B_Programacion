/*
 * Dibujar cuadrado de asteriscos de lado 5 con bucles anidados.
 */
 
using System;
class Ejercicio_02_03c
{
	static void Main()
	{
		for(int i=1;i<=5;i++)
		{
			for(int j=1;j<=5;j++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
}
