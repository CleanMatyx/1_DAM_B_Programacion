/* 
 * Programa que gestiona un array de habitaciones de hotel. Permite añadir
 * habitaciones, buscarlas, filtrar por precio, etc. Y ahora en el nuevo parche
 * se añadira la funcion de ordenar habitaciones y busqueda avanzada.
 */
 
using System;

class Practica4
{
    enum opciones  { SALIR, NUEVA, LISTADO, BUSCAR, FILTRAR, ORDENAR, AVANZADO }

    struct serviciosHabitacion
    {
        public bool wifi;
        public int huespedes;
    }
    
    struct habitacion
    {
        public int numero;
        public float precio;
        public string descripcion;
        public serviciosHabitacion servicios;
    }
    static opciones MostrarMenu()
    {
		opciones opcionUsuario;
		Console.WriteLine("1. Añadir habitación");
		Console.WriteLine("2. Ver listado de habitaciones");
		Console.WriteLine("3. Buscar habitaciones");
		Console.WriteLine("4. Filtrar habitaciones");
		Console.WriteLine("5. Ordenar habitaciones");
		Console.WriteLine("6. Busqueda avanzada");
		Console.WriteLine("0. Salir del programa");
		Console.WriteLine("Elige una opción:");

		opcionUsuario = (opciones)Convert.ToInt32(Console.ReadLine());
		return opcionUsuario;
	}
	
	static void NuevaHabitacion(habitacion[] habitaciones, ref int cantidad)
	{
		if (cantidad < habitaciones.Length)
        {
			Console.Clear();
			Console.WriteLine("Número de habitación:");
			int numHabitacion = Convert.ToInt32(Console.ReadLine());
			bool encontrado=ComprobarHabitacion(habitaciones,cantidad,
				numHabitacion);
			
			if (!encontrado)
			{
				habitaciones[cantidad].numero = numHabitacion;

				Console.WriteLine("Precio por noche:");
				habitaciones[cantidad].precio =
					Convert.ToSingle(Console.ReadLine());
				do
				{
					try
					{
						Console.WriteLine("Max. huéspedes:");
						habitaciones[cantidad].servicios.huespedes
							= Convert.ToInt32(Console.ReadLine());
					}
					catch(Exception)
					{
						Console.WriteLine("Cantidad no válida");
					}
				}
				while(habitaciones[cantidad].servicios.huespedes > 5 
				 || habitaciones[cantidad].servicios.huespedes < 1);

				Console.WriteLine("Descripción de la habitación:");
				habitaciones[cantidad].descripcion = Console.ReadLine();

				Console.WriteLine("WiFi (S/N):");
				bool internet=ComprobarWifi(habitaciones,cantidad);
				habitaciones[cantidad].servicios.wifi = internet;
				cantidad++;
			}
		}
		else
			Console.WriteLine("No caben más habitaciones");
	}
	
	static bool ComprobarHabitacion(habitacion[] habitaciones, int cantidad,
		int numHabitacion)
	{
		bool encontrado=false;
		encontrado = false;
		for (int i = 0; i < cantidad; i++)
		{
			if (habitaciones[i].numero == numHabitacion)
			{
				Console.WriteLine("Habitación ya existente");
				encontrado = true;
			}
		}
		return encontrado;
	}
	
	static bool ComprobarWifi(habitacion[] habitaciones,int cantidad)
	{
		bool internet = false;
		string preguntaWiFi = Console.ReadLine();
		if (preguntaWiFi == "S" || preguntaWiFi == "s")
			internet= true;
			
		return internet;
		
	}
	
	static void ListarHabitaciones(habitacion[] habitaciones, int cantidad)
	{
		if (cantidad > 0)
		{
			Console.Clear();
			for (int i = 0; i < cantidad; i++)
			{
				MostrarDatos(habitaciones,i);
			}
		}
		else
		{
			Console.WriteLine("No hay habitaciones almacenadas");
		}
	}
	
	static void BuscarHabitacion(habitacion[] habitaciones, int cantidad)
	{
		if (cantidad > 0)
		{
			Console.Clear();
			Console.WriteLine("Número de la habitación a buscar:");
			int numHabitacion = Convert.ToInt32(Console.ReadLine());
			bool encontrado = false;
			for (int i = 0; i < cantidad; i++)
			{
				if (habitaciones[i].numero == numHabitacion)
				{
					Console.WriteLine("Numero: " + 
						habitaciones[i].numero);
					Console.WriteLine("Precio: " + 
						habitaciones[i].precio);
					Console.WriteLine("Descripción: " + 
						habitaciones[i].descripcion);
					Console.WriteLine("Max. huespedes: " +
						habitaciones[i].servicios.huespedes);
					if (habitaciones[i].servicios.wifi)
						Console.WriteLine("Wifi: si");
					else
						Console.WriteLine("Wifi: no");
					encontrado = true;
				}
			}
			if (encontrado == false)
			{
				Console.WriteLine("Habitación no encontrada");
			}
		}
		else
		{
			Console.WriteLine("No hay habitaciones almacenadas");                        
		}
	}
	
