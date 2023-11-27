/*
 * Programa que tiene un array bidimensional de tamaño 'n' y una función
 * 'EsTriangular' con parámetro del array rectangular y devuelve un 'bool'
 * si es triangular o no
 */
 
using System;
class Repaso3_2
{
	static bool EsTriangular(int[,] rect)
	{
		bool trianguloSup=true,trianguloInf=true;
		for(int i=0;i<rect.GetLength(0);i++)
		{
			for(int j=0;j<rect.GetLength(1);j++)
			{
				if(i>j&&rect[i,j]!=0)
					trianguloInf=false;
				else if(j>i&&rect[i,j]!=0)
					trianguloSup=false;
			}
		}
		return trianguloInf||trianguloSup;
	}

	static void Main()
	{
		
		Console.Write("Introduce tamaño de cuadrado: ");
		int n=Convert.ToInt32(Console.ReadLine());
		int[,] rect=new int[n,n];
		for(int i=0;i<rect.GetLength(0);i++)
		{
			for(int j=0;j<rect.GetLength(1);j++)
			{
				rect[i,j]=Convert.ToInt32(Console.ReadLine());
			}
		}
		
		bool solucion=EsTriangular(rect);
		if(solucion)
			Console.WriteLine("Es triangular");
		else
			Console.WriteLine("No es triangular");
	}
}
