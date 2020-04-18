using EntityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Redis.List.SmsService
{
    public class SmsService
    {
        public   void SendSms(Order order)
        {
            Thread.Sleep(2000);
            Console.WriteLine("订单{0}，成功发送消息",order.OrderNo);
        }
    }
}
