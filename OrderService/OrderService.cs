using EntityModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Redis.List.OrderService
{
    public class OrderService
    {
        public Order CreateOrder()
        {
            Thread.Sleep(1000);
            var order= new Order
            {
                OrderNo = DateTime.Now.ToString("yyyyMMddHHmmss"),
                OrderDate = DateTime.Now.ToString("yyyy-MM-dd")
            };
            Console.WriteLine("成功创建订单：{0}", order.OrderNo);
            return order;
        }
    }
}
