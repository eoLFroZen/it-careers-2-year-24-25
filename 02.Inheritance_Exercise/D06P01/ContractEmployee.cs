namespace D06P01
{
    public class ContractEmployee : BaseEmployee
    {
        private string task;
        private string department;

        public ContractEmployee(string id, string name, string address, string task, string department)
            : base(id, name, address)
        {
            this.task = task;
            this.department = department;
        }

        public override string Department => department;

        public override void Show()
        {
            base.Show();

            Console.WriteLine($"Task: {task}");
            Console.WriteLine($"Department: {Department}");
        }

        public override decimal CalculateSalary(int workingHours)
        {
            return 250m + workingHours * 20;
        }
    }
}
