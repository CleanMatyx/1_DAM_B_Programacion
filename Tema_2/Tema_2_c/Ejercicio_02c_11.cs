/*
 * Programa que pide al usuario que adivine un número del 1 al 100.
 * En cada repetición devuelve un mensaje por si se ha pasado o se ha 
 * quedado corto.
 */
 
 using System;
 class Ejercicio_02_11
{
	static void Main()
	{
		int n1, secreto=37;
		do
		{
			Console.WriteLine("Prueba a adivinar el número");
			n1=Convert.ToInt32(Console.ReadLine());
			if (n1>secreto)
			{
				Console.WriteLine("Te has pasado");
				Console.WriteLine();
			}
			else if (n1<secreto)
			{
				Console.WriteLine("Te has quedado corto");
				Console.WriteLine();
			}
		}
		while (n1!=secreto);
		Console.WriteLine("Correcto");
	}
}
