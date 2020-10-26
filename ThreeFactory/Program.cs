using System;
using ThreeFactory.AbstractFactory;

namespace ThreeFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractFactory.AbstractFactory abstractFactoryHuman = new HumanFactory();
            abstractFactoryHuman.CreateArmy();
            abstractFactoryHuman.CreateRace();
            abstractFactoryHuman.CreateResource();

         

            AbstractFactory.AbstractFactory abstractFactoryUndead = new UndeadFactory();
            abstractFactoryUndead.CreateArmy();
            abstractFactoryUndead.CreateRace();
            abstractFactoryUndead.CreateResource();


        }
    }
}
