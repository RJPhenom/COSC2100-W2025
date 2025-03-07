using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100_ICE6_RobertMacklem
{
    public class Burger
    {
        // VARS
        private string name;
        private double price;

        // PROPS
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Price
        {
            get { return $"{price:C}"; }
        }

        // CONSTRUCTOR
        public Burger(string name, double price)
        {
            this.name = name;
            this.price = price;
        }
    }
}
