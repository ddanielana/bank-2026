namespace Banque
{
    public class SavingAccounts
    {
        public string Number { get; set; } = string.Empty;
        public double Balance { get; private set; }
        public DateTime DateLastWithdraw { get; set; }
        public Person Owner { get; set; } = new Person();

        public void Withdraw(double amount)       
        {
            if (amount <= 0)
            {
                throw new Exception("Le montant doit être positif");
            }

            if (Balance >= amount)
            {
                Balance -= amount;
                DateLastWithdraw = DateTime.Now;
            }
            else
            {
                throw new Exception("Fonds insuffisants");
            }
        }

        public void Deposit(double amount)
        {
            if (amount <= 0)
            {
                throw new Exception("Le montant doit être positif");
            }

            Balance += amount;
        }
    }
}