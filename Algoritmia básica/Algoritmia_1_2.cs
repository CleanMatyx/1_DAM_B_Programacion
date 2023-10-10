/*
 * Programa que calcula el MCD con el algoritmo de Euclides. Se ingresan dos 
 * valores para el cálculo.
 */
 
 using System;
 class Algoritmia_1_2
 {
	static void Main()
	{
		int n1,n2,menor,mayor,resto;
		Console.WriteLine("Ingrese dos valores para conocer su MCD: ");
		n1=Convert.ToInt32(Console.ReadLine());
		n2=Convert.ToInt32(Console.ReadLine());
		menor=n1<n2? n1:n2;
		mayor=n1>n2? n1:n2;
		
		do
		{
			resto=mayor%menor;
			if (resto!=0)
			{
				Console.WriteLine("Dividimos {0} / {1}. ", mayor,menor);
				Console.WriteLine("El resto es {0} ", resto);
				mayor=menor;
				menor=resto;	
			}
		}
		while (resto!=0);
		Console.WriteLine("Dividimos {0} / {1}. ", mayor,menor);
		Console.WriteLine("El exacto");
		Console.WriteLine("El MCD es "+menor);
		
	}
 }
