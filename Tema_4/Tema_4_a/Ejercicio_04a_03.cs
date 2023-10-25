/*
 * Programa que pide ingresar 6 valores enteros. Los almacena en 'array' y luego
 * los muestra en orden inverso.
 */
 
 using System;
class Ejercicio_04a_03
{
	static void Main()
	{
		int [] numero=new int[6];
		Console.WriteLine("Escribe {0} números.",numero.Length);
		for(int i=0;i<numero.Length;i++)
		{
			numero[i]=Convert.ToInt32(Console.ReadLine());
		}
		for(int i=numero.Length-1;i>=0;i--)
		{
			if (i==numero.Length-1)
			{
				Console.Write(numero[i]);
			}
			else
			{
				Console.Write(", "+numero[i]);
			}
		}
	}
}
