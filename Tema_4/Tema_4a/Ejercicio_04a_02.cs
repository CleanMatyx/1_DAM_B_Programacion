/*
 * Programa que almacena en 'array' 12 posiciones enteras el número de días de 
 * cada mes. Pedirá al usuario que escriba un número de mes y dirá cuantos 
 * días tiene ese mes seleccionado.
 */
 
 using System;
 class Ejercicio_04a_02
{
	static void Main()
	{
		int[]nMeses =new int[12]{31,28,31,30,31,30,31,31,30,31,30,31};
		string[]mes=new string[12]{"Enero","Febrero","Marzo","Abril","Mayo",
			"Junio","Julio","Agosto","Septiembre","Octubre","Noviembre",
			"Diciembre"};
		Console.WriteLine("Introduce número de mes para conocer días :");
		int nMes=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("El mes de {0} tiene {1} días",mes[nMes-1],
			nMeses[nMes-1]);
	}
}

