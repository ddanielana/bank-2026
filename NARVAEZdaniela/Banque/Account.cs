namespace Banque
{
    public abstract class Account : IAccount
    {
        public string Number { get; set; } = string.Empty;
        public double Balance { get; private set; }
        public Person Owner { get; set; } = new Person();

        public virtual void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Le montant doit être positif");
            }

            Balance += amount;
        }

        public virtual void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Le montant doit être positif");
            }
            Balance -= amount;
        }

        public double GetBalance()
        {
            return Balance;
        }

        protected abstract double CalculInterets();

        public void ApplyInterest()
        {
            Balance += CalculInterets();
        }
    }
}


