namespace Two
{
    internal class BankAccount
    {
        private String accountNumber;
        private decimal balance;

        internal BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        internal void Deposit(decimal amount)
        {
            this.balance += amount;
        }

        internal void Withdraw(decimal amount)
        {
            this.balance -= amount;
        }

        static void Main(string[] args)
        {
            BankAccount acc = new("1234ABCD");
            acc.Deposit(100);
            acc.Withdraw(100);
            Console.WriteLine("The account number " + acc.accountNumber +" has balance: " + acc.balance);
        }
    }
}
