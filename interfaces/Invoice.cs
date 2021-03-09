using System.Text;

namespace dot.interfaces
{
    public class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Basic payment: ");
            sb.AppendLine($"{BasicPayment:F2}");
            sb.AppendLine($"Tax: {Tax:F2}");
            sb.AppendLine($"Total payment: {TotalPayment:F2}");
            return sb.ToString();
        }
    }
}