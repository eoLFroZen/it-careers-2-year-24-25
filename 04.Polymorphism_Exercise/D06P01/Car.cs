namespace D06P01
{
    public class Car : Vehicle
    {
        const double airconditionFuelConsumptionPerKm = 0.9;

        public Car(double fuelQuantaty, double fuelConsumptionPerKm, double fuelCapacity)
            : base(fuelQuantaty, fuelConsumptionPerKm + airconditionFuelConsumptionPerKm, fuelCapacity)
        {

        }
    }
}
