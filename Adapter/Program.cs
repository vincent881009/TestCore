using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //直接使用扩展的RedisHelper类不规范 需要包一层RedisHelperAdapter来使用。
            //就和MySqlHelper,SqlHelper等约束一致了。
            IHelper helper = new RedisHelperAdapter( );
            helper.add();

        }
    }
}
