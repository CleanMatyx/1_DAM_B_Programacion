/*Ingresar variable y responder si es múltiplo de 2 o de 3
 * o de ambos*/
 
 using System;
 class Ejercicio_02a_05
 {
	 static void Main()
	 {
		int n1;
		Console.WriteLine("Ingrese el número: ");
		n1=Convert.ToInt32(Console.ReadLine());
		if(n1%2==0||n1%3==0)
		{
			Console.WriteLine("El número es mútiplo de 2 o 3");
		}
		else
		{
			Console.WriteLine("El número no es mútiplo de 2 o 3");
		}
	}
}

