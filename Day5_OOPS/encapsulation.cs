using System;

BankAccount myAccount = new BankAccount();
myAccount.Deposit(1000);
Console.WriteLine($"Current Balance: {myAccount.Balance}");

public class BankAccount
{
    // 1. Private field 
    private decimal _balance;

    // 2. Public Property 
    public decimal Balance
    {
        get { return _balance; }
        private set { _balance = value; } 
    }

    // Method to change data safely
    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            _balance += amount;
            Console.WriteLine($"Deposited: {amount}");
        }
        else
        {
            Console.WriteLine("Invalid amount!");
        }
    }
}