/*
 * Programa que pide dos notas numéricas enteras de 0 a 10 para mostrar la 
 * nota media. Si los datos introducidos no son correctos, el programa volverá 
 * a pedir que introduzca un valor válido.
 */
 
 using System;
 class Practica_2_1_3
 {
	static void Main()
	{
		int nota1,nota2;
		
		do
		{
			Console.WriteLine("Introduzca la primera nota de 0 a 10");
			nota1=Convert.ToInt32(Console.ReadLine());
		}
		while (nota1<0||nota1>10);
		Console.WriteLine("Primera nota correcta.");
		Console.WriteLine();
		do
		{
			Console.WriteLine("Introduzca la segunda nota de 0 a 10");
			nota2=Convert.ToInt32(Console.ReadLine());
		}
		while (nota2<0||nota2>10);
		Console.WriteLine("Segunda nota correcta.");
		Console.WriteLine();
		Console.WriteLine("Su nota media es: "+((nota1+nota2)/2));
	}
}
			

		
		
