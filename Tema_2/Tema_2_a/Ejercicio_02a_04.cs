/*Introducir dos valores, mostrar su división siempre que no se divida entre 0
 * En caso de intentar dividir entre 0 devolver mensaje */

using System;
class Ejercicio_02a_04
{
	static void Main()
	{
		int n1,n2;
		Console.WriteLine("Ingrese los dos valores para su división: ");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		
		if (n2==0)
		{
			Console.WriteLine("No se puede dividir entre 0");
		}
		else
		{
			Console.WriteLine("{0}/{1}={2}",n1,n2,n1/n2);
			
		}
	}
}
