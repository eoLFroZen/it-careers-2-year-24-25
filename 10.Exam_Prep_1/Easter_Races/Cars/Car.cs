namespace Easter_Races.Cars;

public abstract class Car
{
    private string model;
    private int horsePower;
    private int minHorsePower;
    private int maxHorsePower;

    protected Car(string model, int horsePower, double cubicCentimeters, int minHorsePower, int maxHorsePower)
    {
        this.minHorsePower = minHorsePower;
        this.maxHorsePower = maxHorsePower;
        Model = model;
        CubicCentimiters = cubicCentimeters;
        HorsePower = horsePower;
    }

    public string Model 
    {
        get { return model; }
        private set 
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length < 4)
            {
                throw new ArgumentException($"Model {value} cannot be less than 4 symbols.");
            }

            model = value;
        }
    }

    public int HorsePower 
    { 
        get
        {
            return horsePower;
        } 
        private set 
        {
            if(value < minHorsePower || value > maxHorsePower)
            {
                throw new ArgumentException($"Invalid horse power: {value}.");
            }

            horsePower = value;
        } 
    }
    public double CubicCentimiters { get; private set; }

    public double CalculateRacePoints(int laps)
    {
        return CubicCentimiters / HorsePower * laps;
    }
}
