/*
 * Programa del Ejercicio_04b_03 descomponiendo sus opciones en diferentes
 * fuciones.
 */
using System;
class Ejercicio_05a_12
{
	enum opciones{NUEVO_FINAL=1,MOSTRAR_TODO,BUSCAR_ARTISTA,SALIR}
	
	struct datosMp3
    {
        public string artista;
        public string titulo;
        public duracionCancion duracion; 
        public int tamaño;
    }
    struct duracionCancion
    {
		public int minutos;
		public int segundos;
	}
	
	static opciones Menu()
	{
		opciones opcionUsuario;
		Console.WriteLine("Elije una opción:");
		Console.WriteLine("1. Añadir una canción al final");
		Console.WriteLine("2. Mostrar los títulos de todas las canciones");
		Console.WriteLine("3. Buscar canciones de un artista determinado");
		Console.WriteLine("4. Salir");
		opcionUsuario=(opciones)Convert.ToInt32(Console.ReadLine());
		return opcionUsuario;
	}
	
	static void NuevaCancion(datosMp3[] datos,ref int cantidad)
	{
		if (cantidad<datos.Length)
		{
			Console.WriteLine("Ingrese nombre de Artista:");
			datos[cantidad].artista=Console.ReadLine();
			Console.WriteLine("Ingrese nombre de canción:");
			datos[cantidad].titulo=Console.ReadLine();
			Console.WriteLine("Ingrese minutos de duración:");
			datos[cantidad].duracion.minutos=
				Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ingrese segundos:");
			datos[cantidad].duracion.segundos=
				Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Ingrese tamaño archivo en kb:");
			datos[cantidad].tamaño=
				Convert.ToInt32(Console.ReadLine());
			cantidad++;
		}
		else
			Console.WriteLine("La lista está llena!!");
	}
	
	static void MostrarTitulos(datosMp3[] datos, int cantidad)
	{
		Console.WriteLine("Listado actualizado de canciones:");
		for(int i=0;i<cantidad;i++)
		{
			Console.WriteLine("Artista: "+datos[i].artista+"\n"
			+"Título: "+datos[i].titulo+"\n"+"Duración: "
			+datos[i].duracion.minutos+" minutos y"
			+datos[i].duracion.segundos+" segundos\n"
			+"Tamaño en kb: "+datos[i].tamaño+"kb");
		}
		Console.WriteLine("Pulsa intro para continuar...");
		Console.ReadLine();
		Console.Clear();
	}
	
	static void BuscarArtista(datosMp3[] datos,int cantidad)
	{
		bool end=false;
		if(cantidad>0)
		{
			Console.WriteLine("Ingrese nombre de Artista:");
			string nombreArtista=Console.ReadLine();
			for(int i=0;i<cantidad;i++)
			{
				if(datos[i].artista==nombreArtista)
				{	
					Console.WriteLine("Título: "
					+datos[i].titulo);
					Console.WriteLine();
					end=true;
				}
			}
			if(!end)
				Console.WriteLine("No hay temas del artista");
			Console.WriteLine("Pulsa intro para continuar...");
			Console.ReadLine();
			Console.Clear();
		}
		else
		Console.WriteLine("No hay elementos para mostrar");
	}
    
	static void Main()
	{
		datosMp3[]datos=new datosMp3[100];
		
		int cantidad=0;
		opciones opcionUsuario;
		do
		{	
			opcionUsuario=Menu();
			
			switch (opcionUsuario)
			{
				case opciones.NUEVO_FINAL:
				{
					NuevaCancion(datos,ref cantidad);
					break;
				}
				case opciones.MOSTRAR_TODO:
				{
					MostrarTitulos(datos,cantidad);
					break;
				}
				case opciones.BUSCAR_ARTISTA:
				{
					BuscarArtista(datos,cantidad);
					break;
				}
				case opciones.SALIR:
					Console.WriteLine("Has elegido salir");
					break;
			}
		}
		while(opcionUsuario!=opciones.SALIR);
	}
}

