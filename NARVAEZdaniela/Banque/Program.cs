using Banque;

Bank bank = new Bank
{
    Name = "BelIng"
};

Person person1 = new Person
{
    FirstName = "Deissy",
    LastName = "Narvaez",
    BirthDate = new DateTime(1995, 10, 29)
};

Person person2 = new Person
{
    FirstName = "Daniela",
    LastName = "Pesantez",
    BirthDate = new DateTime(2000, 10, 31)
};

IBankAccount cAccount1 = new CurrentAccount
{
    Number = "B12345",
    Owner = person1,
    CreditLine = 500,
};

IBankAccount cAccount2 = new CurrentAccount
{
    Number = "B67890",
    Owner = person2,
    CreditLine = 1000
};

IBankAccount sAccount1 = new SavingsAccount
{
    Number = "B00125",
    Owner = person1,
};

bank.AddAccount(cAccount1);
bank.AddAccount(cAccount2);    
bank.AddAccount(sAccount1);

cAccount1.Deposit(300);
cAccount2.Deposit(500);
sAccount1.Deposit(80);

cAccount2.Withdraw(100);
sAccount1.Withdraw(30);

cAccount1.ApplyInterest();
Console.WriteLine($"Le solde du compte courant de {cAccount1.Owner.FirstName} est : {cAccount1.Balance}");

cAccount2.ApplyInterest();
Console.WriteLine($"Le solde du compte courant de {cAccount2.Owner.FirstName} est : {cAccount2.Balance}");

sAccount1.ApplyInterest();
Console.WriteLine($"Le solde du compte d'épargne de {sAccount1.Owner.FirstName} est : {sAccount1.Balance}");

Console.WriteLine($"Total de {person1.FirstName}: {bank.TotalBalance(person1)}");
Console.WriteLine($"Total de {person2.FirstName}: {bank.TotalBalance(person2)}");

Console.WriteLine("Test: Fonds insuffisants");
try
{
    sAccount1.Withdraw(10000);
}
catch (Exception x)
{
    Console.WriteLine($"Error: {x.Message}");
}

Console.WriteLine("Test: Numéro de compte déjà existant");
try
{
    bank.AddAccount(cAccount1);
}
catch (Exception x)
{
    Console.WriteLine($"Error: {x.Message}");
}

Console.WriteLine("Test: Suppression d'un compte inexistant");
try
{
    bank.DeleteAccount("B28465");
}
catch (Exception x)
{
    Console.WriteLine($"Error: {x.Message}");
}