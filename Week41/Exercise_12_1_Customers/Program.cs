Customer customer1 = new Customer("Tim", 001, 128.54);
Console.WriteLine(customer1.GetBalance());
customer1.Deposit(100.57);
Console.WriteLine(customer1.GetBalance());
customer1.Withdraw(4000);
Console.WriteLine(customer1.GetBalance());


public class Customer {
    string name;
    int id;
    double balance;

    public Customer(string setName, int setId)
    {
        name = setName;
        id = setId;
        balance = 0;
    }

    public Customer(string setName, int setId, double setBalance)
    {
        name = setName;
        id = setId;
        balance = setBalance;
    }

    public void Deposit(double amount)
    {
        balance+=amount;
    }

    public void Withdraw(double amount)
    {
        if (balance>amount) {
            balance-=amount;
        }
        else
        {
            Console.WriteLine("Error");
        };
    }

    public double GetBalance() 
    {
        return balance;
    }
}