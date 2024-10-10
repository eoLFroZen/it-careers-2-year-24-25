namespace D02P02
{
    public abstract class Animal
    {
        private string name;
        private string favouriteFood;

        protected Animal(string name, string favouriteFood)
        {
            this.name = name;
            this.favouriteFood = favouriteFood;
        }

        public virtual string ExplainMyself()
        {
            return $"I am {name} and my fovourite food is {favouriteFood}";
        }
    }
}
