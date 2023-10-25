//Pasa de grados celsius a kelvin y fahrenheit
using System;
class Grados
{
	static void Main()
	{
		int grados;
		Console.Write("Introduzca los grados en celsius para obtener su valor en Kelvin y Fahrenheit --> ");
		grados=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("{0} grados Celsius son {1} grados Kelvin", grados, grados+273);
		Console.WriteLine("{0} grados Celsius son {1} grados Fahrenheit", grados, grados*18/10+32);
	}
} 
