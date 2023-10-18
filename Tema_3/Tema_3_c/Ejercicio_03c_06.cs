/*
 * Programa que pide dos variables enteras y las almacene en un booleano si 
 * ambas son pares o no. Luego usa esa variable para mostrar un mensaje u 
 * otro.
 */
 
 using System;
 class Ejercicio_03c_06
{
	static void Main()
	{
		int n1,n2;
		Console.WriteLine("Escribe dos números enteros");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		bool pares=n1%2==0&&n2%2==0;
		if (pares)
		{
			Console.WriteLine("Ambos números son pares");
		}
		else
		{
			Console.WriteLine("No son los dos pares");
		}
	}
}
