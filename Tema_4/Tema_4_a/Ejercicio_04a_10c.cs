/*
 * Programa continuación del Ejercicio_04a_10b.
 * Pedirá una posición y elimine el videojuego de esa posición.
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
		lista[4]="Terraria";
		lista[5]="Elden Ring";
		lista[6]="Super Mario";
		lista[7]="Super Mario 2";
		int cantidad=8,posicion;
		Console.WriteLine("Listado de videojuegos");
		for(int i=0;i<cantidad;i++)
		{
			Console.WriteLine(i+1+" "+lista[i]);
		}
		Console.Write("Introduzca el número del videjouego a borrar: ");
		posicion=Convert.ToInt32(Console.ReadLine());
		posicion--;
		if(cantidad>0&&posicion>=0&&posicion<cantidad)
		{
			for(int i=posicion;i<cantidad-1;i++)
				lista[i]=lista[i+1];
			cantidad--;
		}
		Console.WriteLine("Estado actualizado de videojuegos");
		for(int i=0;i<cantidad;i++)
		{
			Console.WriteLine(lista[i]);
		}
	}
}
