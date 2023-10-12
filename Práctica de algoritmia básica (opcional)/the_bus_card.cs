/* Programa para calcular el mínimo número de transacciones necesarias 
 * para viajar con una cantidad 'k' de dinero.
 */
 
 using System;
 class Ejercicio_Bus
 {
     static void Main()
     {
        int k,resto,contador;
        k=Convert.ToInt32(Console.ReadLine());
        if (k>=1)
        {
		contador=k/500;
		resto=k%500;
		if (resto>400)
		{
			contador++;
		}
		else if (resto>200)
		{
			contador=contador+2;
		}
		else
		{
			contador++;
		}
		Console.WriteLine(contador);
	}
     }
 }
