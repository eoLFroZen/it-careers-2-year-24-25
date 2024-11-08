using System.Collections.ObjectModel;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using Easter_Races.Cars;

namespace Easter_Races;

public class ChampionshipController
{
    private DriverRepository driverRepository;
    private CarRepository carRepository;
    private RaceRepository raceRepository;

    public ChampionshipController()
    {
        
    }

    public ChampionshipController(DriverRepository driverRepository, CarRepository carRepository, RaceRepository raceRepository)
    {
        this.driverRepository = driverRepository;
        this.carRepository = carRepository;
        this.raceRepository = raceRepository;
    }

    public string AddDriver(string driverName)
    {
        if (driverRepository.GetByName(driverName) != null)
        {
            throw new ArgumentException($"Driver {driverName} is already created.");
        }

        Driver driver = new Driver(driverName);
        driverRepository.Add(driver);

        return $"Driver {driverName} is created.";
    }

    public string CreateCar(string type, string model, int horsePower)
    {
        if (carRepository.GetByName(model) != null)
        {
            throw new ArgumentException($"Car {model} is already created.");
        }

        Car car = null;

        if(type == "Muscle")
        {
            car = new MuscleCar(model, horsePower);
        }
        else
        {
            car = new SportsCar(model, horsePower);
        }

        carRepository.Add(car);

        return $"{type}Car {model} is created.";
    }

    public string AddCarToDriver(string driverName, string carModel)
    {
        Driver driver = driverRepository.GetByName(driverName);
        Car car = carRepository.GetByName(carModel);

        if (driver == null)
        {
            throw new InvalidOperationException($"Driver {driverName} could not be found.");
        }

        if (car == null)
        {
            throw new InvalidOperationException($"Car {carModel} could not be found.");
        }

        driver.AddCar(car);

        return $"Driver {driverName} received car {carModel}.";
    }

    public string AddDriverToRace(string raceName, string driverName)
    {
        Race race = raceRepository.GetByName(raceName);
        Driver driver = driverRepository.GetByName(driverName);

        if (race == null)
        {
            throw new InvalidOperationException($"Race {raceName} could not be found.");
        }

        if (driver == null)
        {
            throw new InvalidOperationException($"Driver {driverName} could not be found.");
        }

        race.AddDriver(driver);

        return $"Driver {driverName} added in {raceName} race.";
    }

    public string CreateRace(string name, int laps)
    {
        if (raceRepository.GetByName(name) != null)
        {
            throw new ArgumentException($"Race {name} is already created.");
        }

        Race race = new Race(name, laps);
        raceRepository.Add(race);

        return $"Race {name} is created.";
    }

    public string StartRace(string raceName)
    {
        Race race = raceRepository.GetByName(raceName);

        if (race == null)
        {
            throw new InvalidOperationException($"Race {raceName} could not be found.");
        }

        if (race.Drivers.Count < 3)
        {
            throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
        }

        List<Driver> winningDrivers = race.Drivers
            .OrderByDescending(driver => driver.Car.CalculateRacePoints(race.Laps))
            .Take(3)
            .ToList();

        StringBuilder stringBuilder = new StringBuilder();

        stringBuilder.AppendLine($"Driver {winningDrivers[0].Name} wins {race.Name} race.");
        stringBuilder.AppendLine($"Driver {winningDrivers[1].Name} is second in {race.Name} race.");
        stringBuilder.AppendLine($"Driver {winningDrivers[2].Name} is third in {race.Name} race.");

        return stringBuilder.ToString().TrimEnd();
    }
}
