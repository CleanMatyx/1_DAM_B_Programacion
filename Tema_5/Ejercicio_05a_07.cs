/*
 * Programa con una función 'EsPrimo' que recibe un entero y guarda en un 
 * 'bool' si es primo o no.
 */
 
 using System;
 class Ejercicio_05a_07
{
	static bool EsPrimo(int numero)
	{
		int i=2;
		
		bool primo=true;
		while (primo&&i<numero/2)
		{
			if (numero%i==0)
			{
				primo=false;
			}
			else 
			{
				i++;
			}
		}
		return primo;
	}
	static void Main()
	{
		Console.WriteLine("Ingrese número: ");
		int n1=Convert.ToInt32(Console.ReadLine());
		bool primo=EsPrimo(n1);
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
