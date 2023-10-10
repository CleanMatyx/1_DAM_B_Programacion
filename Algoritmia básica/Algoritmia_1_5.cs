/*
 * Programa que pide al usuario un número para que se le devuelva el número
 * original pero dado la vuelta.
 */
 
 using System;
 class Algoritmia_1_5
 {
	static void Main()
	{
		int n1, ultimo, contador=0;
		Console.WriteLine("Ingrese el número");
		n1=Convert.ToInt32(Console.ReadLine());
		
		while (n1!=0)
		{
			ultimo=n1%10;
			n1=n1/10;
			contador=contador*10+ultimo;
		}
		Console.WriteLine("El número es {0}", contador);
	}
}
