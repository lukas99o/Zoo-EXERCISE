using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Zoo
{
    internal class Elephant : Animal
    {
        private double _trunkLength { get; set; }

        public Elephant(string name, double trunkLength)  
        {
            Name = name;
            Species = "Elephant";
            _trunkLength = trunkLength;
        }

        public override void MakeSound()
        {
            Console.WriteLine($"{Name} the {Species} trumpets!");
        }
        
        public void Rampage()
        {
            Console.WriteLine($"{Name} the {Species} is on a Rampage!"); 
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            Console.WriteLine("Trunk length: " + _trunkLength + "m");
        }
    }
}
