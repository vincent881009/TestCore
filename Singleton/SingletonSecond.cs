using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{

    /// <summary>
    /// 单例模式
    /// </summary>
    public class SingletonSecond
    {

        private static SingletonSecond _singletonSecond=null;

        private SingletonSecond() {
            Console.WriteLine($"singleton被构造了{this.GetType().Name}{Thread.CurrentThread.ManagedThreadId}次");
        }

        /// <summary>
        /// 静态构造函数
        /// </summary>
        static SingletonSecond()
        {
            _singletonSecond = new SingletonSecond();
        }

        /// <summary>
        /// 获取实例-线程安全
        /// </summary>
        /// <returns></returns>
        public static SingletonSecond CreateInstance()
        {
            return _singletonSecond;
        }



    }
}
