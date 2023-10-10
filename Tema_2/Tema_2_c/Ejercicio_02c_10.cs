/*
 * Programa que muestra una cuenta atrás desde el numero ingresado siendo este 
 * positivo, hasta cero.
 */

using System;
class Ejercicio_02_10
{
	static void Main()
	{
		int n1;
		Console.WriteLine("Ingrese un valor positivo para cuenta atrás");
		n1=Convert.ToInt32(Console.ReadLine());
		
		for (int i=n1;i>=0;i--)
		{
			Console.WriteLine(i);
		}
	}
}
