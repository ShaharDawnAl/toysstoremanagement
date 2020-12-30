using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507
// הפרויקט מאפשר קליטת/הכנסת/מחיקת נתונים מתוך הבסיס נתונים של לקוחות/מוצרים מסוג צעצועים/ספקים

namespace WindowsFormsApplication1
{
    static class Program
    {
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
