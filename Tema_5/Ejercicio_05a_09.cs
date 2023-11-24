/*
 * Programa co función 'Intercambiar' con referencia de dos parámetros enteros
 * para que intercambien sus valores.
 */
 
 using System;
 class Ejercicio_05a_09
{
	static void Intercambiar(ref int a, ref int b)
	{
		int aux=0;
		aux=a;
		a=b;
		b=aux;
	}
	static void Main()
	{
		int n1=0,n2=0;
		Console.WriteLine("Introduce dos números para intercambiarlos.");
		Console.Write("N1 = ");
		n1=Convert.ToInt32(Console.ReadLine());
		Console.Write("N2 = ");
		n2=Convert.ToInt32(Console.ReadLine());
		Intercambiar(ref n1,ref n2);
		Console.WriteLine("N1 ahora es {0} y N2 ahora es {1}.",n1,n2);
	}
}
