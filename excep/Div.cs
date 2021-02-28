using System;

namespace dot.excep
{
    public class Div
    {
        public int D()
        {
            try
            {
                Console.Write("Digite um números: ");
                int n1 = int.Parse(Console.ReadLine());
                Console.Write("Digite outro números: ");
                int n2 = int.Parse(Console.ReadLine());
                return n1 / n2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            finally
            {
                Console.WriteLine("Sempre Exec...");
            }
        }
    }
}