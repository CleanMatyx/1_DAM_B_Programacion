/*
 * Programa para calcular la nota del primer trimestre.
 * Pedirá el número de prácticas realizadas y las notas de los dos exámenes.
 * La nota final es el 70% de los exámenes y el 30% de las prácticas.
 * 
 */
 
 using System;
 class Practica_3_1
 {
	static void Main()
	{
		int practicas;
		double nota,notaSum=0,notaExam1,notaExam2,pracMedia,examMedia,
			notaFinal=0;
			
		Console.Write("Introduce el número de prácticas realizadas: ");
		practicas=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Introduce la nota de tus {0} prácticas",practicas);
		for(int i=1;i<=practicas;i++)
		{
			nota=0;
			nota=Convert.ToInt32(Console.ReadLine());
			notaSum+=nota;
		}
		Console.Write("Nota del primer examen: ");
		notaExam1=Convert.ToSingle(Console.ReadLine());
		Console.Write("Nota del segundo examen: ");
		notaExam2=Convert.ToSingle(Console.ReadLine());
		pracMedia=notaSum/practicas;
		examMedia=(notaExam1+notaExam2)/2;
		notaFinal=examMedia*0.7+pracMedia*0.3;
		if(pracMedia<4||examMedia<4)
			Console.WriteLine("Tu nota final es {0}",
				Math.Min(4,notaFinal).ToString("N2"));
		else
			Console.WriteLine("Tu nota final es {0}",notaFinal.ToString("N2"));
	}
}
