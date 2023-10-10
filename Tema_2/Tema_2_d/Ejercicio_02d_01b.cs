/*
 * Programa que pide edad y año de nacimiento. En caso de error de introducción
 * de datos devolverá mensaje de error usando try...catch.
 */
 
 using System;
 class Ejercicio_02d_01b
 {
	static void Main()
	{
		 
		int edad, año;
		try
		{
			Console.WriteLine("Ingrese su edad: ");
			edad=Convert.ToInt32(Console.ReadLine());
		}
		catch (FormatException e)
		{
			Console.WriteLine("Valor incorrecto");
			Console.WriteLine(e.Message);
		}
		try
		{
			Console.WriteLine("Ingrese su año de naciemiento: ");
			año=Convert.ToInt32(Console.ReadLine());
		}
		catch (FormatException e)
		{
			Console.WriteLine("Valor incorrecto");
			Console.WriteLine(e.Message);
		}
	}
}
