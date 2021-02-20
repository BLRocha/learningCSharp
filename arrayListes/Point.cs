using System;

namespace dot.arrayListes
{
    public struct Radius
    {
        private static double _pi = 3.14;
        public double R;

        public override string ToString()
        {
            return "Raio: " + _pi * Math.Pow(R, 2);
        }
    }
}
