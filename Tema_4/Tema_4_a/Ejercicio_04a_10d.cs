/*
 * Programa continuación del Ejercicio_04a_10c.
 * Mostrará menú con opciones y haga lo que la opción dice hasta que el usuario
 * elija salir.
 * 		1. Nuevo videojuego al final
 *		2. Nuevo videojuego en una posición
 *		3. Borrar videojuego
 *		4. Salir
 * 
 */
 
 using System;
 class Ejercicio_04a_10b
{
	enum opciones{NUEVO_FINAL=1,NUEVO_POSICION,NUEVO_BORRAR,SALIR}
	static void Main()
	{
		string[]lista=new string[100];
		bool end=false;
		int cantidad=0,posicion=0;
		opciones opcionUsuario;
		do
		{	Console.WriteLine("Elije una opción:");
			Console.WriteLine("1. Nuevo videojuego al final");
			Console.WriteLine("2. Nuevo videojuego en una posición");
			Console.WriteLine("3. Borrar videojuego");
			Console.WriteLine("4. Salir");
			opcionUsuario=(opciones)Convert.ToInt32(Console.ReadLine());
			switch (opcionUsuario)
			{
				case opciones.NUEVO_FINAL:
					if (cantidad<lista.Length)
					{
						Console.Write("Introduce un título de videojuego: ");
						lista[cantidad]=Console.ReadLine();
						cantidad++;
					}
					else
						Console.WriteLine("La lista está llena!!");
					break;
				case opciones.NUEVO_POSICION:
					{
						if(cantidad<lista.Length)
						{
							Console.WriteLine("Introduce una posición:");
							posicion=Convert.ToInt32(Console.ReadLine());
							posicion--;
							if(posicion>=0&&posicion<=cantidad)
							{
								Console.Write("Introduce un nº de videojuego: ");
								for(int i=cantidad;i>posicion;i--)
									lista[i]=lista[i-1];
								lista[posicion]=Console.ReadLine();
								cantidad++;
							}
						}
						else
						Console.WriteLine("La lista está llena!!");
					}
					break;
				case opciones.NUEVO_BORRAR:
					{
						if(cantidad>0)
						{
							for(int i=0;i<cantidad;i++)
							{
								Console.WriteLine(i+1+" "+lista[i]);
							}
							Console.Write("Introduzca el nº del videjouego a "
								+"borrar: ");
							posicion=Convert.ToInt32(Console.ReadLine());
							posicion--;
							if(posicion>=0&&posicion<cantidad)
							{
								for(int i=posicion;i<cantidad-1;i++)
									lista[i]=lista[i+1];
									cantidad--;
							}
						}
						else
						Console.WriteLine("No hay elementos para borrar");
					}
					break;
				case opciones.SALIR:
					Console.WriteLine("Has elejido salir");
					end=true;
					break;
			}
			if(opcionUsuario!=opciones.SALIR)
			{
				Console.WriteLine("Estado actualizado de videojuegos");
				for(int i=0;i<cantidad;i++)
				{
					Console.WriteLine(lista[i]);
				}
				Console.WriteLine("Pulsa intro para continuar...");
				Console.ReadLine();
				Console.Clear();
			}
		}
		while(!end);
	}
			
}

