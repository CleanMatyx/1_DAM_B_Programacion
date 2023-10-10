/*
* Programa que pide tu serie de cartas y calcula puntuación. Las cartas son 
* 'tablet' ('T'), 'Compass' ('C') y 'Gear' ('G'). Se cuentan las cartas y 
* se eleva al cuadrado (T*T+C*C+G*G).
* En caso de tener una carta de cada una se sumarían siete puntos por trío.
*/

using System;
class Seven_wonders
{
	static void Main()
	{
		string mano=Console.ReadLine();
		int T=0,C=0,G=0,extra=0;
		foreach(char carta in mano)
		switch (carta)
		{
			case 'T':
				T++;
				break;
			case 'C':
				C++;
				break;
			case 'G':
				G++;
				break;
		}
		if (T>=1&&C>=1&&G>=1)
		{
			if (T<C&&T<G)
			{
				extra=T;
			}
			else if (C<T&&C<G)
			{
				extra=C;
			}
			else
			{
				extra=G;
			}
		}
		Console.WriteLine((T*T)+(C*C)+(G*G)+7*extra);
	}
}
