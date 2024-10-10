﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04P01
{
    public class LawnMower : IMachine
    {
        public LawnMower()
        {
            Type = "LawnMower";
        }

        public string Type { get; }

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
