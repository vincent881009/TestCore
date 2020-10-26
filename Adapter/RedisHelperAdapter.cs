using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter
{
    class RedisHelperAdapter : IHelper
    {

        private readonly RedisHelper _redisHelper=new RedisHelper();
        public RedisHelperAdapter()
        {
        }


        public void add()
        {
            _redisHelper.addRedis();
        }

        public void delete()
        {
            _redisHelper.deleteRedis();
        }

        public void query()
        {
            _redisHelper.queryRedis();
        }

        public void update()
        {
            _redisHelper.updateRedis();
        }
    }
}
