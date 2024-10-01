namespace D06P01
{
    public class FullTimeEmployee : BaseEmployee
    {
        private string position;
        private string department;

        public FullTimeEmployee(string id, string name, string address, string position, string department)
            : base(id, name, address)
        {
            this.position = position;
            this.department = department;
        }

        public override void Show()
        {
            base.Show();

            Console.WriteLine($"Position: {position}");
            Console.WriteLine($"Department: {Department}");
        }

        public override string Department => department;

        public override decimal CalculateSalary(int workingHours)
        {
            return 250 + workingHours * 10.80m;
        }
    }
}
