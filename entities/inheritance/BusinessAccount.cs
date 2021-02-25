using System.Text;

namespace dot.entities.inheritance
{
    public class BusinessAccount : Account
    {
        public double LoanLimit { get; set; }
        
        public BusinessAccount(uint number, string holder, double balance, double loanLimit) : base(number, holder, balance)
        {
            LoanLimit = loanLimit;
        }
        
        public void Loan(double amount)
        {
            if (amount <= LoanLimit)
            {
                LoanLimit -= amount;
                Balance += amount;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Account Number: {Number}");
            sb.AppendLine($"Holder: {Holder}");
            sb.AppendLine($"Balance U$ {Balance}");
            sb.AppendLine($"Loan Limit: {LoanLimit}");
            return sb.ToString();
        }
    }
}