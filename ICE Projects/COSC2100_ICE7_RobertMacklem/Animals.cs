using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COSC2100_ICE7_RobertMacklem
{
    public class Animals
    {
        // Dictionary of animals that could be options.
        //  Key: animal names (str)
        //  Values: animal emojis (str)
        public static Dictionary<string, string> animalName2Emoji = new Dictionary<string, string>()
        {
            {"Dog", "🐕"},
            {"Cat", "🐈"},
            {"Lion", "🦁"},
            {"Tiger", "🐅"},
            {"Elephant", "🐘"},
            {"Monkey", "🐒"},
            {"Horse", "🐎"},
            {"Rabbit", "🐇"},
            {"Fox", "🦊"},
            {"Panda", "🐼"},
            {"Koala", "🐨"},
            {"Penguin", "🐧"},
            {"Bear", "🐻"},
            {"Frog", "🐸"},
            {"Whale", "🐋"},
            {"Octopus", "🐙"}
        };
    }
}
