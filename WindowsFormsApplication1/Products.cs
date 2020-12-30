using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class Products // Products Class
    {
        private int product_id;
        private string product_name;
        private string product_sname;


        public Products()
        {
            product_id = -1;
            product_name = string.Empty;
            product_sname = string.Empty;
        }

        public Products(string pname,string sname)
        {
            product_id = -1;
            product_name = pname;
            product_sname = sname;
        }


        public int Id // Product ID
        {
            get
            {
                return product_id;
            }

            set
            {
                product_id = value;
            }
        }


        public string PName // Product name
        {
            get
            {
                return product_name;
            }

            set
            {
                product_name = value;
            }

        }

        public string SName // Product Supplier name
        {
            get
            {
                return product_sname;
            }

            set
            {
                product_sname = value;
            }

        }

    }
}
