

using System;
class Ejercicio_03a_02
{
	static void Main()
	{
		int a,b,c;
		a=b=c=5;	//a=5,b=5,c=5
		b=a+2;		//a=5,b=7,c=5
		b-=3;		//a=5,b=4,c=5
		c=-3;		//a=5,b=4,c=-3
		c*=2;		//a=5,b=4,c=-6
		++c;		//a=5,b=4,c=-5
		a*=b;		//a=20,b=4,c=-5
		Console.WriteLine(a);
		Console.WriteLine(b);
		Console.WriteLine(c);
	}
}
