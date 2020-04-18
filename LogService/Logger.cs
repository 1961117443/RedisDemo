using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Redis.List.LogService
{
    public class Logger
    {
        public void WriteLog(object log)
        {
            Thread.Sleep(100);
            Console.WriteLine("日志记录成功：{0}",log.ToString());
        }
    }
}
