/*
 * Programa que pide al usuario que adivine un número del 1 al 100.
 * En cada repetición devuelve un mensaje por si se ha pasado o se ha 
 * quedado corto. Tienes sólo 6 intentos.
 */
 
 using System;
 class Ejercicio_02_11b
{
	static void Main()
	{
		int n1, secreto=37, contador=6;
		Console.WriteLine("Prueba a adivinar el número");
		
		do
		{
			n1=Convert.ToInt32(Console.ReadLine());
			{
				if (n1>secreto)
				{
					Console.WriteLine("Te has pasado, pureba otra vez");
					Console.WriteLine();
				}
				else if (n1<secreto)
				{
					Console.WriteLine("Te has quedado corto, prueba otra vez");
					Console.WriteLine();
				}
			}
			contador--;
			Console.WriteLine(contador+" Intento/s restante/s");
		}
		while (contador>=0&&n1!=secreto);
		if (n1==secreto)
		{
			Console.WriteLine("Correcto");
		}
		else
		{
			Console.WriteLine("Te has quedado sin intentos");
			Console.WriteLine("El número correcto era "+secreto);
		}
			
	}
}
