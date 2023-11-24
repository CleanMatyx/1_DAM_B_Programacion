/*
 * Programa que pide al usuario que rellene un array de 10 'floats' y lo 
 * muestre de mayor a menor.
 */

using System;
class Ejercicio_04d_02
{
	static void Main()
	{
		float [] numeros= new float[10];
		Console.WriteLine("Ingrese 10 números: ");
		for(int i=0;i<numeros.Length;i++)
		{
			numeros[i]=Convert.ToSingle(Console.ReadLine());
		}
		for(int i=0;i<numeros.Length-1;i++)
		{
			for(int j=i+1;j<numeros.Length;j++)
			{
				if(numeros[i]<numeros[j])
				{
					float auxiliar=numeros[i];
					numeros[i]=numeros[j];
					numeros[j]=auxiliar;
				}
			}
		}
		for(int i=0;i<numeros.Length;i++)
		{
			Console.Write(numeros[i]+" ");
		}
	}
}
		
		
