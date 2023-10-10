//Ingresar variable y responder si es múltiplo de 2 pero no de 3

using System;
class Ejercicio_02a_07
{
	static void Main()
	{
		int n1;
		Console.WriteLine("Ingrese el número: ");
		n1=Convert.ToInt32(Console.ReadLine());
		
		if (n1%2==0 && n1%3!=0)
		{
			Console.WriteLine("El numero es múltiplo de 2 y no de 3");
		}
		else
		{
			Console.WriteLine("El número no cumple la condición");
		}
	}
}
