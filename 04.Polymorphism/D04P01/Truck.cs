using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04P01
{
    public class Truck : IMachine
    {
        public string Type => "Truck";

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
