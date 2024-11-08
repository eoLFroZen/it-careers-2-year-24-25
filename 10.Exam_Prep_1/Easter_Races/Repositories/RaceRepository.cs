namespace Easter_Races;

public class RaceRepository
{
    private List<Race> races;

    public RaceRepository()
    {
        races = new List<Race>();
    }

    public void Add(Race race)
    {
       races.Add(race);
    }

    public IReadOnlyCollection<Race> GetAll()
    {
        return races.AsReadOnly();
    }

    public Race GetByName(string name)
    {
        return races.FirstOrDefault(x => x.Name == name);
    }

    public bool Remove(Race race)
    {
        return races.Remove(race);
    }
}
