namespace headerSpace;

public abstract class Adam {
    public Guid GUID { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; } 
} 
public interface IOperate {
    void AddOperation();
    void RemoveOperation();
    void EditOperation();
}
public abstract class Isci : Adam {
    public string Position{get;set;}
    public abstract void Control();
}
public class CEO : Isci {
    public override void Control() 
    {
        Console.WriteLine("CEO is controlling");
    }
    public void Organize()
    {
        Console.WriteLine("CEO is organizing");
    }

    public void MakeMeeting()
    {
        Console.WriteLine("CEOnun gorusu var");
    }
    public void DecreasePercentage(double percent)
    {
        Console.WriteLine($"CEO faizi azaltdi: {percent}%.");
    }
}
public class Worker: Isci,IOperate {
    public void AddOperation() {
        Console.WriteLine("Worker is adding Operation");
    }
    public void EditOperation() {
        Console.WriteLine("Worker is editig the operation");
    }
    public void RemoveOperation() {
        Console.WriteLine("Worker is removing the operaiton");
    }
    public override void Control() {
        Console.WriteLine("Worker is controlling");
    }
}
public class Manager : Isci {
    public override void Control()
    {
        Console.WriteLine("Manager controlles");
    }

    public void Organize()
    {
        Console.WriteLine("Manager organizes");
    }

    public void CalculateSalaries()
    {
        Console.WriteLine("Manager calculatezz");
    }
}
public class Operation
{
    public Guid GUID { get; set; }
    public string NameProcess { get; set; }
    public DateTime Datetime { get; set; }
}
public class Credit {
    public Guid GUID { get; set; }
    public Client Client { get; set; }
    public double Amount { get; set; }
    public double Percent { get; set; }
    public int Months { get; set; }

    public double CalculatePercentOfCredit()
    {
        return 2.0;
    }
    public double CalculatePayment()
    {
        return 55.90;
    }
}
public class Client : Adam {
    public string address{get;set;}
    public string work_address {get;set;}
}

public class Bank {
    public string name {get;set;}
    public double budget{get;set;}
    public double profit{get;set;}
    public CEO ceo {get;set;}
    public List<Worker>workers {get;set;} = new List<Worker>();
    public List<Manager>managets {get;set;} = new List<Manager>();
    public List<Client>clients {get;set;} = new List<Client>();

    public double calculate_profit() {
        return profit;
    }
    public void showClientCredit(string fullname) {
        Console.WriteLine(fullname + "'s credits");
    }
    public void payCredit(Client cl, double money) {
        Console.WriteLine($"{money}$ paid by {cl.Name + " " + cl.Surname}");
    }
    public void showAllCredits() {
        Console.WriteLine("All credits here");
    }

}