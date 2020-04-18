using Common;
using EntityModel;
using Redis.List.SmsService;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            RedisHelper.Initialization(RedisUtil.RedisClient);
            var a1 = RedisHelper.SubscribeListBroadcast("Order:Add", "sms", BroadcastSms);
            Console.WriteLine("here is sms service ...");
            SmsService smsService  = new SmsService();
            while (true)
            {
                var order = RedisHelper.BRPop<Order>(1, "Order:Sms");
                if (order != null)
                {
                    //Console.WriteLine("1:{0}",order);
                    smsService.SendSms(order);
                }

            }
        }

        static void BroadcastSms(string msg)
        {
            Console.WriteLine("BroadcastSms:{0}",msg);
        }

    }
}
