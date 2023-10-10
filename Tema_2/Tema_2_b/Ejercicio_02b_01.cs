//Ingresar contraseña numérica y repetir hasta que ingrese la contraseña 1111.

using System;
class Ejercicio_02b_01
{
	static void Main()
	{
		int password;
		password=0;
		while(password!=1111)
		{
			Console.WriteLine("Ingrese contraseña: ");
			password=Convert.ToInt32(Console.ReadLine());
		}
		Console.WriteLine("Contraseña correcta");
	}
}
