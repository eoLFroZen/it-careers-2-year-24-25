using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Person
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            Console.WriteLine(person.ToString());
            person.Name = "Galin";
            person.Age = 28;

            person.IntroduceYourself();

            BankAccount account = new BankAccount();
            account.Balance = 20;
            person.BankAccounts.Add(account);

            BankAccount account2 = new BankAccount(50);
            person.BankAccounts.Add(account2);

            Console.WriteLine(person.GetBalance());

            Person person2 = new Person();

            person2.Name = "Pesho";
            person2.Age = 18;

            person2.IntroduceYourself();

            Person.StaticMethod();

            Console.WriteLine(PersonUtil.GetBalance(person));

            Console.WriteLine(ArithmeticOperations.Add(int.MaxValue, int.MaxValue));
            Console.WriteLine(Person.Count);
        }
    }
}
