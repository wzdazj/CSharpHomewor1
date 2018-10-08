using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class ClockResponse
    {
        public ClockResponse()
        {

        }
        public void Response1()
        {
            Console.WriteLine("你所定的时间已到。当前时间为：" + DateTime.Now);
        }
    }
}

