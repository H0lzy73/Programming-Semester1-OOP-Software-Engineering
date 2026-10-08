Customer customer1 = new Customer("Tim", 001, 128.54);
Customer customer2 = new Customer("George", 002, 62.32);
Customer customer3 = new Customer("Amir", 003, 12.13);
/*
Console.WriteLine(customer1.GetBalance());
customer1.Deposit(100.57);
Console.WriteLine(customer1.GetBalance());
customer1.Withdraw(4000);
Console.WriteLine(customer1.GetBalance());
*/

CustomerDatabase Database1 = new CustomerDatabase();
Database1.NewCustomer(customer1);
Database1.NewCustomer(customer2);
Database1.NewCustomer(customer3);
Console.WriteLine("Done");

Database1.AllCustomers();

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

    public int GetId()
    {
        return id;
    }
}

public class CustomerDatabase
{
    Customer[] customers;
    int count = 0;

    public CustomerDatabase()
    {
        customers = new Customer[10];
    }

    public void NewCustomer(Customer customerObject)
    {
        if (count < customers.Length)
        {
            customers[count] = customerObject;
            count++;
            Console.WriteLine("New Customer!!!");
        }
        else
        {
            Console.WriteLine("Database is full!");
        }
    }

    public void CustomerSearch(int id1)
    {
        for (int i = 0; i < count; i++)
        {
            if (customers[i].GetId() == id1)
            {
                Console.WriteLine(customers[i]);
                return;
            }
        }

        Console.WriteLine("Customer not found.");
    }
    /*
    public override string ToString()
    {
        return $"Name: {name}, ID: {id}, Balance: {balance}";
    }
    */
    public void AllCustomers()
    {
        for (int i = 0; i < count; i++)
            Console.WriteLine(customers[i]);
    }
}
/*
public class CustomerDatabase {

    Customer[] customers;

    public CustomerDatabase()
    {
        customers = new Customer[10];
    }


    public string NewCustomer(CustomerObjekt)
    {
        customers.Add(CustomerObjekt);
        return "New Customer!!!";
    }

    public string CustomerSearch(int id1)
    {
        for (int i = 0; i<customers.Length; i++) 
        {
            Console.WriteLine(customers[i]);
            
        }
    }
}*/






MyMethod(child1: child 2);


statis void MyMethod();
ghedw