/*
 * Mostrar en pantalla una secuencia usando bucles anidados.
 */

using System;
class Ejercicio_02_02c
{
	static void Main()
	{
		for(int i=1;i<=5;i++)
		{
			for(int j=1;j<=i;j++)
			{
				Console.Write(j);
			}
			Console.WriteLine();
		}
	}
}
