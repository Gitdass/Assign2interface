using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace IOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
           products p = new products();
            Console.WriteLine("Enter Product ID:");
            p.ProductID=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Price:");
            p.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Qty:");
            p.Quantity=Convert.ToInt32(Console.ReadLine());

           Customer c=new Customer();
            Console.WriteLine("Enter Customerid:");
            c.CustID=Convert.ToInt32(Console.ReadLine());
            order o=new order();
            int orderid = o.OrderID + 1;
            Console.WriteLine("orderid:" + orderid);
            Console.WriteLine("Enter Order Date:");
            o.OrderDate=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("PAYMENT MODE");
            o.GetPaymentmode=(paymentmode)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"you selected the payment mode={o.GetPaymentmode}");

            o.Bookorder(c.CustID,o.OrderDate,o.GetPaymentmode,p.Quantity,p.Price);

            Console.ReadLine();



        }
    }
}
