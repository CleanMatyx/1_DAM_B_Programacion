//Ingresar variable y responder si es múltiplo de 2 y de 3

using System;
class Ejercicio_02a_06
{
	static void Main()
	{
		int n1;
		Console.WriteLine("Ingrese el número: ");
		n1=Convert.ToInt32(Console.ReadLine());
		
		if (n1%2==0 && n1%3==0)
		{
			Console.WriteLine("El número es múltiplo de 2 y de 3");
		}
		else
		{
			Console.WriteLine("El número no es múltiplo de 2 y de 3");
		}
	}
}
