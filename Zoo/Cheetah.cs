using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal sealed class Cheetah : Tiger
    {
        public int Speed { get; }
        public Cheetah(string name, int teethLength, int speed) : base(name, teethLength)
        {
            Name = name;
            Species = "Cheetah";
            Speed = speed;
        }

        public bool CanCheetahCatchZebra(Zebra zebra)
        {
            if (Speed > zebra.Speed)
            {
                Console.WriteLine($"{Name} the {Species} can catch the Zebra because he/she is faster!");
                return true;
            }
            else
            {
                Console.WriteLine($"{Name} the {Species} can't catch the Zebra because he/she is to slower!");
                return false;
            }

        }
    }
}
