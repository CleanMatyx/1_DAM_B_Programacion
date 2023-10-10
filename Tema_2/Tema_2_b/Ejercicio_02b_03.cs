//Ejercicio _02b_01 pero usando do...while

using System;
class Ejercicio_02b_03
{
	static void Main()
	{
		int password;
		do
		{
			Console.WriteLine("Ingrese contraseña: ");
			password=Convert.ToInt32(Console.ReadLine());
		}
		while (password!=1111);
		Console.WriteLine("Contraseña correcta");
	}
}