	static void FiltrarHabitaciones(habitacion[] habitaciones, int cantidad)
	{
		if(cantidad > 0)
		{
			Console.Clear();
			Console.WriteLine("Dime un precio máximo:");
			float filtroPrecio = Convert.ToSingle(Console.ReadLine());

			for (int i = 0; i < cantidad; i++)
			{
				if (filtroPrecio >= habitaciones[i].precio)
				{
					MostrarDatos(habitaciones,i);
				}
			}
		}
		else
		{
			Console.WriteLine("No hay habitaciones almacenadas");                                                
		}
	}
	
	static void OrdenarHabitaciones(ref habitacion[] habitaciones, int cantidad)
	{
		if(cantidad > 0)
		{
			Console.Clear();
			for (int i = 0; i < cantidad-1; i++)
			{
				for (int j = i+1; j < cantidad; j++)
				{
					if (habitaciones[i].precio > habitaciones[j].precio)
					{
						habitacion auxiliar = habitaciones[i];
						habitaciones[i] = habitaciones[j];
						habitaciones[j] = auxiliar;
					}
				}
			}
			for (int i = 0; i < Math.Min(cantidad,3); i++)
			{
				MostrarDatos(habitaciones,i);
			}
		}
		else
		{
			Console.WriteLine("No hay habitaciones almacenadas");                                                
		}
	}
	
	static void BusquedaAvanzada(habitacion[] habitaciones, int cantidad)
	{
		if(cantidad > 0)
		{
			Console.Clear();
			Console.WriteLine("Escribe un texto para buscar");
			string texto=Console.ReadLine().ToUpper();
			bool encontrado = false;
			for (int i = 0; i < cantidad; i++)
			{                                
				int indice=habitaciones[i].descripcion.ToUpper().
					IndexOf(texto);
				
				if(indice>=0)
				{
					encontrado = true;
					int principio=indice-10;
					int fin=indice+texto.Length+10;
					
					if(principio<0)
					{
						principio=0;
					}
					
					if(fin>habitaciones[i].descripcion.Length)
					{
						fin=habitaciones[i].descripcion.Length;
					}
					
					string descripcionRecortada=habitaciones[i].descripcion
						.Substring(principio,fin-principio);
					
					
					MostrarDatos(habitaciones,i);
					Console.WriteLine("\t..." + descripcionRecortada
						+ "...");
				}
			}
			if(!encontrado)
			{
				Console.WriteLine("No hay coincidencias");
			}
		}
		else
		{
			Console.WriteLine("No hay habitaciones almacenadas");                                                
		}
	}
	static void MostrarDatos(habitacion[] habitaciones, int i)
	{
		Console.WriteLine("Numero: " + 
		habitaciones[i].numero);
		Console.WriteLine("\tPrecio: " + 
		habitaciones[i].precio);
		Console.WriteLine("\tDescripción: " + 
		habitaciones[i].descripcion);
	}

    static void Main()
    {
        habitacion[] habitaciones = new habitacion[100];
        opciones opcionUsuario;
		int cantidad=0;
        do
        {
            opcionUsuario=MostrarMenu();
            switch (opcionUsuario)
            {
                case opciones.NUEVA:
                    NuevaHabitacion(habitaciones,ref cantidad);
                    break;

                case opciones.LISTADO:
					ListarHabitaciones(habitaciones,cantidad);
					break;
                    
                case opciones.BUSCAR:
					BuscarHabitacion(habitaciones,cantidad);
					break;
                    
                case opciones.FILTRAR:
                    FiltrarHabitaciones(habitaciones,cantidad);
                    break;
                case opciones.ORDENAR:
                    OrdenarHabitaciones(ref habitaciones,cantidad);
                    break;
                case opciones.AVANZADO:
                    BusquedaAvanzada(habitaciones,cantidad);
                    break;
                case opciones.SALIR:
					Console.WriteLine("Has elegido salir");
					break;
            }
            
            if (opcionUsuario != opciones.SALIR)
            {
                Console.WriteLine("Pulsa Intro para continuar...");
                Console.ReadLine();
                Console.Clear();
            }
        }
        while (opcionUsuario != opciones.SALIR);
    }
}
