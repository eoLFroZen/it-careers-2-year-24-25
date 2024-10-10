namespace D06P01
{
    public class Bus : Vehicle
    {
        private const double AirConditionFuelConsumption = 1.4;
        private double mainFuelConsumptionPerKm;

        public Bus(double fuelQuantaty, double fuelConsumptionPerKm, double fuelCapacity)
            : base(fuelQuantaty, fuelConsumptionPerKm + AirConditionFuelConsumption, fuelCapacity)
        {
            this.mainFuelConsumptionPerKm = fuelConsumptionPerKm;
        }

        public override bool Drive(double distance)
        {
            FuelConsumptionPerKm = mainFuelConsumptionPerKm + AirConditionFuelConsumption;
            return base.Drive(distance);
        }

        public bool DriveEmpty(double distance)
        {
            FuelConsumptionPerKm = mainFuelConsumptionPerKm;
            return base.Drive(distance);
        }
    }
}
