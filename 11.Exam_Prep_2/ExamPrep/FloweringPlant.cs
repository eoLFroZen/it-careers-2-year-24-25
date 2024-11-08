using System.Text;

public class FloweringPlant : Plant
{
    private const string PlantType = "flower";

    private string color;

    public FloweringPlant(int id, string name, double humidityLevel, double fertilityLevel, string color) 
    : base(id, name, PlantType, humidityLevel, fertilityLevel)
    {
        Color = color;
    }

    public string Color 
    { 
        get { return color; }
        private set 
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Color should be between 3 and 30 characters!");
            }

            color = value;
        }
    }

    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Color: {Color}");

        return stringBuilder.ToString().TrimEnd();
    }
}
