using System;

namespace dot.exercises
{
    public class Payfee
    {
        public int ContarctNumber { get; set; }
        public DateTime Date { get; set; }
        public double ContractValue { get; set; }
        public int Parcel { get; set; }

        private DateTime t = DateTime.Parse("25/06/2018");

        public void AddMount(int ttM)
        {
            for (int i = 1; i < ttM; i++)
            {
                t.Date.AddMonths(i);
                Console.WriteLine(t);
            }
        }
    }
}