/*
 * Programa con función 'DatosCirculo' con parámetros del radio de un círculo
 * y utiliza dos parámetros 'out' para devolver el área y perímetro.
 */

using System;
class Ejercicio_05a_10
{
	static void DatosCirculo(float radio, out float area, out float perimetro)
	{
		area=(float)Math.PI*radio*radio;
		perimetro=2*(float)Math.PI*radio;
	}
	static void Main()
	{
		float area,perimetro;
		Console.Write("Ingrese el rádio del círculo: ");
		float radio=Convert.ToSingle(Console.ReadLine());
		DatosCirculo(radio, out area, out perimetro);
		Console.WriteLine("El área es {0} y el perímetro es {1}",
			area,perimetro);
	}
}
		
