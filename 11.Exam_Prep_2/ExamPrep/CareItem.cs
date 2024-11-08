using System.Text;

public class CareItem
{
    private string name;

    public CareItem(string name, bool status)
    {
        Name = name;
        Status = status;
    }

    public string Name 
    { 
        get { return name; }
        private set 
        {
            if (value.Length < 2 || value.Length > 40)
            {
                throw new ArgumentException("Name should be between 2 and 40 characters!");
            }

            name = value;
        }
    }

    public bool Status { get; private set; }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"CareItem {Name}");
        stringBuilder.AppendLine($"Status: {Status}");

        return stringBuilder.ToString().TrimEnd();
    }
}
