/*
 * Programa que pide al usuario una temperatura en celsius o fahrenheit y 
 * la transforma a la otra unidad.
 * 
 * En el programa tengo en cuenta la temperatura mínima del cero absoluto.
 * 
 */
 
 using System;
 class Practica_3_2
 {
	static void Main()
	{
		double temp;
		bool end=false;
		do
		{
			try
			{
				Console.WriteLine("Introduce una temperatura:");
				temp=Convert.ToSingle(Console.ReadLine());
				Console.WriteLine("Introduce su unidad 'C' o 'F'");
				char unidad=Convert.ToChar(Console.ReadLine());
				switch (unidad)
				{
					case 'C':
					{
						if(temp>-273.15)
							Console.WriteLine("{0}º Celsius "
								+"son {1}º Fahrenheit",temp,(temp*9/5)+32);
						else
							Console.WriteLine("−273,15 °C es la temperatura "
								+"mínima al ser el cero absoluto");
						end=true;
						break;
					}
					case 'F':
					{
						if(temp>-459.67)
							Console.WriteLine("{0}º Fahrenheit "
								+"son {1}º Celsius ",temp,((temp-32)*5/9));
						else
							Console.WriteLine("-459.67 °F es la temperatura "
								+"mínima al ser el cero absoluto");
						end=true;
						break;
					}
					default:
					{
						Console.WriteLine("Unidad no válida");
						end=true;
						break;
					}
				}
			}
			catch (FormatException)
			{
				Console.WriteLine("El dato no es correcto");
			}
		}
		while (!end);
	}
}
