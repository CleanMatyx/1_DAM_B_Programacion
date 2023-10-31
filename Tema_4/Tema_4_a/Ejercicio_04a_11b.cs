/*
 * Programa que define tabla de dos filas 'n' y 'n' columnas para rellenarlas
 * en su diagonal interior con '1' y el resto con '0'.
 * 
 */
 
 using System;
 class Ejercicio_04a_11b
{
	static void Main()
	{
		int N,contador=0;
		Console.WriteLine("Introduce valor para tablas: ");
		N=Convert.ToInt32(Console.ReadLine());
		int[,] tabla = new int[N,N];
		for (int i = 0; i < tabla.GetLength(0); i++)
		{
			for (int j = 0; j < tabla.GetLength(1); j++)
			{
				Console.Write("Fila {0}, columna {1}: ",i+1,j+1);
				tabla[i,j]=Convert.ToInt32(Console.ReadLine());
				if(i==j)
				{
					
					contador++;
				}
			}
		}
		for (int i = 0; i < tabla.GetLength(0); i++)
		{
			for (int j = 0; j < tabla.GetLength(1); j++)
				Console.Write(tabla[i, j] + " ");
			Console.WriteLine();
		}
		if(contador==N)
			Console.WriteLine("Es matriz de identidad");
		else
			Console.WriteLine("No es matriz de identidad");
	}
}

