using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class products
    {
        private int prodid;

       
        public int ProductID
        {
            get { return prodid; }
            set
            {
                if (value > 0)
                {
                    prodid = value;
                }
                else
                {
                    Console.WriteLine("Product id not valid");
                }
            }
        }


        private string prodname;

        public string ProductName
        {
            get { return prodname; }
            set
            {
                if (value.Length > 0 && value.Length < 20)
                {
                    prodname = value;
                }
                else
                {
                    Console.WriteLine("Product name too long or too small.. Not valid");
                }

            }
        }

        private int price;

        public int Price
        {
            get { return price; }
            set { price = value; }
        }

        

        private int qty;

        public int Quantity
        {
            get { return qty; }
            set { qty = value; }
        }

        public decimal calculateDiscount()
        {
            decimal afterdiscountprice = 0;
            decimal amt=CalculateTotalPurchase(price, qty);
            if (amt > 1000 && amt< 5000)
            {
                decimal discount=Convert.ToDecimal(0.2);
                afterdiscountprice = amt-discount;
            }
            else if(amt > 5000 && amt < 10000)
            {
                decimal discount = Convert.ToDecimal(0.5);
                afterdiscountprice = amt - discount;
            }
            else
                afterdiscountprice=amt;
            return afterdiscountprice;
        }


        public decimal CalculateTotalPurchase(int price,int qty)
        {
            int todal=price*qty;
            return todal;
        }


    }

}
