using System;
using System.Collections.Generic;
using System.Text;

namespace ThreeFactory.AbstractFactory
{
   public abstract  class AbstractFactory
    {
        public abstract void CreateRace();

        public abstract void CreateArmy();
        public abstract void CreateResource();

        public string name { get; set; }
        public string age { get; set; }
        public enum Race
        {
            Race
        }
        public enum Army
        {
            Army
        }
        public enum Resource
        {
            Resource
        }
    }
}
