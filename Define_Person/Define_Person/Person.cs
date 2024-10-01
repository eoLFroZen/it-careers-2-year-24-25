using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Person
{
    public class Person
    {
        private static int count;

        private string name;


        public Person(string name, int age)
        {
            Name = name;
            Age = age;
            count++;
        }

        public Person(string name, int age, List<BankAccount> accounts) : this(name, age)
        {
            BankAccounts = accounts;
        }

        public Person()
        {
            BankAccounts = new List<BankAccount>();
            count++;
        }

        public string Name
        {
            get; set;
        }

        public int Age
        {
            get;set;
        }

        public List<BankAccount> BankAccounts { get; set; }

        public static int Count { get { return count; } }

        public void IntroduceYourself()
        {
            Console.WriteLine($"My name is: {Name} and I am {Age} years old.");
        }

        public decimal GetBalance()
        {
            //decimal totalSum = 0;

            //for (int i = 0; i < BankAccounts.Count; i++)
            //{
            //    BankAccount bank = BankAccounts[i];

            //    totalSum += bank.Amount;
            //}

            //return totalSum;

            return BankAccounts.Sum(account => account.Balance);
        }

        public override string ToString()
        {
            return $"FROM TOSTRING() -> My name is: {Name} and I am {Age} years old.";
        }

        public static void StaticMethod()
        {
            Console.WriteLine("Hey");
        }
    }
}
