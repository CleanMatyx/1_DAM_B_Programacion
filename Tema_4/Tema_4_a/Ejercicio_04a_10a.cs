/*
 * Programa que tiene reservados 100 filas 'string' para títulos de 
 * videojuegos. Ya habrá algunos títulos añadidos y pedirá añadir el título
 * final. Al finalizar mostrará la lista entera.
 */
 
 using System;
 class Ejercicio_04a_10a
{
	static void Main()
	{
		string[]lista=new string[100];
		lista[0]="Animal Crossing";
		lista[1]="Tekken";
		lista[2]="Mortal Kombat";
		lista[3]="Forza";
		int cantidad=4;
		Console.Write("Introduce un título de videojuego: ");
		if (cantidad<6)
		{
			lista[cantidad]=Console.ReadLine();
			cantidad++;
		}
		for(int i=0;i<cantidad;i++)
		{
			Console.WriteLine(lista[i]);
		}
	}
}
