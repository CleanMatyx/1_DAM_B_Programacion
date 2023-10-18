/*
 * Programa que pide al usuario una letra y responde si es minúscula de la 
 * 'a' a la 'z' o no. También devuelve código numérico del carácter escrito.
 */
 
 using System;
 class Ejercicio_03c_01
{
	static void Main()
	{
		char letra;
		Console.WriteLine("Escribe una letra:");
		letra = Convert.ToChar(Console.ReadLine());
		if (letra>='a'&&letra<='z')
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
