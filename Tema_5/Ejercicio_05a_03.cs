/*
 * Programa con función 'RepetirTexto' que recibe un parámetro tipo 'string'
 * y otro de tipo 'int' para luego mostrar en pantalla el texto repetido
 * tantas veces indique el entero.
 */
 
 using System;
 class Ejercicio_05a_03
{
	static void RepetirTexto(string texto, int cantidad)
	{
		for(int i=1;i<=cantidad;i++)
		{
			Console.WriteLine(texto);
		}
	}
	static void Main()
	{
		string texto;
		int cantidad;
		Console.Write("Introduce un texto: ");
		texto=Console.ReadLine();
		Console.Write("Introduce la cantidad de veces a repetir texto: ");
		cantidad=Convert.ToInt32(Console.ReadLine());
		RepetirTexto(texto,cantidad);
	}
}
		
