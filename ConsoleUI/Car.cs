using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Car : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("Drives on 4 wheels");
        }

        public bool HasTrunk { get; set; }
        public override string Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }
    }
}
