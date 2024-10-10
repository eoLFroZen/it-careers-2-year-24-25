namespace D05P01
{
    public abstract class Vehicle
    {
        private double fuelConsumptionPerKm;

        protected Vehicle(double fuelQuantaty, double fuelConsumptionPerKm)
        {
            FuelQuantaty = fuelQuantaty;
            this.fuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public double FuelQuantaty { get; private set; }

        public bool Drive(double distance)
        {
            double travelFuelQuantaty = distance * fuelConsumptionPerKm;

            if (travelFuelQuantaty <= FuelQuantaty)
            {
                FuelQuantaty -= travelFuelQuantaty;
                return true;
            }

            return false;
        }

        public virtual void Refuel(double quantaty)
        {
            FuelQuantaty += quantaty;
        }
    }
}
