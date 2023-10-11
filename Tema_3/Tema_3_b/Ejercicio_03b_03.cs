/*
 * Programa que pide una variable distancia en Km 'int' y el tiempo necesario
 * para recorrerla (HH,MM,SS) para calcular los metros por segundo.
 */
 
 using System;
 class Ejercicio_03b_03
 {
	static void Main()
	{
		int km,h,min,seg,tiempo;
		float vel;
		Console.WriteLine("Introduzca la distancia en Km a recorrer: ");
		km=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Tiempo empleado");
		Console.Write("Horas: ");
		h=Convert.ToInt32(Console.ReadLine());
		Console.Write("Minutos: ");
		min=Convert.ToInt32(Console.ReadLine());
		Console.Write("Segundos: ");
		seg=Convert.ToInt32(Console.ReadLine());
		tiempo=h*3600+min*60+seg;
		vel=km*1000f/tiempo;
		Console.WriteLine("La velocidad es {0}m/s.",vel);
	}
}

