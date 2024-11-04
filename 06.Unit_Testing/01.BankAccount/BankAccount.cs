namespace _01_BankAccount;

public class BankAccount
{
    public BankAccount(decimal amount)
    {
        Amount = amount;
    }

    public decimal Amount { get; set; }

    public void Deposit(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Deposit should be a positive number");
        }   

        Amount += amount;
    }

    public void Withdraw(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Withdraw should be a positive number");
        }

        if(amount > Amount)
        {
            throw new ArgumentException("Amount is bigger than the balance");
        }   

        Amount -= amount;
    }
}
