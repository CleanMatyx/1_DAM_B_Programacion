/* 
 * Programa que gestiona un array de habitaciones de hotel. Permite añadir
 * habitaciones, buscarlas, filtrar por precio, etc.
 */
 
using System;

class Practica4
{
    enum opciones  { SALIR, NUEVA, LISTADO, BUSCAR, FILTRAR, ORDENAR,
			BUSCAR_AVANZADA}

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

    static void Main()
    {
        habitacion[] habitaciones = new habitacion[100];
        int cantidad = 0, numHabitacion;
        opciones opcionUsuario;
        string preguntaWiFi;
        bool encontrado;
        float filtroPrecio;

        do
        {
            Console.WriteLine("1. Añadir habitación");
            Console.WriteLine("2. Ver listado de habitaciones");
            Console.WriteLine("3. Buscar habitaciones");
            Console.WriteLine("4. Filtrar habitaciones");
            Console.WriteLine("5. Ordenar habitaciones");
            Console.WriteLine("6. Búsqueda avanzada");
            Console.WriteLine("0. Salir del programa");
            Console.WriteLine("Elige una opción:");

            opcionUsuario = (opciones)Convert.ToInt32(Console.ReadLine());

            switch (opcionUsuario)
            {
                case opciones.NUEVA:
                    if (cantidad < habitaciones.Length)
                    {
                        Console.WriteLine("Número de habitación:");
                        numHabitacion = Convert.ToInt32(Console.ReadLine());
                        encontrado = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (habitaciones[i].numero == numHabitacion)
                            {
                                Console.WriteLine("Habitación ya existente");
                                encontrado = true;
                            }
                        }
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
                            habitaciones[cantidad].descripcion = 
                                Console.ReadLine();

                            Console.WriteLine("WiFi (S/N):");
                            preguntaWiFi = Console.ReadLine();
                            if (preguntaWiFi == "S" || preguntaWiFi == "s")
                            {
                                habitaciones[cantidad].servicios.wifi = true;
                            }
                            else
                            {
                                habitaciones[cantidad].servicios.wifi = false;
                            }
                            cantidad++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No caben más habitaciones");
                    }
                    break;

                case opciones.LISTADO:
                    if (cantidad > 0)
                    {
                        for (int i = 0; i < cantidad; i++)
                        {
                            Console.WriteLine("Numero: " + 
                                habitaciones[i].numero);
                            Console.WriteLine("\tPrecio: " + 
                                habitaciones[i].precio+" Euros");
                            Console.WriteLine("\tDescripción: " + 
                                habitaciones[i].descripcion);
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay habitaciones almacenadas");
                    }
                    break;
                    
                case opciones.BUSCAR:
                    if (cantidad > 0)
                    {
                        Console.WriteLine("Número de la habitación a buscar:");
                        numHabitacion = Convert.ToInt32(Console.ReadLine());
                        encontrado = false;
                        for (int i = 0; i < cantidad; i++)
                        {
                            if (habitaciones[i].numero == numHabitacion)
                            {
                                Console.WriteLine("Numero: " + 
                                    habitaciones[i].numero);
                                Console.WriteLine("Precio: " + 
                                    habitaciones[i].precio+" Euros");
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
                    break;
                    
                case opciones.FILTRAR:
                    if(cantidad > 0)
                    {
                        Console.WriteLine("Dime un precio máximo:");
                        filtroPrecio = Convert.ToSingle(Console.ReadLine());

                        for (int i = 0; i < cantidad; i++)
                        {
                            if (filtroPrecio >= habitaciones[i].precio)
                            {
                                Console.WriteLine("Numero: " + 
                                    habitaciones[i].numero);
                                Console.WriteLine("\tPrecio: " + 
                                    habitaciones[i].precio+" Euros");
                                Console.WriteLine("\tDescripción: " + 
                                    habitaciones[i].descripcion);
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("No hay habitaciones almacenadas");
                    }
                    break;
                case opciones.ORDENAR:
					if(cantidad > 0)
					{
						for (int i = 0; i < cantidad - 1; i++)
						{
							for (int j = i+1; j < cantidad; j++)
							{
								if (habitaciones[i].precio > 
									habitaciones[j].precio)
								{
									habitacion habitacionAuxiliar 
										= habitaciones[i];
									habitaciones[i] = habitaciones[j];
									habitaciones[j] = habitacionAuxiliar;
								}
							}
						}
						for (int i = 0; i <=2 ; i++)
						{
							if(habitaciones[i].precio>0)
							{
								Console.WriteLine("Numero: " + 
									habitaciones[i].numero);
								Console.WriteLine("\tPrecio: " + 
									habitaciones[i].precio+"Euros");
								Console.WriteLine("\tDescripción: " + 
									habitaciones[i].descripcion);
							}
                        }
					}
					else
                    {
                        Console.WriteLine("No hay habitaciones almacenadas");
                    }
                    break;
                case opciones.BUSCAR_AVANZADA:
					if(cantidad > 0)
					{
						Console.WriteLine("Ingrese texto a buscar: ");
						string textoBuscar=Console.ReadLine();
						for(int i=0;i<cantidad;i++)
						{
							int pos=habitaciones[i].descripcion.ToLower().
								IndexOf(textoBuscar.ToLower());
							if (pos!=-1)
							{
								int inicio=Math.Max(0,pos-10);
								int fin=Math.Min(habitaciones[i].
									descripcion.Length,pos
									+textoBuscar.Length+10);
								string resultado=habitaciones[i].
									descripcion.Substring(inicio,fin-inicio);
								Console.WriteLine("Numero: " + 
									habitaciones[i].numero);
								Console.WriteLine("\tPrecio: " + 
									habitaciones[i].precio+"Euros");
								Console.WriteLine("\tDescripción: " + 
									habitaciones[i].descripcion);
								if(inicio==0)
									Console.WriteLine(resultado+"...");
								else if(fin==habitaciones[i].descripcion.Length)
									Console.WriteLine("..."+resultado);
								else
									Console.WriteLine("..."+resultado+"...");
							}	
						}
					}
					else
                    {
                        Console.WriteLine("No hay habitaciones almacenadas");
                    }
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
