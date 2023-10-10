/*
 * Programa que pide al usuario valores de color RGB (de 0 a 255) y muestre 
 * el color en formato hexadecimal.
 */
 
 using System;
 class Ejercicio_03a_05
 {
	static void Main()
	{
		byte R,G,B;
		Console.WriteLine("Ingrese el valor para color ROJO: ");
		R=Convert.ToByte(Console.ReadLine());
		Console.WriteLine("Ingrese el valor para color VERDE: ");
		G=Convert.ToByte(Console.ReadLine());
		Console.WriteLine("Ingrese el valor para color AZUL: ");
		B=Convert.ToByte(Console.ReadLine());
		Console.WriteLine();
		Console.Write(Convert.ToString(R,16));
		Console.Write(Convert.ToString(G,16));
		Console.Write(Convert.ToString(B,16));
	}
}
