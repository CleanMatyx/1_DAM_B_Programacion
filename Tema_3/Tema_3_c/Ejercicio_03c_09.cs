/*
 * Programa que define la enumeración de los meses del año. El usuario introduce
 * un número entero y usando la enumeración devuelve el mes correspondiente
 */
 
 using System;
 enum mesesAño {
    ENERO=1,FEBRERO,MARZO,ABRIL,MAYO,JUNIO,JULIO,AGOSTO,SEPTIMBRE,OCTUBRE,
    NOVIEMBRE,DICIEMBRE
    };
 class Ejercicio_03c_08
 {
	static void Main()
	{
		int valor;
		Console.WriteLine("Introduce el número del mes");
		valor=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine((mesesAño)valor);
	}
}
