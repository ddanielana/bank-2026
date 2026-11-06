namespace Banque
{
    public class Bank
    {
        public Dictionary<string, Account> Accounts { get; private set; }= new Dictionary<string, Account>();
        public string Name { get; set; } = string.Empty;

        public void AddAccount(Account account)
        {
            if (Accounts.ContainsKey(account.Number))
            {
                throw new Exception("Le compte existe déjà");
            }
            Accounts.Add(account.Number, account);
        }

        public void DeleteAccount(string number)
        {
            if (!Accounts.ContainsKey(number))
            {
                throw new Exception("Le compte n'existe pas");
            }
            Accounts.Remove(number);
        }

        public double TotalBalance(Person owner)
        {
            double totalBalance = 0;
            foreach (var account in Accounts.Values)
            {
                if (account.Owner == owner)
                {
                    totalBalance += account.GetBalance();
                }
            }
            return totalBalance;
        }
    }
}