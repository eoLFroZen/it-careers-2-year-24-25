namespace D05P01
{
    public class Car : Vehicle
    {
        const double airconditionFuelConsumptionPerKm = 0.9;

        public Car(double fuelQuantaty, double fuelConsumptionPerKm)
            : base(fuelQuantaty, fuelConsumptionPerKm + airconditionFuelConsumptionPerKm)
        {

        }
    }
}
