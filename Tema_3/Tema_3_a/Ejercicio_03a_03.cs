/*
 * Programa que pide al usuario dos valores enteros tipo 'int' de 5/6 cifras
 * para multiplicarse.
 * Ejemplo 'Overflow'
 */
 
 using System;
 class Ejercicio_03a_03
 {
	static void Main()
	{
		long n1,n2,resultado;
		Console.WriteLine("Ingrese los valores para multiplicar:");
		n1=Convert.ToInt64(Console.ReadLine());
		n2=Convert.ToInt64(Console.ReadLine());
		resultado=n1*n2;
		Console.WriteLine("El resultado es: "+ resultado);
	}
}
