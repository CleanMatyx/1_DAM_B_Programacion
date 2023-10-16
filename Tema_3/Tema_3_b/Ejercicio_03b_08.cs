/*
 * Programa que calcula la distancia entre dos puntos 'x1, y1', 'x2, y2' 
 * introducidos por el usuario.
 * La distancia es d=raiz((x1-x2)^2+(y1-y2)^2) mostrando dos decimales.
 */
 
 using System;
 class Ejercicio_03b_08
{
	static void Main()
	{
		int x1,x2,y1,y2;
		double d;
		Console.WriteLine("Ingrese la posición del primer punto (x1, y1):");
		x1=Convert.ToInt32(Console.ReadLine());
		y1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese la posición del segundo punto (x2, y2):");
		x2=Convert.ToInt32(Console.ReadLine());
		y2=Convert.ToInt32(Console.ReadLine());
		d=Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2));
		Console.WriteLine("La distancia es "+d.ToString("N2"));
	}
}
