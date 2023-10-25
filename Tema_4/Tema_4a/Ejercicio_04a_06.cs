/*
 * Programa que pide 5 nombres 'string' y los memoriza en 'array'.
 * Seguirá pidiendo nombres y dirá si están en la lista o no.
 * el programa finaliza si se escribe 'fin'
 */
 
 using System;
 class Ejercicio_04a_06
{
	static void Main()
	{
		string nombre;
		string [] lista=new string[5];
		bool existe;
		Console.WriteLine("Introduzca {0} nombres.",lista.Length);
		for(int i=0;i<lista.Length;i++)
		{
			lista[i]=Console.ReadLine();
		}
		do
		{
			Console.WriteLine("Introduzca nombres.");
			nombre=Console.ReadLine();
			existe=false;
			if (nombre!="fin")
			{
				for(int i=0;i<lista.Length;i++)
				{
					if(nombre==lista[i])
					{
						existe=true;
					}
				}
				if (existe)
				{
					Console.WriteLine("Sí existe");
				}
				else
				{
					Console.WriteLine("No existe");
				}
			}
		}
		while(nombre!="fin");
	}
}
