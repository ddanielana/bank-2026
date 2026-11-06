namespace Banque
{
    public class SavingsAccount : Account
    {
        public DateTime DateLastWithdraw { get; set; }
    
        public override void Withdraw(double amount)       
        {
            if (amount > Balance)
            {
                throw new Exception("Fonds insuffisants");
            }
            base.Withdraw(amount);

            DateLastWithdraw = DateTime.Now;
        }

    }
}