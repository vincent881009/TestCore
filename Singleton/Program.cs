using System;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Task.Run(() =>
                {
                    var singleton1 = SingletonFirst.CreateInstance();
                    var singleton2=SingletonSecond.CreateInstance();                  
                });
            }
            Console.ReadLine();
        }
    }




}
