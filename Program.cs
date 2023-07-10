using OopsProblems;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        BankAccount myAcc = new BankAccount();
        myAcc.GetAmount = 123;
        Console.WriteLine(myAcc.GetAmount);

        BankAccount newAcc = new BankAccount();
        Child child = new Child();
        child.Showing(4, 5);
        Encapsulation myObj = new Encapsulation();
        myObj.setAmount(1450);
        myObj.getAmount();

        Student myStu = new Student("Nagalli");
        myStu.Show();

        ImplementationClass myClass = new ImplementationClass();
        myClass.Add(1, 45);
        myClass.Sub(78, 754);
       
    }
}