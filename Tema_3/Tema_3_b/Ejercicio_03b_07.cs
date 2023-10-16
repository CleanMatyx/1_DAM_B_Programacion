/*
 * Programa que calcula el perímetro, área y diagonal de un rectángulo con
 * base y altura introducidas por el usuario. Los datos se mostrarán con una
 * cifra decimal.
 */
 
 using System;
 class Ejercicio_03b_07
 {
	static void Main()
	{
		float b,a,per,area,diagonal;
		Console.Write("Introduzca la base del rectángulo: ");
		b=Convert.ToSingle(Console.ReadLine());
		Console.Write("Introduzca la altura del rectángulo: ");
		a=Convert.ToSingle(Console.ReadLine());
		per=2*a+2*b;
		Console.WriteLine("Perimetro = "+per.ToString("N1"));
		area=a*b;
		Console.WriteLine("Área = "+area.ToString("N1"));
		diagonal=(float)Math.Sqrt(a*a+b*b);
		Console.WriteLine("Diagonal = "+diagonal.ToString("N1"));
	}
}
