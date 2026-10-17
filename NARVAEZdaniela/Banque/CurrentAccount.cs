namespace Banque
{
    public class CurrentAccount
    {
        public string Number { get; set; } = string.Empty;
        public double Balance { get; private set;}
        public double CreditLine { get; set; }
        public Person Owner { get; set; } = new Person();

        public void Withdraw(double amount)         //retirer de l'argent
        {   
            if (amount <= 0)
            {
                throw new Exception("Le montant doit être positif");
            }

            if (Balance + CreditLine >= amount)
            {
                Balance -= amount;
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