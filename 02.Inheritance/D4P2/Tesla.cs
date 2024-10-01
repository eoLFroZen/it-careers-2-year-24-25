namespace D4P2
{
    public class Tesla : ICar, IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }
        public int Battery { get; private set; }

        public string Start()
        {
            return "Tesla Start";
        }

        public string Stop()
        {
            return "Tesla Stop";
        }
    }
}
