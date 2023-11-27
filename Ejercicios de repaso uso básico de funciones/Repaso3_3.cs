/*
 * Programa con función 'MaxProducto' con parámetro de entrada un array de 'int'
 * que devuelve un parámetro 'out' el mayor producto que se puede obtener con
 * dos de sus elementos.
 */
 
using System;
class Repaso3_3
{
	static void MaxProducto(int[] num, out int producto)
	{
		Array.Sort(num);
		int prodPrim=num[0]*num[1];
		int prodUlti=num[num.Length-1]*num[num.Length-2];
		producto=Math.Max(prodPrim,prodUlti);
	}
	
	static void Main()
	{
		int[] num={10,40,20,40};
		int producto=0;
		MaxProducto(num,out producto);
		Console.WriteLine("El mayor producto es : "+producto);
	}
}
