/*
 * Programa que pide al usuario 10 nombres y luego pedirá nombres para buscar.
 * El programa dirá si el nombre está y en qué posición.
 */
 
 using System;
 class Ejercicio_04a_08
 {
	static void Main()
	{
		string []lista=new string [10];
		string nombre;
		int j=0;
		bool encontrado=false;
		Console.WriteLine("Ingrese 10 nombres.");
		for(int i=0;i<lista.Length;i++)
		{
			lista[i]=Console.ReadLine();
		}
		Console.WriteLine("Ingrese un nombre para buscar.");
		nombre=Console.ReadLine();
		while(!encontrado&&j<lista.Length)
		{
			if(nombre==lista[j])
				encontrado=true;
			else
				j++;
		}
		Console.WriteLine("Está en la lista. Posición {0}",j+1);
	}
}
