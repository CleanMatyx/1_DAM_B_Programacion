/*
 * Programa con función 'MensajeSecreto' que recibe dos 'string' 't1' y 't2'.
 * Devolverá un 'bool' si 't2' está dentro de 't1'.
 */
 
using System;
class Repaso3_4
{
	static bool MensajeSecreto(string t1, string t2)
	{
		bool fin=false;
		int i1=0,i2=0;
		while(i1<t1.Length&&i2<t2.Length)
		{
			if(t1[i1]==t2[i2])
			{
				i1++;
				i2++;
			}
			else
				i1++;
		}
		if(i2==t2.Length)
			fin=true;
		
		return fin;
	}
	
	static void Main()
	{
		bool fin;
		string t1,t2;
		t1="habia una vez un circo que alegraba siempre el corazon.";
		t2="buenas.";
		fin=MensajeSecreto(t1,t2);
		if(fin)
			Console.WriteLine("Sí existe en el texto.");
		else
			Console.WriteLine("No existe en el texto.");
	}
}
