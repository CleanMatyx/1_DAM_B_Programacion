/* Ingresar dos valores e indicar si uno de esos valores son positivos,
 * uno de los dos es positivos o ninguno es positivo. */
 
 using System;
 class Ejercicio_02a_10
 {
	 static void Main()
	 {
		int n1,n2;
		Console.WriteLine("Ingrese dos números: ");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		 
		if (n1>=0 && n2>=0)
		{
			Console.WriteLine("Los dos números son positivos");
		}
		else if (n1>=0 || n2>=0)
		{
			Console.WriteLine("Uno de los números es positivo");
		}
		else
		{
			Console.WriteLine("Ninguno de los números es positivo");
		}
	}
}
