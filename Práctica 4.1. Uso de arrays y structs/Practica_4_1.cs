/*
 * Programa para gestionar habitaciones de hotel.
 * Mostrará menú con diversas opciones para añadir nueva habitación, listar
 * habitaciones existentes
 */
 
 using System;
 class Practica_4_1
{
	enum opciones{SALIR,NUEVA_HABITACION,LISTAR_TODO,BUSCAR_HABITACION,
			FILTRAR_HABITACION}
	struct habitaciones
	{
		public int numeroHab;
		public double precioNoche;
		public string descripcion;
		public extra servicios;
	}
	struct extra
	{
		public bool wifi;
		public int huespedes;
	}
	static void Main()
	{
		int contadorHab=0,numHuesped=0,numHabitacion,contador=0;
		double precioMax=0;
		string preguntaWifi;
		bool existe=false;
		habitaciones[]lista=new habitaciones[100];
		opciones opcionUsuario;
		do
		{	
			Console.WriteLine("Elije una opción:");
			Console.WriteLine("1. Nueva habitación");
			Console.WriteLine("2. Listar habitaciones");
			Console.WriteLine("3. Buscar habitación");
			Console.WriteLine("4. Filtrar habitación");
			Console.WriteLine("0. Salir");
			opcionUsuario=(opciones)Convert.ToInt32(Console.ReadLine());
			
			switch (opcionUsuario)
			{
				case opciones.NUEVA_HABITACION:
				{
					if(contadorHab<lista.Length)
					{
						existe=false;
						numHabitacion=0;
						numHuesped=0;
						Console.WriteLine("Ingrese nº de habitación");
						numHabitacion=Convert.ToInt32(Console.ReadLine());
						for(int i=0;i<=contadorHab;i++)
						{
							if(lista[i].numeroHab==numHabitacion)
								existe=true;
						}
						if(existe)
						{
							Console.WriteLine("Ya existe esa habitación en la "
								+"base de datos");
						}
						else
						{
							lista[contadorHab].numeroHab=numHabitacion;
							Console.WriteLine("Ingrese el precio/noche");
							lista[contadorHab].precioNoche=
								Convert.ToSingle(Console.ReadLine());
							Console.WriteLine("Añada una descripción");
							lista[contadorHab].descripcion=
								Console.ReadLine();
							Console.WriteLine("Dispone de WiFi? \"Si\" "
								+"o \"No\"");
							preguntaWifi=Console.ReadLine();
							if(preguntaWifi=="Si")
								lista[contadorHab].servicios.wifi=true;
							do
							{
								try
								{
									Console.WriteLine("Ingrese nº de huésped");
									numHuesped=
										Convert.ToInt32(Console.ReadLine());
									if(numHuesped<1||numHuesped>5)
										Console.WriteLine("Nº de huéspedes no "
											+"válido.");
								}
								catch (FormatException)
								{
									Console.WriteLine("El dato no es correcto");
								}
							}
							while(numHuesped<1||numHuesped>5);
							lista[contadorHab].servicios.huespedes=numHuesped;
							contadorHab++;
						}
					}
					break;
				}
				case opciones.LISTAR_TODO:
				{
					if (contadorHab>0)
					{
						Console.WriteLine("Listado de habitaciones:");
						for(int i=0;i<contadorHab;i++)
						{
							Console.WriteLine("Habitación: "+lista[i].numeroHab
							+"\nPrecio/noche: "+lista[i].precioNoche+"\n"+
							"Descripción: "+lista[i].descripcion);
							if(lista[i].servicios.wifi)
								Console.WriteLine("Wifi: Disponible");
							else
								Console.WriteLine("Wifi: No disponible");
							Console.WriteLine();
						}
					}
					else
						Console.WriteLine("No hay habitaciones en la base de"
							+" datos");
					break;
				}
				case opciones.BUSCAR_HABITACION:
				{
					if(contadorHab>0)
						{
							Console.Write("Ingrese número de habitación: ");
							numHabitacion=Convert.ToInt32(Console.ReadLine());
							existe=false;
							for(int i=0;i<contadorHab;i++)
							{
								if(lista[i].numeroHab==numHabitacion)
								{
									existe=true;
									contador=i;
								}
							}
							if(existe)
							{	
								Console.WriteLine("Habitación: "
								+lista[contador].numeroHab
								+"\nPrecio/noche: "
								+lista[contador].precioNoche
								+"\nDescripción: "
								+lista[contador].descripcion);
								if(lista[contador].servicios.wifi)
									Console.WriteLine("Wifi: Disponible");
								else
									Console.WriteLine("Wifi: No disponible");
								
								Console.WriteLine();
							}
							else
								Console.WriteLine("Habitación no"
									+" encontrada");
						}
					else
						Console.WriteLine("No hay elementos para mostrar");
					break;
				}
				case opciones.FILTRAR_HABITACION:
				{
					if(contadorHab>0)
					{
						Console.WriteLine("Ingrese precio máximo por"
						+" habitación");
						precioMax=Convert.ToDouble(Console.ReadLine());
						for(int i=0;i<contadorHab;i++)
						{
							if(lista[i].precioNoche<=precioMax)
							{	
								Console.WriteLine("Habitación: "
								+lista[i].numeroHab
								+"\nPrecio/noche: "
								+lista[i].precioNoche
								+"\nDescripción: "+lista[i].descripcion
								+"\nHuéspedes: "+lista[i].servicios.huespedes);
								if(lista[contador].servicios.wifi)
									Console.WriteLine("Wifi: Disponible");
								else
									Console.WriteLine("Wifi: No disponible");
								
								Console.WriteLine();
							}
						}
					}
					else
						Console.WriteLine("No hay elementos para mostrar");
					break;
				}
				case opciones.SALIR:
				{
					Console.WriteLine("Has elegido salir");
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
		while(opcionUsuario!=opciones.SALIR);
	}
}
