namespace Banque
{
    public class CurrentAccount : Account
    {
        public double CreditLine { get; set; }

        public CurrentAccount(string number, Person person) : base(number, person) { }

        public CurrentAccount(string number, Person person, double initialBalance) : base (number, person, initialBalance) { }

        public override void Withdraw(double amount)         //retirer de l'argent
        {   
            if (Balance + CreditLine < amount)
            {
               throw new Exception("Fonds insuffisants");
            }
            base.Withdraw(amount);
        }

        protected override double CalculInterets()
        {
            if (Balance > 0)
            {
                return Balance * 0.03; // 3% d'intérêt pour les soldes positifs
            }
            else
            {
                return Balance * 0.0975; // 9.75% d'intérêt pour les soldes négatifs
            }
        }
    }
}
