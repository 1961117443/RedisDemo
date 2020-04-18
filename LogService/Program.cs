using Common;
using EntityModel;
using Redis.List.LogService;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper.Initialization(RedisUtil.RedisClient);
            Console.WriteLine("here is log service ...");
            Logger logger  = new Logger();
            while (true)
            {
                var order = RedisHelper.BRPop<Order>(1, "Order:Log");
                if (order!=null)
                {
                    //Console.WriteLine("1:{0}",order);
                    logger.WriteLog(order);
                }

            } 
        }
    }
}
