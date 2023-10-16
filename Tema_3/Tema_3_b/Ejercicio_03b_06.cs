/*
 * Programa que calcula la raíz cuadrada del número que ingrese el usuario.
 * Se usa la instrucción math.Sqrt.
 */
 
 using System;
 class Ejercicio_03b_06
 {
	static void Main()
	{
		float n1,resultado;
		Console.WriteLine("Ingrese el valor para calcular la raiz cuadrada");
		n1=Convert.ToSingle(Console.ReadLine());
		resultado = (float)Math.Sqrt(n1);
		Console.WriteLine(resultado);
	}
}
