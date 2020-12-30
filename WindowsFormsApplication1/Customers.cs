using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class Customers // Customers Class
    {
        private int customer_ide;
        private int customer_id;
        private string customer_fname;
        private string customer_lname;
        private string customer_city;

        public Customers()
        {
            customer_ide = -1;
            customer_id = -1;
            customer_fname = string.Empty;
            customer_lname = string.Empty;
            customer_city = string.Empty;

        }

        public int Ide // Customer ID get,set
        {
            get
            {
                return customer_ide;
            }

            set
            {
                customer_ide = value;
            }
        }

        public int Id // Customer AI ID get,set
        {
            get 
            {
                return customer_id;
            }

            set
            {
                customer_id = value;
            }
        }

        public string FName // Customer First name get,set
        {
            get
            {
                return customer_fname;
            }

            set
            {
                customer_fname = value;
            }
        }

        public string LName // Customer Last name get,set
        {
            get
            {
                return customer_lname;
            }

            set
            {
                customer_lname = value;
            }
        }

        public string City // Customer City get,set
        {
            get
            {
                return customer_city;
            }

            set
            {
                customer_city = value;
            }
        }

    }
}
