using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D04P01
{
    public class MachineOperator
    {
        private IMachine machine;

        public MachineOperator(IMachine machine)
        {
            Machine = machine;
        }

        public IMachine Machine
        {
            get { return machine; }
            set
            {
                machine = value;
                Console.WriteLine("Machine operator is operating: " + value.Type);
            }
        }

        public void StartMachine()
        {
            Machine.Start();
        }

        public void StopMachine()
        {
            Machine.Stop();
        }
    }
}
