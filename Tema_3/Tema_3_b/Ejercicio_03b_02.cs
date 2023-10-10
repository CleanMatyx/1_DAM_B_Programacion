/*
 * Programa que calcula el área de un circulo dado su radio 'int'.
 */
 
 using System;
 class Ejercicio_03b_02
{
	static void Main()
	{
		int r;
		double pi=3.1415926535, area;
		Console.WriteLine("Ingrese valor de radio para calcular el área:");
		r=Convert.ToInt32(Console.ReadLine());
		area=pi*r*r;
		Console.WriteLine("El área es : "+area);
	}
}
		
