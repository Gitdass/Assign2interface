using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Customer:products
    {
		private int custid;

		public int CustID
		{
			get { return custid; }
			set { custid = value; }
		}


		private string cname;

		public string  CName
		{
			get { return cname; }
			set { cname = value; }
		}

	}
}
