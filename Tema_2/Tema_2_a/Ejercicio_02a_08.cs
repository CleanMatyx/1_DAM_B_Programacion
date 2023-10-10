//Ingresar tres números y decir cúal es el mayor de los tres

using System;
class Ejercicio_02a_08
{
	static void Main()
	{
		int n1,n2,n3;
		Console.WriteLine("Ingrese los tres números: ");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		n3=Convert.ToInt32(Console.ReadLine());
		
		if (n1>=n2 && n1>=n3)					//comprueba si el mayor es n1
		{
			Console.WriteLine("{0} es el mayor de los tres", n1);
		}
		else if (n2>=n1 && n2>=n3)				//comprubea si el mayor es n2
		{
			Console.WriteLine("{0} es el mayor de los tres", n2);
		}
		else
		{
			Console.WriteLine("{0} es el mayor de los tres", n3);
		}
	}
}
