using Microsoft.VisualStudio.TestTools.UnitTesting;
using Program2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        [TestMethod()]
        public void AddOrderTest()
        {
            int a = OrderService.test();
            OrderService.AddOrder(1, "商品", "客户");
            Assert.AreEqual(OrderService.test(), a + 1);
        }
        [TestMethod()]
        public void RemoveOrderTest()
        {
            OrderService.AddOrder(1, "商品", "客户");
            int a = OrderService.test();
            OrderService.RemoveOrder(1);
            Assert.AreEqual(OrderService.test(), a - 1);
        }

        [TestMethod()]
        public void AmendOrderTest()
        {
            OrderService.AddOrder(2, "商品", "客户");
            OrderService.AmendOrder(2, "ss", "ss");
            Order temp = OrderService.AllOrder(2);
            Assert.AreEqual(temp.GoodName, "ss");
            Assert.AreEqual(temp.Client, "ss");
        }
    }
}