/*
 * Programa que define tabla de dos filas y 10 columnas de números enteros.
 * El usuario lo rellenará y luego el programa dirá cúal es el número mayor
 * de cada fila.
 */
 
 using System;
 class Ejercicio_04a_11
{
	static void Main()
	{
		int[,] tabla = new int[2, 5];
		int mayor=0;
		Console.WriteLine("Introduce números enteros: ");
		for (int i = 0; i < tabla.GetLength(0); i++)
		{
			mayor=tabla[i,0];
			for (int j = 0; j < tabla.GetLength(1); j++)
			{
				Console.Write("Fila {0}, columna {1}: ",i+1,j+1);
				tabla[i,j]=Convert.ToInt32(Console.ReadLine());
				if(tabla[i,j]>mayor)
				{
					mayor=tabla[i,j];
				}
			}
			Console.WriteLine("El nº mayor de la fila {0} es {1}",i+1,mayor);
			mayor=0;
		}
	}
}
