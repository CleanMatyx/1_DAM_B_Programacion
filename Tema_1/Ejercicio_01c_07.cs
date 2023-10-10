//División de dos variables con resto
using System;
class Ejercicio_01c_07
{
	static void Main()
	{
		int a,b;
		Console.WriteLine("Intruduzca el primer valor: ");
		a=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Intruduzca el segundo valor: ");
		b=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("El resultado de {0}/{1}= {2} ",a,b,a/b);
		Console.WriteLine("Su resto es= {0}",a%b);
	}
}
