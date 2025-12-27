using System;

class Student
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public void GetName()
    {
        Console.WriteLine("Student Name: " + name);
    }
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.SetName("Amna");
        s.GetName();
    }
}
using System;

class Account
{
    private int balance;

    public int Balance
    {
        get { return balance; }
        set { balance = value; }
    }
}

class Program
{
    static void Main()
    {
        Account acc = new Account();
        acc.Balance = 5000;
        Console.WriteLine("Balance: " + acc.Balance);
    }
}
using System;

class Employee
{
    private int salary;

    public void SetSalary(int s)
    {
        salary = s;
    }

    public int GetSalary()
    {
        return salary;
    }
}

class Program
{
    static void Main()
    {
        Employee e = new Employee();
        e.SetSalary(30000);
        Console.WriteLine("Salary: " + e.GetSalary());
    }
}