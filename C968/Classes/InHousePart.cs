using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    class InHousePart : Part
    {
        private int _machineId;
        public int MachineId { get => _machineId; set => _machineId = value; }

        public InHousePart(int partId, string name, int inStock, decimal price, int max, int min, int machineId)
        {
            PartId = partId;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            MachineId = machineId;
        }
    }
}
