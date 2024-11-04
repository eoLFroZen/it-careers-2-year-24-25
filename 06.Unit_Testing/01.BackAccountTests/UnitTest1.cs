using _01_BankAccount;

namespace _01.BackAccountTests;

public class Tests
{
    [Test]
    public void BankAccountShouldInitializeWithPassedValue()
    {
        decimal amount = 1000m;
        
        BankAccount bankAccount = new BankAccount(amount);
        
        Assert.AreEqual(amount, bankAccount.Amount);
    }

    [Test]
    public void DepositShouldIncreaseBalance()
    {
        //Arrange
        decimal amount = 1000m;
        BankAccount bankAccount = new BankAccount(0);

        //Act
        bankAccount.Deposit(amount);

        //Assert
        Assert.True(amount == bankAccount.Amount);
    }

    [TestCase(0)]
    [TestCase(-500)]
    public void DepositShouldThrowArgumentExeptionWhenAmountIsNotPositiveNumber(decimal amount)
    {
        //Arrange
        BankAccount bankAccount = new BankAccount(0);

        //Act
        //Assert
        Assert.Throws<ArgumentException>(() => bankAccount.Deposit(amount));
    }


    [Test]
    public void WithdrawShouldDecreaseBalanceCorrectly()
    {
         //Arrange
        decimal amount = 300m;
        BankAccount bankAccount = new BankAccount(1000);

        //Act
        bankAccount.Withdraw(amount);

        //Assert
        Assert.AreEqual(700m, bankAccount.Amount, "BankAccount amount is lower than expected");
    }

    [TestCase(0)]
    [TestCase(-200)]
    public void WithdrawShouldThrowArgumentExceptionWhenAmountIsNotAPositiveNumber(decimal amount)
    {
         //Arrange
        BankAccount bankAccount = new BankAccount(1000);

        //Act
        //Assert
        ArgumentException ae = Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(amount));
        Assert.AreEqual("Withdraw should be a positive number", ae.Message);
    }

    [Test]
    public void WithdrawShouldThrowArgumentExceptionWhenAmountIsBiggerThanBalance()
    {
         //Arrange
        decimal amount = 3000m;
        BankAccount bankAccount = new BankAccount(1000);

        //Act
        //Assert
        ArgumentException ae = Assert.Throws<ArgumentException>(() => bankAccount.Withdraw(amount));
        Assert.AreEqual("Amount is bigger than the balance", ae.Message);
    }
}