using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public class Suppliers // Suppliers Class
    {
        private int supplier_id;
        private string supplier_name;


       public Suppliers()
        {
            supplier_id = -1;
            supplier_name = string.Empty;
        }


        public int Id // Supplier ID
        {
            get
            {
                return supplier_id;
            }

            set
            {
                supplier_id = value;
            }

        }
        public string SName // Supplier name
       {
           get
           {
               return supplier_name;
           }

           set
           {
                supplier_name = value;
           }
       }
    }
}
