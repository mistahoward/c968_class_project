using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C968.Classes
{
    class Outsourced : Part
    {
        private int _companyName;

        public int CompanyName { get => _companyName; set => _companyName = value; }
    }
}
