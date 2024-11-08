using Easter_Races.Cars;

namespace Easter_Races;

public class CarRepository : IRepository<Car>
{
    private List<Car> cars;

    public CarRepository()
    {
        cars = new List<Car>();
    }

    public void Add(Car car)
    {
       cars.Add(car);
    }

    public IReadOnlyCollection<Car> GetAll()
    {
        return cars.AsReadOnly();
    }

    public Car GetByName(string model)
    {
        return cars.FirstOrDefault(x => x.Model == model);
    }

    public bool Remove(Car car)
    {
        return cars.Remove(car);
    }
}
