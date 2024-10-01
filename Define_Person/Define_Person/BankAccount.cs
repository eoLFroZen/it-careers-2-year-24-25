using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Define_Person
{
    public class BankAccount
    {
        private string id;
        private decimal balance;

        public BankAccount() :this(15)
        {
        }

        public BankAccount(decimal balance)
        {
            Balance = balance;
        }

        public string Id
        {
            get { return id; }
            set  { id = value;}
        }

        public decimal Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void SetId(string id)
        {
            this.id = id;
        }

        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance += amount;
            }
        }

        public void Withdraw(decimal amount)
        {
            if (amount > 0 && Balance <= amount)
            {
                Balance -= amount;
            }
        }
    }
}
