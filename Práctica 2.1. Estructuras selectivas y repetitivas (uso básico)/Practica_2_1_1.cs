/*
 * Programa que pide al usuario tres temperaturas en grados centígrados y 
 * muestre un mensaje dependiendo de su valor.
 * "Es verano" (si todas las temperaturas pasan de 25 grados).
 * "Es primavera u otoño" (si alguna temperatura no pasa de 25, pero todas son 
 *  de al menos 15 grados).
 * "Es invierno" (si alguna temperatura no llega a 15 grados).
 */
 
 using System;
 class Practica_2_1_1
 {
	static void Main()
	{
		int temp1, temp2, temp3;
		Console.WriteLine("Ingrese las temperaturas en grados centígrados: ");
		temp1=Convert.ToInt32(Console.ReadLine());
		temp2=Convert.ToInt32(Console.ReadLine());
		temp3=Convert.ToInt32(Console.ReadLine());
		 
		if (temp1>25&&temp2>25&&temp3>25)
		{
			Console.WriteLine("Es verano");
		}
		else if(temp1>=15&&temp2>=15&&temp3>=15)		
		{
			Console.WriteLine("Es primavera u otoño");
		}
		else
		{
			Console.WriteLine("es invierno");
		}	 
	}
}
