using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class OrderService
    {
        static List<Order> allOrders = new List<Order>();
        private static int count = 0;


        static public void AddOrder(int orderNum, string goodName, string client)//添加订单
        {
            allOrders.Add(new Order(orderNum, goodName, client));
            count++;
        }



        static public void RemoveOrder(int orderNum)     //删除指定订单，根据订单号删
        {

            foreach (var or in allOrders)
            {
                if (or.OrderNum == orderNum)
                {
                    allOrders.Remove(or);
                    count--;
                    return;
                }
            }
            Console.WriteLine("删除订单失败，没有与之相匹配的订单");
        }

        static public void InquiryOrder(int orderNum)                 //根据订单号查询订单信息
        {
            foreach (var or in allOrders)
            {
                if (or.OrderNum == orderNum)
                {
                    Console.WriteLine("订单号：" + or.OrderNum + "  商品名称：" + or.GoodName + "  客户：" + or.Client);
                    return;
                }
            }
            Console.WriteLine("查询订单失败，没有与之相匹配的订单");
        }

        static public void AmendOrder(int orderNum, string goodName, string client)
        {

            foreach (var or in allOrders)
            {
                if (or.OrderNum == orderNum)
                {
                    or.GoodName = goodName;
                    or.Client = client;
                    return;
                }
            }
            Console.WriteLine("修改订单失败，没有与之相匹配的订单");
        }


    }
}