//Mostrar mútimos de 3 y 7 presentes en los numeros de 100 a 200.

using System;
class Ejercicio_02b_07
{
	static void Main()
	{
		for(int n = 100; n <= 200; n++)
		{
			if (n%3==0&&n%7==0)
			{
				Console.WriteLine(n);
			}
		
		}
		Console.WriteLine("fin");
	}
}
