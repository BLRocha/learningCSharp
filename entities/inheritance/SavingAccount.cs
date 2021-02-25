using System.Text;

namespace dot.entities.inheritance
{
    public class SavingAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingAccount(uint number, string holder, double balance, double interestRate) : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Account Number: {Number}");
            sb.AppendLine($"Holder: {Holder}");
            sb.AppendLine($"Balance U$ {Balance:F2}");
            sb.AppendLine($"Interest Rate: {InterestRate}");
            return sb.ToString();
        }
    }
}