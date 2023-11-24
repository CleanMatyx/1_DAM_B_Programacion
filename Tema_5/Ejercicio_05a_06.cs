/*
 * Programa con función 'PedirEntero' que tiene u texto y dos enteros.
 * La función muestra por pantalla el texto y le pedirá al usuario un número
 * entero entre esos dos números. Si el número introducido no está entre esos
 * dos, volverá a pedir tantas veces sea necesario el valor hasta que sea
 * válido.
 */
 
using System;
class Ejercicio_05a_06
{
	static int PedirEntero(string mensaje, int n1, int n2)
	{
		int valor=0;
		bool correcto=false;
		
		do
		{
			try
			{
				Console.WriteLine("{0} {1} y {2}",mensaje,n1,n2);
				valor=Convert.ToInt32(Console.ReadLine());
				if(valor<n1||valor>n2)
				{
					Console.WriteLine("El valor tiene que estar entre {0} y {1}",
						n1,n2);
					Console.WriteLine();
				}
				else
					correcto=true;
			}
			catch(Exception)
			{
				Console.WriteLine("Entrada no válida");
				Console.WriteLine();
			}
		}
		while(!correcto);
		
		return valor;
	}
	static void Main()
	{
		int anyo=PedirEntero("Dime un año",1800,2000);
		Console.WriteLine("Has escrito el año: "+anyo);
		int edad=PedirEntero("Dime tu edad",0,120);
		Console.WriteLine("Tienes {0} años.",edad);
	}
}
		
