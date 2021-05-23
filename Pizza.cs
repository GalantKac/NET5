using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NET5
{
    public class Pizza
    {
        public Pizza(string name, bool hasMeat, bool hasAnanas)
        {
            Name = name;
            HasMeat = hasMeat;
            HasAnanas = hasAnanas;
        }

        public string Name { get; set; }
        public bool HasMeat { get; set; }
        public bool HasAnanas { get; set; }
    }
}
