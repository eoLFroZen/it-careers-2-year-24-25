using System.Text;

namespace D07P01
{
    public class Dog : Animal
    {
        public Dog(string name, int age)
            : base(name, age)
        {

        }

        public override string MakeNoise()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Woof!");
            stringBuilder.AppendLine(base.MakeNoise());

            return stringBuilder.ToString().TrimEnd();
        }

        public override string MakeTrick()
        {
            return "Hold my paw, human!";
        }
    }
}
