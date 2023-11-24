/*
 * Programa que le pide al usuario varios números en una línea separados por
 * espacios y calcule su suma usando 'foreach'
 */
 
 using System;
 class Ejercicio_04d_01
 {
	static void Main()
    {
        string lista;
        string[]nums;
        int suma=0;
        
        Console.WriteLine("Escribe números separados por espacios:");
        lista=Console.ReadLine();
        nums=lista.Split(' ');
        
		foreach(string num in nums)
		{
			suma+=Convert.ToInt32(num);
		}
		Console.WriteLine("Suma= "+suma);
	}
}
