/* Programa que pide ingresar un mensaje de saludo para devolver otro con 
 * el doble de vocales: 
 * 'heey'
 * 			'heeeey'
 */
 
 using System;
 class Ejercicio_Saludo
 {
     static void Main()
     {
		string saludo=Console.ReadLine();
		int contador=0;
		foreach(char letra in saludo)
		{
			if (letra=='e')
			{
				contador+=2;
			}
		}
		Console.Write("h");
		for (int i=1;i<=contador;i++)
		{
			Console.Write('e');
		}
		Console.Write("y");
	}
}
