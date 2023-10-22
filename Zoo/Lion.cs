using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo
{
    internal sealed class Lion : Tiger
    {
        public bool IsAlpha { get; }
         
        public Lion(string name, double teethLength, bool isAlpha) : base(name, teethLength)
        {
            Name = name;
            Species = "Lion";
            IsAlpha = isAlpha;
        }

        public override void PrintInfo()
        {
            base.PrintInfo();
            if (IsAlpha == true)
            {
            Console.WriteLine("Lion hierarchy status: Alpha");
            }
            else
            {
                Console.WriteLine("Lion hierarchy status: Beta");
            }
        }
    }
}
