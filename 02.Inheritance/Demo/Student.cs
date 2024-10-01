namespace Demo
{
    public class Student : Person, Animal
    {
        public Student(string name, string address, string school)
            :base(name, address)
        {
            School = school;
        }

        public string School { get; set; }
    }
}
