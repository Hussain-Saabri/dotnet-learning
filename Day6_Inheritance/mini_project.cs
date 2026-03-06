using System;

class BankAccount
{
    private string name;
    private int accountNumber;
    private double balance;

    // Constructor
    public BankAccount(string name, int accNo, double balance)
    {
        this.name = name;
        this.accountNumber = accNo;
        this.balance = balance;
    }

    public void Deposit(double amount)
    {
        balance += amount;
        Console.WriteLine("Amount Deposited: " + amount);
    }

    public void Withdraw(double amount)
    {
        
        if (amount > balance )
        {
            Console.WriteLine("Insufficient Balance");
        }
        else
        {
            balance -= amount;
            Console.WriteLine("Amount Withdrawn: " + amount);
        }
    }

    public void CheckBalance()
    {
        Console.WriteLine("Current Balance: " + balance);
    }
    public void checkAccount() {
        Console.WriteLine("Account Number: " + accountNumber);
        Console.WriteLine("Account Holder Name: " + name);
    }
}

class Program
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount("Hussain Saabri", 12335556, 1000);

        int choice;

        do
        {
            Console.WriteLine("\n---- Bank Menu ----");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Check Balance");
            Console.WriteLine("4. Check Account Details");
            Console.WriteLine("5. Exit");

            Console.Write("Enter your choice: ");
            choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.Write("Enter amount to deposit: ");
                    double dep = Convert.ToDouble(Console.ReadLine());
                    account.Deposit(dep);
                    break;

                case 2:
                    Console.Write("Enter amount to withdraw: ");
                    double wit = Convert.ToDouble(Console.ReadLine());
                    if(wit%100 != 0){
                        Console.WriteLine("Amount should be in multiple of 100");
                        break;
                        
                    }else{
                        account.Withdraw(wit);
                    }
                    

                    break;

                case 3:
                    account.CheckBalance();
                    break;

                case 4:
                    account.checkAccount();
                    break;
                case 5:
                    Console.WriteLine("Thank you!");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

        } while (choice != 5);
    }
}