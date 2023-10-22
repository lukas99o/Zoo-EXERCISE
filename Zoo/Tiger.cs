using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal class Tiger : Animal
    {
        protected double TeethLength { get; set; }
        public Tiger(string name, double teethLength)
        {
            Name = name;
            Species = "Tiger";
            TeethLength = teethLength;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} roars!");
        }

        public void Aggression()
        {
            Console.WriteLine($"{Name} the {Species} is aggressive today");
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("TeethLength: " + TeethLength + "cm");
        }

    }
}
