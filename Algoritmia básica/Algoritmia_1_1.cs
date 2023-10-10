/*
 * Programa que pide dividendo y divisor y que calcule el resto mediante
 * restas sucesivas.
 */
 
 using System;
 class Algoritmia_1_1
 {
	static void Main()
	{
		int dividendo, divisor, resto;
		Console.WriteLine("Ingrese el dividendo: ");
		dividendo=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese el divisor: ");
		divisor=Convert.ToInt32(Console.ReadLine());
		resto=dividendo;
		
		while (resto>=divisor)
		{
			Console.WriteLine("{0} - {1} = {2}", resto,divisor,resto-divisor);
			resto=resto-divisor;
		}
		Console.WriteLine("Resto es igual a "+resto);
	}
}
		
