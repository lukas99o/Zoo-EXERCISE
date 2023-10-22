using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        protected string Species { get; set; }
        public int Weight { get; set; }
        public int Id { get; set; }
        public int Age { get; set; }

        public Animal()
        {
            Name = "Unknown";
            Species = "Unknown";
            Weight = 0;
            Id = 0;
            Age = 0;
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Generic animal sound");
        }
        public void IsSleeping()
        {
            Console.WriteLine($"{Name} the {Species} makes a generic sound.");
        }
        public void IsEating()
        {
            Console.WriteLine($"{Name} the {Species} is eating.");
        }
        
        public void IsDrinking()
        {
            Console.WriteLine($"{Name} the {Species} is drinking");
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Species: " + Species);
            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Age: " + Age);
        }
    }
}
