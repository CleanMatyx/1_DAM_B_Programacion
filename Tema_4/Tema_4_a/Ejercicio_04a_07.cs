/*
 * Programa con reserva de 100 nombres 'string' que pedirá ingresar nombres
 * hasta que se pulse intro sin escribir nada. Tras eso dirá cúantos nombres
 * ha almacenado y los mostrará en pantalla.
 */
 
 using System;
 class Ejercicio_04a_07
 {
	static void Main()
	{
		int i=0;
		string[]lista=new string[100];
		string nombre;
		Console.WriteLine("Introduce nombres");
		do
		{
			nombre=Console.ReadLine();
			lista[i]=nombre;
			i++;
		}
		while(nombre!="");
		Console.WriteLine("Has escrito {0} nombres",i);
		for(int j=0;j<=i;j++)
		{
			Console.WriteLine(lista[j]);
		}
	}
}
		

		
