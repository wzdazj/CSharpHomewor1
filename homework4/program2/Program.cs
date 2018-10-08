using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService.AddOrder(201701, "裤子", "李华");  //添加订单
            OrderService.InquiryOrder(201701);           //查询订单
            OrderService.AddOrder(201702, "帽子", "张伟"); //添加订单
            OrderService.InquiryOrder(201702);           //查询订单
            OrderService.AddOrder(201801, "鞋子", "王明"); //添加订单
            OrderService.InquiryOrder(201801);           //查询订单

            OrderService.RemoveOrder(201702);             //删除订单
            OrderService.AmendOrder(201701, "裤子2", "小李");//修改订单
            OrderService.InquiryOrder(201701);

            OrderService.RemoveOrder(124124124);          //删除订单失败
            OrderService.AmendOrder(2343325, "asdas", "asdasd");//修改订单失败

        }
    }
}