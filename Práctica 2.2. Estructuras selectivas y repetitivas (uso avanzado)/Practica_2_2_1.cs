/*
 * Programa que pide una altura (positivo >1) y dibuje figura de dos picos
 *          *        *
 *	   ***      ***
 *	  *****    *****
 *	 *******  *******
 *	******************
 */
 
 using System;
 class Practica_2_2_1
{
	static void Main()
	{
		try
		{
			int h,cEspacios,cAsteriscos;
			Console.Write("Introduzca altura de figura: ");
			h=Convert.ToInt32(Console.ReadLine());
			cEspacios=h-1;
			cAsteriscos=1;
			if (h>1)
			{
				for (int i=1;i<=h;i++)
				{
					for (int j=1;j<=cEspacios;j++)
					{
						Console.Write(" ");
					}
					for (int k=1;k<=cAsteriscos;k++)
					{
						Console.Write("*");
					}
					for (int l=1;l<=2*cEspacios;l++)
					{
						Console.Write(" ");
					}
					for (int m=1;m<=cAsteriscos;m++)
					{
						Console.Write("*");
					}	
					Console.WriteLine();
					cAsteriscos+=2;
					cEspacios--;	
				}
			}
			else
			{
				Console.WriteLine("Altura no válida");
			}
		}
		catch (FormatException)
		{				
			Console.WriteLine("Altura no válida");
		}	
	}
}

