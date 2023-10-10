//Ingresar una letra y decir si es vocal o no

using System;
class Ejercicio_02a_13
{
	static void Main()
	{
		char letra;
		Console.Write("Ingrese una letra: ");
		letra=Convert.ToChar(Console.ReadLine());
		
		switch (letra)
		{
			case 'a':
			case 'e':
			case 'i':
			case 'o':
			case 'u':
			case 'A':
			case 'E':
			case 'I':
			case 'O':
			case 'U':
				Console.WriteLine("Es una vocal");
				break;
			default:
				Console.WriteLine("No es una vocal");
				break;
		}
	}
}
