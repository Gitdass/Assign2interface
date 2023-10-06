using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum paymentmode
    {
        cash,
        upi,
        netbanking,
        depit,
        credit
    }
    public class order : Customer



    {





        private int orderid;
        public int OrderID
        {
            get { return orderid; }
            set { orderid = value; }
        }
        private DateTime orderdate;

        public DateTime OrderDate
        {
            get { return orderdate; }
            set { orderdate = value; }
        }
        private paymentmode paymode;

        public paymentmode GetPaymentmode
        {
            get { return paymode; }
            set { paymode = value; }
        }


        public void Bookorder(int CustID, DateTime Orderdate, paymentmode paymode, int qty, int price)
        {
            Console.WriteLine("Your Booked order was sucessfully");
            decimal amt = CalculateTotalPurchase(price, qty);
            Console.WriteLine($"order booked for customerid = {CustID}  on  {Orderdate},payment received by {paymode} for a qty of {qty}And the price of {price}and the Todal price= {amt}");

        }
    }

}
