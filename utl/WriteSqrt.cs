using System;

namespace dot.utl
{
    interface Interfacee
    {
        void Txt();
        int sum(int a, int b);
    }
    public class WriteSqrt : Interfacee
    {
        public void SqrtOf()
        {
            int number;
            Console.Write("Digite um número: ");
            number = int.Parse(Console.ReadLine());
            while (number >= 0)
            {
                Console.WriteLine( Math.Pow(number, .5) );
                Console.Write("Digite um número: ");
                number = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Número negativo!");
        }

        public void Txt()
        {
            throw new NotImplementedException();
        }

        public void SqrtOf2()
        {
            double number;
            do
            {
                Console.Write("Digite um número: ");
                number = double.Parse(Console.ReadLine());
                Console.WriteLine(number < 0.0 ? "" : Math.Pow(number, .5));
            } while (number >= 0.0);
            Console.WriteLine("Número negativo!");
        }

        public int sum(int a, int b)
        {
            return a + b;
        }
    }
}