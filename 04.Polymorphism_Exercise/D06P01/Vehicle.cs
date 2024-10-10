using System;

namespace D06P01
{
    public abstract class Vehicle
    {
        private double fuelQuantity;
        private double fuelCapacity;

        protected Vehicle(double fuelQuantaty, double fuelConsumptionPerKm, double fuelCapacity)
        {
            FuelQuantaty = fuelQuantaty;
            FuelConsumptionPerKm = fuelConsumptionPerKm;
            this.fuelCapacity = fuelCapacity;
        }

        public double FuelQuantaty
        {
            get { return fuelQuantity; }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fuel must be a positive number");
                }

                fuelQuantity = value;
            }
        }
        public double FuelConsumptionPerKm { get; protected set; }

        public virtual bool Drive(double distance)
        {
            double travelFuelQuantaty = distance * FuelConsumptionPerKm;

            if (travelFuelQuantaty <= FuelQuantaty)
            {
                FuelQuantaty -= travelFuelQuantaty;
                return true;
            }

            return false;
        }

        public virtual bool Refuel(double quantaty)
        {
            double totalFuel = FuelQuantaty + quantaty;

            if (fuelCapacity > totalFuel)
            {
                FuelQuantaty = totalFuel;
                return true;
            }

            return false;
        }
    }
}
