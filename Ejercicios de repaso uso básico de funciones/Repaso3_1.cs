/*
 * Programa con función 'BuscarPieza' con parámetros de numero de piezas, y 
 * un array con las piezas para devolver la pieza faltante.
 */
 
using System;
class Repaso3_1
{
	static int BuscarPieza(int[] piezas, int n)
	{
		int i=0,solucion;
		Array.Sort(piezas);
		while(i<piezas.Length&&piezas[i]==i+1)
		{
			i++;
		}
		if(i==piezas.Length)
			solucion=n;
		else
			solucion=i+1;
		return solucion;
	}
	static int BuscarPieza2(int[] piezas, int n)
	{
		int suma=0,sumaTotal=0;
		/*
		for(int i=1;i<=n;i++)
		{
			sumaTotal+=i;
		}
		*/
		suma=n*(n+1)/2;					//el for de arriba se resume en esta línea
		for(int i=0;i<piezas.Length;i++)
		{
			suma+=piezas[i];
		}
		return sumaTotal-suma;
	}
		
	
	static void Main()
	{
		//Console.Write("Ingrese el número de piezas: ");
		//int n=Convert.ToInt32(Console.ReadLine());
		int[] piezas={1,5,6,2,4,8,9,3,10};
		
		int solucion=BuscarPieza(piezas,piezas.Length+1);
		Console.WriteLine("(BuscarPieza)Falta la pieza "+solucion);
		Console.WriteLine("(BuscarPieza2)Falta la pieza "+solucion);
	}
}
