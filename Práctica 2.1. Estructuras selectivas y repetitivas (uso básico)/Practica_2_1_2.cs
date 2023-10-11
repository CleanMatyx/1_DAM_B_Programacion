/*
 * Programa que realiza un conteo dado dos valores enteros ingresadas.
 * Este conteo puede ser ascendente o descendente.
 */
 
 using System;
 class Practica_2_1_2
 {
	static void Main()
	{
		int num1, num2;
		Console.WriteLine("Ingrese dos valores enteros: ");
		num1=Convert.ToInt32(Console.ReadLine());
		num2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		
		if (num1<num2)
		{
			for(int i=num1;i<=num2;i++)
			{
				Console.Write(i+" ");
			}
		}
		else
		{
			for(int i=num1;i>=num2;i--)
			{
				Console.Write(i+" ");
			}	
		}
	}
}
