/*
 * Programa que muestra los números del 2 al 106 obviando los múltiplos de 10.
 */
 
 using System;
 class Ejercicio_02_08c
 {
	static void Main()
	{
		for (int n = 2; n <= 106; n++)
		{
			if (n%10== 0)
			{
				continue;
			}
		Console.Write(" "+n);
		}
	}
}
	

