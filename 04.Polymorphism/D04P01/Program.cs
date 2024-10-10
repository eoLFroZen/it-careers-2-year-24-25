namespace D04P01
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            LawnMower lawnMower = new LawnMower();
            IMachine airplane = new Airplane();
            IMachine truck = new Truck();

            MachineOperator machineOperator = new MachineOperator(car);
            machineOperator.StartMachine();
            machineOperator.StopMachine();

            machineOperator.Machine = lawnMower;
            machineOperator.StartMachine();
            machineOperator.StopMachine();

            machineOperator.Machine = truck;
            machineOperator.StartMachine();
            machineOperator.StopMachine();

            machineOperator.Machine = airplane;
            machineOperator.StartMachine();
            machineOperator.StopMachine();
        }
    }
}
