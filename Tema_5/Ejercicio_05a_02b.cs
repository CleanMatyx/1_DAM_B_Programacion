/*
 * Programa que tiene una función con dos parámetros enteros para indicar base 
 * y altura de un rectángulo. La función debe dibujar en pantalla un rectángulo
 * relleno de asteriscos.
 */
 
 using System;
 class Ejercicio_05a_02b
{
	static void DibujarRectangulo(int b, int h)
	{
		for(int i=1;i<=h;i++)
		{
			for(int j=1;j<=b;j++)
			{
				Console.Write(" * ");
			}
			Console.WriteLine();
		}
	}
	static void Main()
	{
		int b, h;
		Console.WriteLine("Ingrese altura de rectángulo: ");
		h=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese base de rectángulo: ");
		b=Convert.ToInt32(Console.ReadLine());
		DibujarRectangulo(b,h);
	}
}
