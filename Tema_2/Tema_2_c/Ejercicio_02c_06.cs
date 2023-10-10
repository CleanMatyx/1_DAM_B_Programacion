/*
 * Mostrar en pantalla triangulo volteado a la derecha con asteriscos 
 * dada altura por usuario.
 */

using System;
class Ejercicio_02_06c
{
	static void Main()
	{
		int h;
		Console.WriteLine("Ingrese el valor de altura para triángulo: ");
		h=Convert.ToInt32(Console.ReadLine());
		for (int i=1;i<=h;i++)
		{
			for (int j=1;j<=h-i;j++)
			{
				Console.Write("   ");
			}
			for (int k=1;k<=i;k++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
}
