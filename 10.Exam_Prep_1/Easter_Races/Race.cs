namespace Easter_Races;

public class Race
{
    private string name;
    private int laps;

    private List<Driver> drivers;

    public Race(string name, int laps)
    {
        Name = name;
        Laps = laps;
        drivers = new List<Driver>();
    }

    public string Name 
    {
        get { return name; }
        private set
        {
            if (string.IsNullOrEmpty(value) || value.Length < 5)
            {
                throw new ArgumentException($"Name {value} cannot be less than 5 symbols.");
            }

            name = value;
        }
    }

    public int Laps 
    {
        get { return laps; }
        private set
        {
            if (value < 1)
            {
                throw new ArgumentException("Laps cannot be less than 1.");
            }

            laps = value;
        }
    }

    public IReadOnlyCollection<Driver> Drivers => drivers.AsReadOnly();

    public void AddDriver(Driver driver)
    {
        if (driver == null)
        {
            throw new ArgumentNullException("Driver cannot be null.");
        }

        if(!driver.CanParticipate)
        {
            throw new ArgumentException($"Driver {driver.Name} could not participate in race.");
        }

        if (drivers.FirstOrDefault(x => x.Name == driver.Name) != null)
        {
            throw new ArgumentNullException($"Driver {driver.Name} is already added in {Name} race.");
        }

        drivers.Add(driver);
    }

}
