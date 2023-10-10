//Cálculo de conversión metros/millas
using System;
class Ejercicio_01c_06
{
	static void Main()
	{
		int a;
		{
			Console.Write("Introduzca los metros a convertir: ");
			a=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("{0} metros son {1} millas", a, a/1609.0);
		}
	}
}
