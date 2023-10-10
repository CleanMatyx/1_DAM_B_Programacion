//ingresar dos valores y decir cúal es el menor de los dos

using System;
class Ejercicio_02a_11
{
	static void Main()
	{
		int n1, n2, n3;
		Console.WriteLine("Ingrese dos números: ");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		
		n3=n2>n1? n1:n2;
		Console.Write("El menor de los dos número es "+n3);
	}
}

/* programa más acortado
 * using System;
class Ejercicio_02a_11
{
	static void Main()
	{
		int n1, n2;
		Console.WriteLine("Ingrese dos números: ");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		
		Console.Write("El menor de los dos número es "+n2>n1? n1:n2);
	}
}
*/