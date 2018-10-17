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


        static public void AddOrder(int orderNum, string goodName, string client, double orderSum)//添加订单
        {
            allOrders.Add(new Order(orderNum, goodName, client, orderSum));
            count++;
        }



        static public void RemoveOrder(int orderNum)     //删除指定订单，根据订单号删
        {

            //foreach (var or in allOrders)
            //{
            //    if (or.OrderNum == orderNum)
            //    {
            //        allOrders.Remove(or);
            //        count--;
            //        return;
            //    }
            //}
            //Console.WriteLine("删除订单失败，没有与之相匹配的订单");

            try
            {
                var res = from order in allOrders where order.OrderNum == orderNum select order;
                Order a = res.Single();
                allOrders.Remove(a);
            }
            catch
            {
                Console.WriteLine("删除订单失败，没有与之相匹配的订单");
            }
        }

        static public void InquiryOrder(int orderNum)                 //根据订单号查询订单信息
        {
            //foreach (var or in allOrders)
            //{
            //    if (or.OrderNum == orderNum)
            //    {
            //        Console.WriteLine("订单号："+or.OrderNum+"  商品名称："+or.GoodName+"  客户："+or.Client);
            //        return;
            //    }
            //}
            try
            {
                var res = from order in allOrders where order.OrderNum == orderNum select order;
                Order a = res.Single();
                Console.WriteLine("订单号：" + a.OrderNum + "  商品名称：" + a.GoodName + "  客户：" + a.Client + "  订单金额：" + a.OrderSum);
            }
            catch
            {
                Console.WriteLine("查询订单失败，没有与之相匹配的订单");
            }

        }
        static public void InquiryOrder(string goodName)                 //根据商品名称查询订单信息
        {
            //foreach (var or in allOrders)
            //{
            //    if (or.OrderNum == orderNum)
            //    {
            //        Console.WriteLine("订单号："+or.OrderNum+"  商品名称："+or.GoodName+"  客户："+or.Client);
            //        return;
            //    }
            //}
            try
            {
                var res = from order in allOrders where order.GoodName == goodName select order;
                Order a = res.Single();
                Console.WriteLine("订单号：" + a.OrderNum + "  商品名称：" + a.GoodName + "  客户：" + a.Client + "  订单金额：" + a.OrderSum);
            }
            catch
            {
                Console.WriteLine("查询订单失败，没有与之相匹配的订单");
            }

        }

        static public void AmendOrder(int orderNum, string goodName, string client, double orderSum)
        {

            //foreach (var or in allOrders)
            //{
            //    if (or.OrderNum == orderNum)
            //    {
            //        or.GoodName = goodName;
            //        or.Client = client;
            //        return;
            //    }
            //}
            //Console.WriteLine("修改订单失败，没有与之相匹配的订单");

            try
            {
                var res = from order in allOrders where order.OrderNum == orderNum select order;
                Order a = res.Single();
                a.GoodName = goodName;
                a.Client = client;
                a.OrderSum = orderSum;
            }
            catch
            {
                Console.WriteLine("修改订单失败，没有与之相匹配的订单");
            }
        }


    }
}
