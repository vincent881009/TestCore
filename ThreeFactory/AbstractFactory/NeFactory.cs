using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeFactory.AbstractFactory
{
    public class NeFactory : AbstractFactory
    {
        public override void CreateArmy()
        {
            Console.WriteLine("Ne CreateArmy");
        }

        public override void CreateRace()
        {
            Console.WriteLine("Ne CreateRace");
        }

        public override void CreateResource()
        {
            Console.WriteLine("Ne CreateResource");
        }
    }
}
