namespace Easter_Races;

public class DriverRepository : IRepository<Driver>
{
    private List<Driver> drivers;

    public DriverRepository()
    {
        drivers = new List<Driver>();
    }

    public void Add(Driver driver)
    {
       drivers.Add(driver);
    }

    public IReadOnlyCollection<Driver> GetAll()
    {
        return drivers.AsReadOnly();
    }

    public Driver GetByName(string name)
    {
        return drivers.FirstOrDefault(x => x.Name == name);
    }

    public bool Remove(Driver driver)
    {
        return drivers.Remove(driver);
    }
}
