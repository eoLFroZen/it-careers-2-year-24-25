namespace D04P01
{
    public interface IMachine
    {
        string Type { get; }

        void Start();
        void Stop();
    }
}