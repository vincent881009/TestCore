using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeFactory.AbstractFactory
{
    public class HumanFactory : AbstractFactory
    {
        public override void CreateArmy()
        {
            Console.WriteLine("Human CreateArmy");
        }

        public override void CreateRace()
        {
            Console.WriteLine("Human CreateRace");
        }

        public override void CreateResource()
        {
            Console.WriteLine("Human CreateResource");
        }
    }
}
