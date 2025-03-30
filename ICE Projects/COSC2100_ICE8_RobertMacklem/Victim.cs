using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100_ICE8_RobertMacklem
{
    public class Victim
    {
        // PROPS
        public bool IsDead { get; set; }
        public string Name { get; set; }

        /// <summary>
        /// Constructor for the Victim class instances.
        /// </summary>
        public Victim(string name)
        {
            IsDead = false;
            Name = name;
        }
    }
}
