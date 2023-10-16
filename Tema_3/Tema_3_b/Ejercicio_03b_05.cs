/*
 * Programa que muestra en pantalla los 10 primeros valores de la función 
 * y=(x-5)2.
 */
 
 using System;
 class Ejercicio_03b_05
 {
	static void Main()
	{
		int y;
		for (int x=0;x<=10;x++)
		{
			y=(x-5)*(x-5);
			for (int j=1;j<=y;j++)
			{
				Console.Write(" ");
			}
			Console.WriteLine("*");
		}
	}
}
