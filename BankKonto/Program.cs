using BankKonto;

BankAccount account = new BankAccount();

Console.WriteLine("Withdraw\nDeposit\nGetBalance");

while (true)
{

    switch (Console.ReadLine().ToLower())
    {
        case "withdraw":
            {
                Console.WriteLine("Withdraw amount:");
                int.TryParse(Console.ReadLine(), out int amount);
                account.withdraw(amount);
                break;
            }
        case "deposit":
            {
                Console.WriteLine("Deposit amount:");
                int.TryParse(Console.ReadLine(), out int amount);
                account.deposit(amount);
                break;
            }
        case "getbalance":
            {
                Console.WriteLine("Current balance: " + account.GetBalance());
                break;
            }
    }
}

//Console.WriteLine(account.GetBalance());
//account.deposit(100);
//Console.WriteLine(account.GetBalance());
//account.withdraw(50);
//Console.WriteLine(account.GetBalance());
//account.withdraw(100);
//Console.WriteLine(account.GetBalance());