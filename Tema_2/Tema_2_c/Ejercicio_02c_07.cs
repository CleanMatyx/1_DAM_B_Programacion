/*
 * Programa que pide al usuario dos números y calcule su MCD (el número
 * más alto divisor de ambos).
 */
 
 using System;
 class Algoritmia_1_3
 {
	static void Main()
	{
		int n1, n2, mcd, contador;
		Console.WriteLine("Introduzca dos números enteros para conocer su MCD");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		mcd=n1<n2? n1:n2;
		contador=mcd;
		
		while (contador>=1)
		{
			if(n1%contador==0&&n2%contador==0)
			{
				mcd=contador;
				break;
			}
			contador--;
		}
		Console.WriteLine("MCD= "+mcd);
	}
}
