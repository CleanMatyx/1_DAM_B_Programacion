/*
 * Programa que pide al usuario diez textos y los muestra ordenados de menor a 
 * mayor alfabéticamente.
 */
 
 using System;
 class Ejercicio_04d_03
 {
	static void Main()
	{
		string[] textos=new string[10];
		Console.WriteLine("Introduce 10 palabras: ");
		for(int i=0;i<textos.Length;i++)
		{
			textos[i]=Console.ReadLine();
		}
		string maximo=textos[0];
		Array.Sort(textos);
		for(int i=0;i<textos.Length;i++)
		{
			Console.WriteLine(textos[i]);
		}
	}
}
