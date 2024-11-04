namespace Skeleton.Tests;

using Moq;

public class Tests
{
    [Test]
    public void AxeLoosesDurabilitPointsAfterAttack()
    {
        Axe axe = new Axe(20, 5);
        // Dummy dummy = new Dummy(20, 40);

        // axe.Attack(dummy);

        Mock<ITarget> mockTarget = new Mock<ITarget>();

        axe.Attack(mockTarget.Object);

        Assert.AreEqual(4, axe.DurabilityPoints);
    }

    [TestCase(-5)]
    [TestCase(0)]
    public void AxeAttackWithZeroDurabilityThrowsInvalidOperationException(int durability)
    {
        Axe axe = new Axe(20, durability);
        // Dummy dummy = new Dummy(20, 40);
        Mock<ITarget> mockTarget = new Mock<ITarget>();

    //    InvalidOperationException ioe = Assert.Throws<InvalidOperationException>(() => axe.Attack(dummy));
       InvalidOperationException ioe = Assert.Throws<InvalidOperationException>(() => axe.Attack(mockTarget.Object));
       Assert.AreEqual("Axe is broken.", ioe.Message);
    }
}