/*
 * Programa que pide al usuario un número y calcule la cantidad de cifras que
 * tiene.
 */
 
 using System;
 class Algoritmia_1_3
 {
	static void Main()
	{
		int n1, contador=0;
		Console.WriteLine("Ingrese un número positivo para calcular cifras:");
		n1=Convert.ToInt32(Console.ReadLine());
		
		while (n1>0)
		{
			n1=n1/10;
			contador++;
		}
		Console.WriteLine("Tiene {0} cifra/s", contador);
	}
}
