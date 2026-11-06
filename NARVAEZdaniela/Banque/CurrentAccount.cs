namespace Banque
{
    public class CurrentAccount : Account
    {
        public double CreditLine { get; set; }

        public override void Withdraw(double amount)         //retirer de l'argent
        {   
            if (Balance + CreditLine < amount)
            {
               throw new Exception("Fonds insuffisants");
            }
            base.Withdraw(amount);
        }
    }
}
