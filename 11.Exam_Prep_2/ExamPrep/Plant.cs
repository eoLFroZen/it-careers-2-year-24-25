using System.Text;

public abstract class Plant
{
    private const int MaxHumidityLevel = 1;
    private const int MaxFertilityLevel = 1;

    private string name;
    private string type;
    private List<CareItem> careItems;
    private double humidityLevel;
    private double fertilityLevel;

    protected Plant(int id, string name, string type, double humidityLevel, double fertilityLevel)
    {
        Id = id;
        Name = name;
        Type = type;
        HumidityLevel = humidityLevel;
        FertilityLevel = fertilityLevel;
        careItems = new List<CareItem>();
    }


    public int Id { get; private set; }

    public string Name 
    { 
        get { return name; }
        private set 
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Name should be between 3 and 30 characters!");
            }

            name = value;
        }
    }

    public string Type 
    { 
        get { return type; }
        private set 
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Type should be between 3 and 30 characters!");
            }

            type = value;
        }
    }

    public IReadOnlyCollection<CareItem> CareItems => careItems.AsReadOnly();

    public double HumidityLevel 
    {     
        get { return humidityLevel; } 
        private set
        {
            if(value < 0 || value > 1)
            {
                throw new ArgumentException("Humidity Level should be between 0 and 1!");
            }

            humidityLevel = value;
        } 
    }

    public double FertilityLevel 
    {     
        get { return fertilityLevel; } 
        private set
        {
            if(value < 0 || value > 1)
            {
                throw new ArgumentException("Fertility Level should be between 0 and 1!");
            }

            fertilityLevel = value;
        } 
    }


    public void AddCareItem(CareItem careItem)
    {
        careItems.Add(careItem);
    }

    public int TotalCaresDone()
    {
        return careItems.Where(ci => ci.Status).Count();
    }

    public bool Water(double percent)
    {
        if (HumidityLevel + percent <= MaxHumidityLevel)
        {
            HumidityLevel += percent;
            return true;
        }

        return false;
    }

    public bool Fertilize(double percent)
    {
        if (FertilityLevel + percent <= MaxFertilityLevel)
        {
            FertilityLevel += percent;
            return true;
        }

        return false;
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Id: {Id}");
        stringBuilder.AppendLine($"Name: {Name}");
        stringBuilder.AppendLine($"Type: {Type}");
        stringBuilder.AppendLine($"Humidity Level: {HumidityLevel:F2} %");
        stringBuilder.AppendLine($"Fertility Level: {FertilityLevel:F2} %");

        return stringBuilder.ToString().TrimEnd();
    }

}
