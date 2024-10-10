namespace D06P01
{
    public class Truck : Vehicle
    {
        const double airconditionFuelConsumptionPerKm = 1.6;

        public Truck(double fuelQuantaty, double fuelConsumptionPerKm, double fuelCapacity)
            : base(fuelQuantaty, fuelConsumptionPerKm + airconditionFuelConsumptionPerKm, fuelCapacity)
        {

        }

        public override bool Refuel(double quantaty)
        {
            double finalFuelQuantaty = quantaty * 0.95;
            return base.Refuel(finalFuelQuantaty);
        }
    }
}
