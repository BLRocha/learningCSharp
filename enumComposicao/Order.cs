using System;
namespace dot.enumComposicao
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }

        public override string ToString()
        {
            return "ID: " + Id
                   + "\n"
                   + "Date: " + Moment
                   +"\n"
                   + "Status: " + Status;
        }
    }
}