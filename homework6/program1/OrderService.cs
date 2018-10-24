using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
namespace Program2
{
    public class OrderService
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

        static public void Export()
        {
            Order[] orders = new Order[allOrders.Count];
            for (int i = 0; i < allOrders.Count; i++)
            {
                orders[i] = allOrders[i];
            }

            String xmlFileName = "s.xml";
            FileStream fs = new FileStream("s.xml", FileMode.Create);
            XmlSerializer xmlser = new XmlSerializer(typeof(Order[]));
            xmlser.Serialize(fs, orders);
            fs.Close();
        }

        static public void Inport()
        {
            FileStream fs = new FileStream("s.xml", FileMode.Open);
            XmlSerializer xs = new XmlSerializer(typeof(Order[]));
            Order[] orders = (Order[])xs.Deserialize(fs);
            foreach (var temp in orders)
            {
                allOrders.Add(temp);
            }
        }


        static public int test()
        {
            return allOrders.Count;
        }

        static public Order AllOrder(int ordernum)
        {
            Order a = new Order();
            foreach (var temp in allOrders)
            {
                if (temp.OrderNum == ordernum)
                {
                    a = temp;
                }
            }

            return a;
        }
    }
}