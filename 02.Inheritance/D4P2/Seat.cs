namespace D4P2
{
    public class Seat : ICar
    {
        public Seat(string model, string color)
        {
            Model = model;
            Color = color;
        }

        public string Model { get; private set; }

        public string Color { get; private set; }

        public string Start()
        {
            return "Seat Start";
        }

        public string Stop()
        {
            return "Seat Stop";
        }
    }
}
