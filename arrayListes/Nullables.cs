using System;

namespace dot.arrayListes
{
    public class Nullables
    {
        
        // public double A = null;
        // public Nullable<double> B = null;
        public double? C = null;
        public double? D = 88.00;

        public Nullables()
        {
            Console.WriteLine(C.GetValueOrDefault());
            Console.WriteLine(D.GetValueOrDefault());
        }
    }
}
