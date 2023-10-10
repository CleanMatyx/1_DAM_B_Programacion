/*
 * Programa que pide un número entero para calcular la suma de sus dígitos.
 */
 
 using System;
 class Algoritmia_1_4
 {
	static void Main()
	{
		int n1,contador=0, ultimo;
		Console.WriteLine("Introduzca número entero para sumar sus dígitos");
		n1=Convert.ToInt32(Console.ReadLine());
		
		while (n1!=0)
		{
			ultimo=n1%10;
			n1=n1/10;
			contador=contador+ultimo;
		}
		Console.WriteLine("Su suma es {0}", contador);
	}
}
