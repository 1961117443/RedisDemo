using Common;
using Redis.List.OrderService;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper.Initialization(RedisUtil.RedisClient);
            Console.WriteLine("here is redis list demo...");
            OrderService orderService = new OrderService();
            while (true)
            {
                // 每秒钟生产一个订单，并写入队列
                var order = orderService.CreateOrder();
                RedisHelper.LPush("Order:Sms", order);
                RedisHelper.LPush("Order:Log", order);
                RedisHelper.LPush("Order:Add", order);
                //var obj = RedisHelper.SubscribeList("a", s => Console.WriteLine(s));
                //var a1 = RedisHelper.SubscribeListBroadcast("b", "a1", s => Console.WriteLine(s));


            }
        }
    }
}
