using System;

namespace dot.utl
{
    public class Circle
    {
        protected static double PI = 3.14;
        public double Raio;

        public double Area()
        {
            return PI * Math.Pow(Raio, 2);
        }
        
        public double Diameter()
        {
            return 2 * Raio;
        }

        public double Circunference()
        {
            return 2 * PI * Raio;
        }
    }
}