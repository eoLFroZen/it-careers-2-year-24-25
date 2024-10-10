namespace D05P01
{
    public class Truck : Vehicle
    {
        const double airconditionFuelConsumptionPerKm = 1.6;

        public Truck(double fuelQuantaty, double fuelConsumptionPerKm)
            :base(fuelQuantaty, fuelConsumptionPerKm + airconditionFuelConsumptionPerKm)
        {

        }

        public override void Refuel(double quantaty)
        {
            double finalFuelQuantaty = quantaty * 0.95;
            base.Refuel(finalFuelQuantaty);
        }
    }
}
