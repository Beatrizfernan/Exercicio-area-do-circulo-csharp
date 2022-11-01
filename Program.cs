using System;
using System.Globalization;

namespace enercicio_raio_circulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o o raio do círculo");

            double R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


            double pi = 3.14159;

            double A = pi * Math.Pow(R, 2);
            Console.WriteLine("Área=" + A.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}
