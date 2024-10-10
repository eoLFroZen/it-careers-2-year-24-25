using System;

namespace D02P02
{
    public class Dog : Animal
    {
        public Dog(string name, string favouriteFood)
            : base(name, favouriteFood)
        {

        }

        public override string ExplainMyself()
        {
            return base.ExplainMyself() + Environment.NewLine + "DJAAF";
        }
    }
}
