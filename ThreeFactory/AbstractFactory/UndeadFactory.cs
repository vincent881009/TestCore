using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeFactory.AbstractFactory
{
    public class UndeadFactory : AbstractFactory
    {
        public override void CreateArmy()
        {
            Console.WriteLine("Undead CreateArmy");
        }

        public override void CreateRace()
        {
            Console.WriteLine("Undead CreateRace");
        }

        public override void CreateResource()
        {
            Console.WriteLine("Undead CreateResource");
        }
    }
}
