/*
 * Programa que pide 10 numeros reales 'double' y luego diga cúal es el 
 * menor de ellos e indique su posición.
 */

using System;
class Ejercicio_04a_09
{
	static void Main()
	{
		double [] lista=new double[10];
		Console.WriteLine("Ingrese {0} números.",lista.Length);
		double menor=0;
		int posicion=0;
		for(int i=0;i<lista.Length;i++)
		{
			lista[i]=Convert.ToDouble(Console.ReadLine());
			if(i==0)
				menor=lista[i];
			if(lista[i]<menor)
			{
				menor=lista[i];
				posicion=i;
			}
			
		}
		Console.WriteLine("El menor es {0}. Posición {1}",lista[posicion],
		posicion+1);
	}
}
		
