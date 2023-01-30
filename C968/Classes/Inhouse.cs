using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    class Inhouse : Part
    {
        private int _machineId;

        public int MachineId { get => _machineId; set => _machineId = value; }
    }
}
