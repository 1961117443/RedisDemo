using System;

namespace Common
{
    public class RedisUtil
    {
        public static CSRedis.CSRedisClient RedisClient = new CSRedis.CSRedisClient("193.112.92.216:9192,password=ABCabc,writeBuffer=1024000");
    }
}
