using System;
internal class Program
{
    static void Main()
    {
        int numero1, numero2;
        {
            Console.Write("Ingresa el primer número: ");
            numero1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Ingresa el segundo número: ");
            numero2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("La suma de los cuadrados es: " + (numero1 * numero1 + numero2 * numero2));
        }
    }
}