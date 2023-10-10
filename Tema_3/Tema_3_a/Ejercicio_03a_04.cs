/*
 * Programa que pide al usuario una variable entero y devuelve su equivalente
 * en binario y en hexadecimal.
 */
 
 using System;
 class Ejercicio_03a_04
 {
	static void Main()
	{
		int n1;
		do
		{
			Console.WriteLine("Ingrese el valor a convertir:");
			n1=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine();
			Console.WriteLine("Binario = "+Convert.ToString(n1,2));
			Console.WriteLine("Hexadecimal = "+Convert.ToString(n1,16));
		}
		while (n1!=0);
	}
}
