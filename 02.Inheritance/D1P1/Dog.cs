namespace D1P1
{
    public class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine("Bark");
        }

        public override void Eat()
        {
            base.Eat();
            Console.WriteLine("Dog is really happy!");
        }
    }
}
