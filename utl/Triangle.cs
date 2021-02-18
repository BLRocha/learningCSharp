using System;
using System.Globalization;

namespace dot.utl
{
    public class Triangle
    {
        public double A, B, C;

        public Triangle(string n) {
            Console.WriteLine($"Entre com os valores de {n}: ");
            this.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            this.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        
        public double area()
        {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt( p * (p - A) * (p - B) * (p - C) );
        }
    }
}