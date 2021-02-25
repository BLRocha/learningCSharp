using System.Text;

namespace dot.entities.inheritance
{
    public class Account
    {
        public uint  Number { get; protected set; }
        public string Holder { get; protected set; }
        public double Balance { get; protected set; }
        public double Fee { get; protected set; }
        public Account(uint number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            Fee = 5.00;
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance >= amount)
            {
                Balance -= Fee;
                Balance -= amount;
            }
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Account Number: {Number}");
            sb.AppendLine($"Holder: {Holder}");
            sb.AppendLine($"Balance U$ {Balance}");
            return sb.ToString();
        }
    }
}