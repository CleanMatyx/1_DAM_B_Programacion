/*
 * Programa para calcular la proporción de caracteres escritos en un 'string'
 * 
 */
 
 using System;
 class Alphabet_Spam
 {
	static void Main()
	{
		string spam;
		int largo=0;
		double mayus=0,minus=0,barraBaja=0,symbol=0;
		spam=Console.ReadLine();
		foreach(char caracter in spam)
		{
			if((int)caracter==95)
				barraBaja++;
			else if((int)caracter>=65&&(int)caracter<=90)
				mayus++;
			else if((int)caracter>=97&&(int)caracter<=122)
				minus++;
			else if((int)caracter>=33&&(int)caracter<=126)
				symbol++;
			largo++;
		}
		Console.WriteLine(barraBaja/largo);
		Console.WriteLine(minus/largo);
		Console.WriteLine(mayus/largo);
		Console.WriteLine(symbol/largo);
	}
}
