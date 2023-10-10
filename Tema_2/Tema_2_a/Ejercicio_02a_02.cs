//Ingresar dos números enteros y decir cúal es el mayor

using System;
class Ejercicio_02a_02
{
	static void Main()
	{
		int valor_1, valor_2;
		Console.WriteLine("Introduzca los dos valores a comparar: ");
		valor_1=Convert.ToInt32(Console.ReadLine());
		valor_2=Convert.ToInt32(Console.ReadLine());
		if (valor_1<valor_2)
		{
			Console.WriteLine("el mayor es: "+ valor_2);
		}
		if (valor_1>valor_2)
		{
			Console.WriteLine("el mayor es: "+ valor_1);
		}
		if (valor_1==valor_2)
		{
			Console.WriteLine("el mayor es: "+ valor_1);
		}
	}
}
