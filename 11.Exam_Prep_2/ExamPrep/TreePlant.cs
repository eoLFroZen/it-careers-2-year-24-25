using System.Text;

public class TreePlant : Plant
{
    private const string PlantType = "tree";

    private int height;

    public TreePlant(int id, string name, double humidityLevel, double fertilityLevel, int height)
        :base(id, name, PlantType, humidityLevel, fertilityLevel)
    {
        Height = height;
    }

    public int Height
    {
        get { return height; }
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException("Height should be positive!");
            }
            
            height = value;
        }
    }

    
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine(base.ToString());
        stringBuilder.AppendLine($"Height: {Height}");

        return stringBuilder.ToString().TrimEnd();
    }
}
