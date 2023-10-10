/*
 * Dibujar cuadrado de asteriscos de lado dado por usuario con bucles anidados.
 */
 
using System;
class Ejercicio_02_04c
{
	static void Main()
	{
		int h;
		Console.WriteLine("Ingrese el valor de altura para triangulo: ");
		h=Convert.ToInt32(Console.ReadLine());
		for(int i=1;i<=h;i++)
		{
			for(int j=1;j<=h;j++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
}

