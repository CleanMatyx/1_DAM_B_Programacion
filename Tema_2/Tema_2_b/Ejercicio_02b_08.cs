//Tabla de multiplicar entera ingresando valor el usuario

using System;
class Ejercicio_02b_08
{
	static void Main()
	{
		int num;
		Console.Write("Ingrese valor para obtener la tabla de multiplicar: ");
		num=Convert.ToInt32(Console.ReadLine());
		for (int n=1;n<=10;n++)
		{
			Console.WriteLine(num+" x "+n+" = "+(num*n));
		}
	}
}
