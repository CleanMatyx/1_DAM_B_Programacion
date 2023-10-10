/*
 * Programa que pide al usuario dos datos de tipo 'byte' y calcule su 
 * multiplicación en otra variable.
 */
 
 using System;
 
class Ejercicio_03a_01
{
	static void Main()
	{
		byte n1,n2;
		int resultado;
		Console.Write("Ingrese el primer valor: ");
		n1=Convert.ToByte(Console.ReadLine());
		Console.Write("Ingrese el segundo valor: ");
		n2=Convert.ToByte(Console.ReadLine());
		Console.WriteLine();
		resultado=n1*n2;
		Console.WriteLine("{0} * {1} = {2}",n1,n2,resultado);
	}
}
		
