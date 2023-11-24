/*
 * Modificación programa Ejercicio_04a_11.
 * Programa que define tabla de dos filas y pide longitud de cada una.
 * El usuario lo rellenará y luego el programa dirá cúal es el número mayor
 * de cada fila.
 */
 
 using System;
 class Ejercicio_04a_11
{
	static void Main()
	{
		int[][] tabla = new int[2][];
		int mayor;
		for(int i=0;i<tabla.Length;i++)
		{
			int columna=0;
			Console.WriteLine("Introduce valor para longitud de fila {0}",i+1);
			columna=Convert.ToInt32(Console.ReadLine());
			tabla[i]=new int[columna];
		}
		Console.WriteLine("Introduce números enteros: ");
		for (int i = 0; i < tabla.Length; i++)
		{
			mayor=tabla[i][0];
			for (int j = 0; j < tabla[i].Length; j++)
			{
				Console.Write("Fila {0}, columna {1}: ",i+1,j+1);
				tabla[i][j]=Convert.ToInt32(Console.ReadLine());
				if(tabla[i][j]>mayor)
				{
					mayor=tabla[i][j];
				}
			}
			Console.WriteLine("El nº mayor de la fila {0} es {1}",i+1,mayor);
		}
	}
}

