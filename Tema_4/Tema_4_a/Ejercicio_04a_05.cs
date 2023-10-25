/*
 * variante del Ejercicio_04a_02.
 * Programa que almacena en 'array' 12 posiciones enteras el número de días de 
 * cada mes. Pedirá al usuario que escriba un número de mes y dirá cuantos 
 * días faltan para fin de año.
 */
 
using System;
 class Ejercicio_04a_05
{
	static void Main()
	{
		int nMes,nDia,dFin=0;
		int[]nMeses =new int[12]{31,28,31,30,31,30,31,31,30,31,30,31};
		string[]mes=new string[12]{"Enero","Febrero","Marzo","Abril","Mayo",
			"Junio","Julio","Agosto","Septiembre","Octubre","Noviembre",
			"Diciembre"};
		Console.WriteLine("Introduce número de mes para conocer días :");
		nMes=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce número del día :");
		nDia=Convert.ToInt32(Console.ReadLine());
		for(int i=nMes-1;i<nMeses.Length;i++)
		{
			dFin+=nMeses[i];
		}
		dFin-=nDia;
		Console.WriteLine("Has elegido el {0} de {1}",nDia,mes[nMes-1]);
		Console.WriteLine("Quedan {0} días para din de año",dFin);
		
	}
}

