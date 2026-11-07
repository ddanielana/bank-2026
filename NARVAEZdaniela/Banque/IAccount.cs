namespace Banque
{
    public interface IAccount
    {
        double GetBalance();
        void Deposit(double amount);
        void Withdraw(double amount);
    }
}