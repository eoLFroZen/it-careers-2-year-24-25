namespace Easter_Races;

public interface IRepository<T>
{
    void Add(T model);

    bool Remove(T model);

    T GetByName(string name);

    IReadOnlyCollection<T> GetAll();
}
