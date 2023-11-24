/*
 * Programa con función 'MaxMinArray' que tiene un parámetro de array de enteros
 * Devuelve en dos 'out' su valor máximo y mínimo.
 */
 
 using System;
 class Ejercicio_05a_11
{
	static void MaxMinArray(int[]lista,out int max,out int min)
	{
		Array.Sort(lista);
		min=lista[0];
		max=lista[4];
	}
	static void Main()
	{
		int[]lista=new int[5];
		int max,min;
		for(int i=0;i<lista.Length;i++)
		{
			lista[i]=Convert.ToInt32(Console.ReadLine());
		}
		MaxMinArray(lista,out max,out min);
		Console.WriteLine("El máximo es {0} y el mínimo es {1}",max,min);
	}
}
		
