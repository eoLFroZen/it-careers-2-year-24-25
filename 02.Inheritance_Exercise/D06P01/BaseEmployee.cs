using System.Text;

namespace D06P01
{
    public abstract class BaseEmployee
    {
        private string id;
        private string name;
        private string address;

        protected BaseEmployee(string id, string name, string address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

        public virtual void Show()
        {
            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine("Employee Information: ");
            stringBuilder.AppendLine($"Id: {id}");
            stringBuilder.AppendLine($"Name: {name}");
            stringBuilder.AppendLine($"Address: {address}");

            Console.WriteLine(stringBuilder.ToString().TrimEnd());
        }

        public abstract decimal CalculateSalary(int workingHours);

        //public abstract string GetDepartment();
        public abstract string Department { get; }
    }
}
