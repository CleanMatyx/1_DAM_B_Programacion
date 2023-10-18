/*
 * Programa que pide al usuario su 'login' y su 'password'.
 * La contraseña la pide dos veces y en caso de no coincidir se vuelve a 
 * preguntar dos veces hasta que coincida.
 */
 
 using System;
 class Ejercicio_03c_04
{
	static void Main()
	{
		string login,password,rePassword;
		Console.WriteLine("Ingrese su cuenta: ");
		login=Console.ReadLine();
		do
		{
			Console.Write("Ingrese su contraseña: ");
			password=Console.ReadLine();
			Console.Write("Vuelva a ingresar su contraseña: ");
			rePassword=Console.ReadLine();
		}
		while (password!=rePassword);
		Console.WriteLine("Login correcto");
	}
}
