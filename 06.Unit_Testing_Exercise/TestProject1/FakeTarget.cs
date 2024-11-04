namespace Skeleton.Tests;

public class FakeTarget : ITarget
{
    public int Health => 0;

    public void TakeAttack(int attackPoints)
    {
       
    }

    public int GiveExperience()
    {
        return 50;
    }

    public bool IsDead()
    {
        return true;
    }
}
