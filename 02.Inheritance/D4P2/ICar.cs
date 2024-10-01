namespace D4P2
{
    public interface ICar
    {
        string Model { get; }
        string Color { get; }

        string Start();

        string Stop();
    }
}
