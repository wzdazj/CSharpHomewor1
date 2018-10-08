using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {

            ClockResponse clock1 = new ClockResponse(); //创建设置闹钟的对象
            Alarm alarm1 = new Alarm();                 //创建相应闹钟的对象
            alarm1.A += clock1.Response1;              //注册事件
            alarm1.SetClock(19, 20);                     //设置时间,这里有多个重载，可以根据所需来创建。
        }


    }
}
