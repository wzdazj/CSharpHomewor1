using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    class Alarm
    {
        public void SetClock(int year, int month, int day, int hour, int minute, int second)
        {
            for (; ; )              //用死循环来达到实时监测的效果
            {
                if (DateTime.Now.Year == year && DateTime.Now.Month == month
                                              && DateTime.Now.Day == day && DateTime.Now.Hour == hour
                                              && DateTime.Now.Minute == minute && DateTime.Now.Second == second)
                {
                    A();
                    return;         //退出死循环
                }
            }
        }
        public void SetClock(int month, int day, int hour, int minute, int second)
        {
            for (; ; )
            {
                if (DateTime.Now.Month == month
                                              && DateTime.Now.Day == day && DateTime.Now.Hour == hour
                                              && DateTime.Now.Minute == minute && DateTime.Now.Second == second)
                {
                    A();
                    return;
                }
            }
        }
        public void SetClock(int day, int hour, int minute, int second)
        {
            for (; ; )
            {
                if (DateTime.Now.Day == day && DateTime.Now.Hour == hour
                    && DateTime.Now.Minute == minute && DateTime.Now.Second == second)
                {
                    A();
                    return;
                }
            }
        }
        public void SetClock(int hour, int minute, int second)
        {
            for (; ; )
            {
                if (DateTime.Now.Hour == hour
                     && DateTime.Now.Minute == minute && DateTime.Now.Second == second)
                {
                    A();
                    return;
                }
            }
        }
        public void SetClock(int hour, int minute)
        {
            for (; ; )
            {
                if (DateTime.Now.Hour == hour
                    && DateTime.Now.Minute == minute)
                {
                    A();
                    return;
                }
            }
        }

        public event Action A;
    }
}