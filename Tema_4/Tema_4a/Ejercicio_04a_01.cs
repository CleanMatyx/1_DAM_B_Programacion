/*
 * Programa que pide cuatro números 'float' para almacenar en 'array' y 
 * calcule la media de los cuatro.
 */
 
 using System;
 class Ejercicio_04a_01
 {
	static void Main()
	{
		float media=0;
		Console.WriteLine("Introduce nota: ");
		float[] numeros = new float[4];
		for(int i=0;i<=3;i++)
		{
			numeros[i]=Convert.ToSingle(Console.ReadLine());
			media+=numeros[i];
		}
		Console.WriteLine("La media es "+media/4);
		
	}
}
