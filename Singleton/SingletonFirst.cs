using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{

    /// <summary>
    /// 单例模式
    /// </summary>
    public class SingletonFirst
    {
        private static object obj = new object();

        private static SingletonFirst singleton;

        private SingletonFirst() {
            //long count = 0;
            //for (int i = 0; i < 1000000; i++)
            //{
            //    count += i;
            //}
            Console.WriteLine($"singleton被构造了{this.GetType().Name}{Thread.CurrentThread.ManagedThreadId}次");
        }


        /// <summary>
        /// 获取实例-线程安全
        /// </summary>
        /// <returns></returns>
        public static SingletonFirst CreateInstance()
        {
            lock (obj)
            {
                if (singleton == null)
                {
                    singleton = new SingletonFirst();
                }
            }
            return singleton;
        }



    }
}
