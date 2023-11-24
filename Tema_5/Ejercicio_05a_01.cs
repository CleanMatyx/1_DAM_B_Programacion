/*
 * Programa que dibuja un cuadrado tamaño 3 relleno de asteriscos definiendo 
 * una función 'DibujarCuadrado'.
 */
 
 using System;
 class Ejercicio_05a_01
{
	static void DibujarCuadrado()
	{
		for(int i=1;i<=3;i++)
		{
			for(int j=1;j<=3;j++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
	static void Main()
	{
		DibujarCuadrado();
	}
}
