using System.Data.Common;
using Easter_Races.Cars;

namespace Easter_Races;

public class Driver
{
    private string name;

    public Driver(string name)
    {
        Name = name;
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

    public Car Car { get; private set; }
    public int NumberOfWins { get; private set; }
    public bool CanParticipate => Car != null;
    // public bool CanParticipate { get { return Car != null; } }

    public void AddCar(Car car)
    {
        if (car == null)
        {
            throw new ArgumentException("Car cannot be null.");
        }

        Car = car;
    }

    public void WinRace()
    {
        NumberOfWins++;
    }
}
