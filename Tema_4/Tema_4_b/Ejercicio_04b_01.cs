/*
 * Programa que pide almacenar datos en 'struct' de un mp3:
 * Artista, título, duración y tamaño en kb.
 * Luego los muestra en pantalla.
 */
 
 using System;
 class Ejercicio_04b_01
{
    struct datosMp3
    {
        public string artista;
        public string titulo;
        public int duracion;
        public int tamaño;
    }
    static void Main()
    {
		datosMp3 datos;
		Console.WriteLine("Ingrese nombre de Artista:");
		datos.artista=Console.ReadLine();
		Console.WriteLine("Ingrese nombre de canción:");
		datos.titulo=Console.ReadLine();
		Console.WriteLine("Ingrese duración:");
		datos.duracion=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Ingrese tamaño archivo en kb:");
		datos.tamaño=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine();
		Console.WriteLine("Artista: "+datos.artista+"\n"
			+"Título: "+datos.titulo+"\n"+"Duración: "+datos.duracion+
			" segundos\n"+"Tamaño en kb: "+datos.tamaño+"kb");
	}
}
