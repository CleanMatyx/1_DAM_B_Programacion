/*
 * Programa que tiene una función 'Signo' que recibe un número entero y 
 * devolverá '-1' si el número es negativo, '1' si es positivo o '0' si es 
 * Cero.
 */
 
 using System;
 class Ejercicio_05a_04
{
	static int Signo(int valor)
	{
		if(valor<0)
			return -1;
		else if (valor==0)
			return 0;
		else
			return 1;
	}
	static void Main()
	{
		int valor=0;
		Console.Write("Ingrese un número: ");
		valor=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Signo(valor));
	}
}
