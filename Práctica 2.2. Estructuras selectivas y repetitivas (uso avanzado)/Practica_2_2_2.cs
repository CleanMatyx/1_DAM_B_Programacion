/*
 * Programa que pide al usuario una secuencia de 5 números para sacar media.
 * Los números tienen que ser mayores que el anterior, si no, devuelve mensaje
 * "El número introducido debe ser mayor que el anterior".
 */
 
 using System;
 class Ejercicio_2_2_2
 {
	static void Main()
	{
		int n1,n2=0,i=0,j=0;
		do
		{
			Console.WriteLine("Escribe el {0}º número:",i+1);
			n1=Convert.ToInt32(Console.ReadLine());
			if (n1>n2)
			{
				i++;
				n2=n1;
				j=j+n1;
			}
			else
			{
				Console.WriteLine("El número introducido debe ser "+ 
				"mayor que el anterior.");
			}
		}
		while (i!=5);
		Console.WriteLine("La media de los valores escritos es "+(j/i));
	}
}
