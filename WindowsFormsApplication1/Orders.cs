using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class Orders // Orders Class
    {
        private int order_id;
        private int order_cid;
        private string order_pname;
        private string order_sname;
        private string order_ccity;


        public Orders()
        {
            order_id = -1;
            order_cid = -1;
            order_pname = string.Empty;
            order_sname = string.Empty;
            order_ccity = string.Empty;
        }

        public Orders(int cid, string pname, string sname, string ccity)
        {
            order_id = -1;
            order_cid = cid;
            order_pname = pname;
            order_sname = sname;
            order_ccity = ccity;
        }


        public int Id // Order ID
        {
            get
            {
                return order_id;
            }

            set
            {
                order_id = value;
            }
        }

        public int CId // Order Customer ID
        {
            get
            {
                return order_cid;
            }

            set
            {
                order_cid = value;
            }
        }

        public string PName // Order Product name
        {
            get
            {
                return order_pname;
            }

            set
            {
                order_pname = value;
            }

        }

        public string SName // Order Supplier name
        {
            get
            {
                return order_sname;
            }

            set
            {
                order_sname = value;
            }

        }

        public string CCity // Order Shipment Address
        {
            get
            {
                return order_ccity;
            }

            set
            {
                order_ccity = value;
            }

        }

    }
}
