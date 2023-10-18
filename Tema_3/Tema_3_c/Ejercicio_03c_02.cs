/*
 * Programa que pide al usuario cuatro letras y las muestra en orden
 * inverso entre comillas dobles "..."
 */

using System;
class Ejercicio_03c_02
{
	static void Main()
	{
		char letra1,letra2,letra3,letra4;
		Console.WriteLine("Ingrese cuatro letras: ");
		letra1=Convert.ToChar(Console.ReadLine());
		letra2=Convert.ToChar(Console.ReadLine());
		letra3=Convert.ToChar(Console.ReadLine());
		letra4=Convert.ToChar(Console.ReadLine());
		Console.Write("\"{0}{1}{2}{3}\"",letra4,letra3,letra2,letra1);
	}
	
}
