/*
 * Programa adaptación del Ejercicio_03c_01 donde se almacena en una variable
 * booleana si la letra introducida es minuscula o no.
 */
 
 using System;
 class Ejercicio_03c_05
{
	static void Main()
	{
		char letra;
		Console.WriteLine("Escribe una letra:");
		letra = Convert.ToChar(Console.ReadLine());
		bool minus=letra>='a'&&letra<='z';
		if (minus)
		{
			Console.WriteLine("La letra introducida es una letra minúscula"+
				" entre la 'a' y la 'z'");
		}
		else
		{
			Console.WriteLine("No es una letra minúscula entre 'a' y 'z'");
		}
		Console.WriteLine("Letra {0}. Código {1}",letra,(int)letra);
	}
}
