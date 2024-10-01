namespace D08P02
{
    public class Pet : IBirthable
    {
        private string name;

        public Pet(string name, string birthdate)
        {
            this.name = name;
            Birthdate = birthdate;
        }

        public string Birthdate { get; }
    }
}
