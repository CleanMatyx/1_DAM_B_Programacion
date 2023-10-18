/*
 * Programa que mediante booleano indica si un número introducido es primo o no.
 * Variante del Ejercicio_02c_12.
 */
 
 using System;
 class Ejercicio_03c_08
 {
	static void Main()
	{
		int n1, i=2;
		Console.WriteLine("Ingrese número: ");
		n1=Convert.ToInt32(Console.ReadLine());
		bool primo=true;
		while (primo&&i<n1/2)
		{
			if (n1%i==0)
			{
				primo=false;
			}
			else 
			{
				i++;
			}
		}
		if (primo)
		{
			Console.WriteLine("El número es primo");
		}
		else
		{
			Console.WriteLine("El número no es primo");
			
		}
	}
}
