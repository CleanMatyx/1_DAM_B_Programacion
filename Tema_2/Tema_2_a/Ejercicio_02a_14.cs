/*Ingresar un caracter y determinar el grupo de pertenencia entre letra del 
 * alfabeto (A a Z), dígito del 0 al 9 o cualquier otra cosa (signos de 
 * puntuación, minúsculas, símbolos...)*/
 
using System;
class Ejercicio_02a_14
{
	static void Main()
	{
		char caracter;
		Console.Write("Ingrese el carácter a analizar: ");
		caracter=Convert.ToChar(Console.ReadLine());
		
		if (caracter>='A'&&caracter<='Z')
		{
			Console.WriteLine("Es una letra del Alfabeto mayúscula");
		}
		else if (caracter>='0' && caracter<='9')
		{
			Console.WriteLine("Es un número del 0 al 9");
		}
		else
		{
			Console.WriteLine("Es otra cosa");
		}
	}
}
