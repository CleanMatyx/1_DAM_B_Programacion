/*
 * Programa continuación del Ejercicio_04a_10a.
 * Pedirá añadir un título en la posición 03.
 * 
 */
 
 using System;
 class Ejercicio_04a_10b
{
	static void Main()
	{
		string[]lista=new string[100];
		lista[0]="Animal Crossing";
		lista[1]="Tekken";
		lista[2]="Mortal Kombat";
		lista[3]="Forza";
		int cantidad=4,posicion=3;
		Console.Write("Introduce un título de videojuego: ");
		if(cantidad<lista.Length)
		{
			for(int i=cantidad;i>posicion;i--)
				lista[i]=lista[i-1];
			lista[posicion]=Console.ReadLine();
			cantidad++;
		}
		Console.WriteLine("Estado actualizado de videojuegos");
		for(int i=0;i<cantidad;i++)
		{
			Console.WriteLine(lista[i]);
		}
	}
}
