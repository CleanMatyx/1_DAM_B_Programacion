/*
 * Programa que calcula y halla las soluciones en una ecuación de segundo
 * grado Ax2 + Bx + C. El usuario ingresa los valores de A, B y C.
 * (usando Math.Sqrt(numero))
 */
 
 using System;
 class Ejercicio_03b_04
 {
	static void Main()
	{
		int a,b,c,x,raiz;
		double xPositivo,xNegativo;
		Console.WriteLine("Ingrese valor de 'a'");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese valor de 'b'");
		b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese valor de 'c'");
		c=Convert.ToInt32(Console.ReadLine());
		raiz=b*b-4*a*c;
		if (raiz<0)
		{
			Console.WriteLine("No existe solucion Real");
		}
		else if (a==0)
		{
			Console.WriteLine("No es una ecuación de segundo grado");
			x=-c/b;
			Console.WriteLine("'x' es igual a "+x);
		}
		else
		{
			xPositivo=(-b+raiz)/(2*a);
			xNegativo=(-b-raiz)/(2*a);
			Console.WriteLine("La 'x' vale {0} y {1}",xPositivo,xNegativo);
		}
	}
}
