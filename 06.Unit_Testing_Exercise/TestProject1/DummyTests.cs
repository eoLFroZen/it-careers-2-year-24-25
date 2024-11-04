namespace Skeleton.Tests;

public class DummyTests
{
    [Test]
    public void DummyLoosesHealthWhenBeenAttacked()
    {
        Dummy dummy = new Dummy(10, 20);

        dummy.TakeAttack(7);

        Assert.AreEqual(3, dummy.Health);    
    }

    [Test]
    public void DeadDummyThrowsInvalidOperationExceptionWhenBeenAttacked()
    {
        Dummy dummy = new Dummy(0, 20);

        InvalidOperationException ioe = Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(7));
        Assert.AreEqual("Dummy is dead.", ioe.Message);
    }

    [Test]
    public void DeadDummyGivesExperience()
    {
        Dummy dummy = new Dummy(0, 20);

        int experience = dummy.GiveExperience();

        Assert.AreEqual(20, experience);
    }

    [Test]
    public void WhenLivingDummyGiveExperienceIsCalledInvalidOperationExceptionIsThrown()
    {
        Dummy dummy = new Dummy(10, 20);

        InvalidOperationException ioe = Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        Assert.AreEqual("Target is not dead.", ioe.Message);
    }
}
