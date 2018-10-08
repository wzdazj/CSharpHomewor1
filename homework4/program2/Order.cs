using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Order
    {
        private int orderNum;
        private string goodName;
        private string client;

        public Order(int orderNum, string goodName, string client)
        {
            this.orderNum = orderNum;
            this.goodName = goodName;
            this.client = client;
        }

        public int OrderNum
        {
            get { return orderNum; }
            set { orderNum = value; }
        }
        public string GoodName
        {
            get { return goodName; }
            set { goodName = value; }
        }
        public string Client
        {
            get { return client; }
            set { client = value; }
        }
    }
}