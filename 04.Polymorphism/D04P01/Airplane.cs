using System;

namespace D04P01
{
    public class Airplane : IMachine
    {
        public string Type => "Airplane";

        public void Start()
        {
            Console.WriteLine($"{Type} is starting...");
        }

        public void Stop()
        {
            Console.WriteLine($"{Type} is stopping...");
        }
    }
}
