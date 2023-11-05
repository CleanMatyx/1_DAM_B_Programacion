/*
 * Programa que dice si suena 'hiss' o 'no hiss' al pronunciar una palabra
 * tipo 'string'.
 */

using System;

class Hissing_Microphone
{
	static void Main()
	{
		string texto;
		int contador=0;
		bool end=false;
		texto=Console.ReadLine();
		foreach(char letra in texto)
		{
			if(letra=='s')
			{
				contador++;
				if (contador==2)
					end=true;
			}
			else
				contador=0;
		}
		if(end)
			Console.WriteLine("hiss");
		else
			Console.WriteLine("no hiss");
    }
}
