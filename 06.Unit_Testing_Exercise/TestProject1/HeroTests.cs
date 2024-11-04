namespace Skeleton.Tests;

using Moq;

public class HeroTests
{
    [Test]
    public void HeroGainsExperienceWhenTargetIsDead()
    {
        Mock<IWeapon> mockWeapon = new Mock<IWeapon>();
        Hero hero = new Hero("Name", mockWeapon.Object);
        Mock<ITarget> mockTarget = new Mock<ITarget>();
        mockTarget
            .Setup(target => target.IsDead())
            .Returns(true);
        mockTarget
            .Setup(target => target.GiveExperience())
            .Returns(50);

        // FakeTarget fakeTarget = new FakeTarget();

        hero.Attack(mockTarget.Object);
        // hero.Attack(fakeTarget);

        Assert.AreEqual(50, hero.Experience);
    }
}
