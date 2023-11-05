/*
 * Programa de cáculo de ganancias en apuesta plataforma 'switch'
 * 
 */
 
using System;
class Betting
{
    static void Main()
    {
        double a;
        a=Convert.ToInt32(Console.ReadLine());
        if(a>0&&a<100)
        {
            Console.WriteLine(100/a);
            Console.WriteLine(100/(100-a));
        }
    }
}
