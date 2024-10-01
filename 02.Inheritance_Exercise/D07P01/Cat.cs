using System.Text;

namespace D07P01
{
    public class Cat : Animal
    {
        public Cat(string name, int age)
            : base(name, age)
        {

        }

        public override string MakeNoise()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Meow!");
            stringBuilder.AppendLine(base.MakeNoise());

            return stringBuilder.ToString().TrimEnd();
        }

        public override string MakeTrick()
        {
            return "No trick for you! I'm too lazy!";
        }
    }
}
