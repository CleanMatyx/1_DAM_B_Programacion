//Ingresar variable y decir si es par o no

using System;
class Ejercicio_02a_01
{
	static void Main()
	{
		int valor;
		Console.WriteLine("Ingrese el valor: ");
		valor=Convert.ToInt32(Console.ReadLine());
		if (valor%2==0)
		{
			Console.WriteLine("{0} es par", valor);
		}
	}
}
			
