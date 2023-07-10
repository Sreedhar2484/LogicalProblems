using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace OopsProblems
{
     class BankAccount
    {
        private int Amount;
        public int GetAmount
        {
            get { return Amount; }
            set { Amount = value; }

        }
    }
    class Abstraction
    {
        public abstract class IBank
        {
            public abstract void AccountNumber();
            public abstract void AddMoney();
            public abstract void WithdrawMoney();
        }
        class BankAccount : IBank
        {
            public override void AccountNumber()
            {
                throw new NotImplementedException();
            }

            public override void AddMoney()
            {
                throw new NotImplementedException();
            }

            public override void WithdrawMoney()
            {
                throw new NotImplementedException();
            }
        }
    }
    public class MethodOverloading
    {
        public void Showing(int a, int b)
        {
            Console.WriteLine(a + b+" in parentClass");
        }
        public void Showing(float a, float b)
        {
            Console.WriteLine(a + b + " in parentClass");
        }
    }
    class Child : MethodOverloading
    {
        public void Showing(int a, int b)
        {
            Console.WriteLine(a + b + " in parentClass");
        }
    }
   public class Encapsulation
    {
        public int Balance;
        public int setAmount(int Balance)
        {
            return Balance;
        }
        public void getAmount()
        {
            this.Balance = Balance;
        }
        public void ShowDetails()
        {
            Console.WriteLine("Balance is : " + Balance);
        }
    }
    public abstract class IAbstractionDemo
    {
        public string Name;
        public IAbstractionDemo(string Name)
        {
            this.Name = Name;
        }
        public abstract void Show();
    }
    public class Student : IAbstractionDemo
    {
        public Student(string Name) : base( Name)
        {

        }
        public override void Show()
        {
            Console.WriteLine("Name is : " + Name);
        }
    }
    interface ITestInterface1
    {
        void Add(int num1, int num2);
    }

    public class ImplementationClass : ITestInterface1
    {
        //Interface Method Implementation
        public void Add(int num1, int num2)
        {
            Console.WriteLine($"Sum of {num1} and {num2} is {num1 + num2}");
        }
        //This method purely belongs to ImplementationClass
        public void Sub(int num1, int num2)
        {
            Console.WriteLine($"Divison of {num1} and {num2} is {num1 - num2}");
        }
    }
}
