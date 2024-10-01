using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Person
{
    public class PersonUtil
    {
        public static decimal GetBalance(Person person)
        {
            return person.BankAccounts.Sum(acc => acc.Balance);
        }

        public static decimal GetBiggerFirstAccount(Person person, Person person2)
        {
            return Math.Max(person.BankAccounts[0].Balance, person2.BankAccounts[0].Balance);
        }
    }
}
