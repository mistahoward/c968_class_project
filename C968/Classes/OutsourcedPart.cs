 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    class OutsourcedPart : Part
    {
        private string _companyName;

        public string CompanyName { get => _companyName; set => _companyName = value; }

        public OutsourcedPart(int partId, string name, int inStock, decimal price, int max, int min, string companyName)
        {
            PartId = partId;
            Name = name;
            InStock = inStock;
            Price = price;
            Min = min;
            Max = max;
            CompanyName = companyName;
        }
    }
}
