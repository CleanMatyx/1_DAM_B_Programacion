/*
 * Programa que pide introducir tamaño de 'array' y que luego introduzca esa
 * misma cantidad de números. Se realiza media de esos números y se mostrará
 */
 
 using System;
 class Ejercicio_04a_04
{
	static void Main()
	{
		Console.WriteLine("introduce tamaño de lista :");
		int tamañoLista=Convert.ToInt32(Console.ReadLine());
		float [] numeros=new float [tamañoLista];
		float media=0;
		Console.WriteLine("introduce {0} números :",numeros.Length);
		for(int i=0;i<numeros.Length;i++)
		{
			numeros[i]=Convert.ToSingle(Console.ReadLine());
			media+=numeros[i];
		}
		media/=(float)numeros.Length;
		Console.WriteLine("La media es {0}",media);
		Console.WriteLine("Números por encima de la media: ");
		for(int i=0;i<numeros.Length;i++)
		{
			if(numeros[i]>media)
			{
				Console.WriteLine(numeros[i]);
			}
		}
	}
}
		
