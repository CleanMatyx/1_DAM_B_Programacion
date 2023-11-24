/*
 * Programa que usa un 'array' para almacenar hasta 100 canciones y mostrará el
 * siguiente menú:
 * 		1.Añadir una canción al final
 *		2.Mostrar los títulos de todas las canciones
 *		3.Buscar canciones de un artista determinado
 */

using System;
class Ejercicio_04b_02
{
	enum opciones{NUEVO_FINAL=1,MOSTRAR_TODO,BUSCAR_ARTISTA,SALIR}
	struct datosMp3
    {
        public string artista;
        public string titulo;
        public int duracion;
        public int tamaño;
    }
	static void Main()
	{
		datosMp3[]datos=new datosMp3[100];
		bool end=false;
		string nombreArtista;
		int cantidad=0;
		opciones opcionUsuario;
		do
		{	
			Console.WriteLine("Elije una opción:");
			Console.WriteLine("1. Añadir una canción al final");
			Console.WriteLine("2. Mostrar los títulos de todas las canciones");
			Console.WriteLine("3. Buscar canciones de un artista determinado");
			Console.WriteLine("4. Salir");
			opcionUsuario=(opciones)Convert.ToInt32(Console.ReadLine());
			switch (opcionUsuario)
			{
				case opciones.NUEVO_FINAL:
				{
					if (cantidad<datos.Length)
					{
						Console.WriteLine("Ingrese nombre de Artista:");
						datos[cantidad].artista=Console.ReadLine();
						Console.WriteLine("Ingrese nombre de canción:");
						datos[cantidad].titulo=Console.ReadLine();
						Console.WriteLine("Ingrese duración:");
						datos[cantidad].duracion=
							Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Ingrese tamaño archivo en kb:");
						datos[cantidad].tamaño=
							Convert.ToInt32(Console.ReadLine());
						cantidad++;
					}
					else
						Console.WriteLine("La lista está llena!!");
					break;
				}
				case opciones.MOSTRAR_TODO:
				{
					if (cantidad<datos.Length)
					{
						Console.WriteLine("Listado actualizaco de canciones:");
						for(int i=0;i<cantidad;i++)
						{
							Console.WriteLine("Artista: "+datos[i].artista
							+"\nTítulo: "+datos[i].titulo+"\n"+"Duración: "
							+datos[i].duracion+" segundos\nTamaño en kb: "
							+datos[i].tamaño+"kb");
						}
						Console.WriteLine("Pulsa intro para continuar...");
						Console.ReadLine();
						Console.Clear();
					}
					else
						Console.WriteLine("La lista está llena!!");
					break;
				}
				case opciones.BUSCAR_ARTISTA:
				{
					{
						if(cantidad>0)
						{
							Console.WriteLine("Ingrese nombre de Artista:");
							nombreArtista=Console.ReadLine();
							for(int i=0;i<cantidad;i++)
							{
								if(datos[i].artista==nombreArtista)
								{	
									Console.WriteLine("Título: "
										+datos[i].titulo);
									Console.WriteLine();
								}
							}
							Console.WriteLine("Pulsa intro para continuar...");
							Console.ReadLine();
							Console.Clear();
						}
						else
						Console.WriteLine("No hay elementos para mostrar");
					}
					break;
				}
				case opciones.SALIR:
				{
					Console.WriteLine("Has elejido salir");
					end=true;
					break;
				}
			}
			if(opcionUsuario!=opciones.SALIR)
			{
				Console.WriteLine("Pulsa intro para continuar...");
				Console.ReadLine();
				Console.Clear();
			}
		}
		while(!end);
	}
			
}

