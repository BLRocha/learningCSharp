using System.Globalization;

namespace dot.utl
{
    public class Account
    {
        private uint _number;
        private string _holder;
        private double _balance;

        public Account(uint number, string holder)
        {
            this._number = number;
            this._holder = holder;
        }

        public Account(uint number, string holder, double balance) : this(number, holder)
        {
            this._number = number;
            this._holder = holder;
            this._balance = balance;
        }
        

        public void Deposit(uint amount)
        {
            this._balance += amount;
        }
        public void Withdraw(uint amount)
        {
            this.Fee();
            this._balance -= amount;
        }

        protected void Fee()
        {
            this._balance -= 5.00;
        }

        public override string ToString()
        {
            return "Account number: " + this._number + "\n" +
                   "Houder: " + this._holder + "\n" +
                   "Balance: " + this._balance.ToString("F2",
                       CultureInfo.InvariantCulture);
        }
    }
}