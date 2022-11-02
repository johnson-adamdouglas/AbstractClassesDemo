using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public override string Year { get; set; }
        public override string Make { get; set; }
        public override string Model { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("Drives on 2 wheels");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Drives on 2 wheels override virtual method");
        }

        public bool HasSideCart { get; set; }

    }
}
