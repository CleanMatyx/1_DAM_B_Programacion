/* Se sumarán todos los números introducidos hasta que el usuario ingrese un
 * valor negativo o un cero*/ 

using System;
class Ejercicio_02b_04
{
	static void Main()
	{
		int n1, n2=0;
		Console.WriteLine("Ingrese números positivos: ");
		do
		{
			n1=Convert.ToInt32(Console.ReadLine());
			if (n1>0)
			{
				n2=n1+n2;
			}
		}
		while (n1>0);
		Console.WriteLine("Total: "+n2);
	}
}
