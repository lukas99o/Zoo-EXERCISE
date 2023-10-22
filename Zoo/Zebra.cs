using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Zebra : Animal
    {
        public string NumberOfStripes { get; set; }

        public int Speed { get; }

        public Zebra(string name, int speed)
        {
            Name = name;
            Species = "Zebra";
            Speed = speed;
        }
        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} brays!");
        }

        public void MaxSpeed()
        {
            Console.WriteLine($"{Name} the {Species} is speedin at {Speed}km/h");
        }
        
    }
}
