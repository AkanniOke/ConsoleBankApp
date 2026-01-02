using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Account> accounts = new List<Account>();
        accounts.Add(new Account("Akanni", 5000));

        Console.WriteLine("Welcome to Console Bank App!");
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();

        Account acc = accounts.Find(a => a.Name == name);
        if (acc == null)
        {
            Console.WriteLine("Account not found.");
            return;
        }

        Console.WriteLine($"Hello {acc.Name}, your balance is {acc.Balance:C}");
        Console.WriteLine("Enter amount to deposit:");
        double deposit = Convert.ToDouble(Console.ReadLine());
        acc.Deposit(deposit);
        Console.WriteLine($"New balance: {acc.Balance:C}");
    }
}

class Account
{
    public string Name { get; set; }
    public double Balance { get; private set; }

    public Account(string name, double balance)
    {
        Name = name;
        Balance = balance;
    }

    public void Deposit(double amount)
    {
        Balance += amount;
    }
}
