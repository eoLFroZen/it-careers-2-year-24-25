using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace D06P01
{
    class Program
    {
        private static StringBuilder logs = new StringBuilder();

        static void Main(string[] args)
        {
            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();

            for (int i = 0; i < 3; i++)
            {
                List<string> vehicleArgs = Console.ReadLine()
                    .Split(' ')
                    .ToList();

                string vehicleType = vehicleArgs[0];
                double vehicleFuelQuantaty = double.Parse(vehicleArgs[1]);
                double vehicleFuelConsumptionPerKm = double.Parse(vehicleArgs[2]);
                double vehicleFuelCapacity = double.Parse(vehicleArgs[3]);

                Vehicle vehicle = null;

                if (vehicleType == "Car")
                {
                    vehicle = new Car(vehicleFuelQuantaty, vehicleFuelConsumptionPerKm, vehicleFuelCapacity);
                }
                else if (vehicleType == "Truck")
                {
                    vehicle = new Truck(vehicleFuelQuantaty, vehicleFuelConsumptionPerKm, vehicleFuelCapacity);
                }
                else if (vehicleType == "Bus")
                {
                    vehicle = new Bus(vehicleFuelQuantaty, vehicleFuelConsumptionPerKm, vehicleFuelCapacity);
                }

                vehicles.Add(vehicleType, vehicle);
            }

            int commandCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < commandCount; i++)
            {
                List<string> commandArgs = Console.ReadLine()
                    .Split()
                    .ToList();

                string command = commandArgs[0];
                string vehicleType = commandArgs[1];

                if (command == "Drive")
                {
                    double distance = double.Parse(commandArgs[2]);
                    bool hasTravelled = vehicles[vehicleType].Drive(distance);

                    PrintDriveResult(hasTravelled, vehicleType, distance);
                }
                else if (command == "Refuel")
                {
                    double fuelQuantaty = double.Parse(commandArgs[2]);

                    try
                    {
                        bool hasRefueled = vehicles[vehicleType].Refuel(fuelQuantaty);

                        if (!hasRefueled)
                        {
                            logs.AppendLine("Cannot fit fuel in tank");
                        }
                    }
                    catch (ArgumentException ae)
                    {
                        logs.AppendLine(ae.Message);
                    }
                }
                else if (command == "DriveEmpty")
                {
                    double distance = double.Parse(commandArgs[2]);
                    Vehicle vehicle = vehicles[vehicleType];
                    bool hasTravelled = false;

                    if (vehicle is Bus)
                    {
                        hasTravelled = ((Bus)vehicle).DriveEmpty(distance);
                    }

                    PrintDriveResult(hasTravelled, vehicleType, distance);
                }
            }

            logs.AppendLine($"Car: {vehicles["Car"].FuelQuantaty:F2}");
            logs.AppendLine($"Truck: {vehicles["Truck"].FuelQuantaty:F2}");
            logs.AppendLine($"Bus: {vehicles["Bus"].FuelQuantaty:F2}");

            Console.WriteLine();

            Console.WriteLine(logs.ToString());
        }

        private static void PrintDriveResult(bool hasTravelled, string vehicleType, double distance)
        {
            string message = hasTravelled
                ? $"{vehicleType} travelled {distance} km"
                : $"{vehicleType} needs refueling";

            logs.AppendLine(message);
        }
    }
}
