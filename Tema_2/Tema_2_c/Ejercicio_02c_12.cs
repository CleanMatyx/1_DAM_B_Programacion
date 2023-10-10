/*
 * Programa que pide un número y dice si es primo o no.
 */

using System;
class Ejercicio_02_11b
{
	static void Main()
	{
		int n1, numDivisores=0, i=2;
		Console.WriteLine("Ingrese número: ");
		n1=Convert.ToInt32(Console.ReadLine());
		
		while (numDivisores==0&&i<n1/2)
		{
			if (n1%i==0)
			{
				numDivisores++;
			}
			else 
			{
				i++;
			}
		}
		if (numDivisores==0)
		{
			Console.WriteLine("El número es primo");
		}
		else
		{
			Console.WriteLine("El número no es primo");
		}
			
			
	}
}
