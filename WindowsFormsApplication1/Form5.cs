using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.IO;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507

namespace WindowsFormsApplication1
{
    public partial class Form5 : Form
    {
        private DBSQL dataB;
        public Form5()
        {
            InitializeComponent();
        }

        public void filldgv() // fill DGV with Orders data from DB
        {
            if (dataB.GetOrdersNumber() <= 0)
            {
                MessageBox.Show("No more items in table");
                this.Close();
                return;
            }
            dgvOrders.RowCount = dataB.GetOrdersNumber();
            dgvOrders.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvOrders.ColumnCount = 5;
            dgvOrders.Columns[0].HeaderText = "ID";
            dgvOrders.Columns[1].HeaderText = "Customer ID";
            dgvOrders.Columns[2].HeaderText = "Product Name";
            dgvOrders.Columns[3].HeaderText = "Supplier Name";
            dgvOrders.Columns[4].HeaderText = "Shipment Address";

            Orders[] orders;
            orders = dataB.GetOrderData();

            for (int i = 0; i < orders.Length; i++)
            {
                dgvOrders[0, i].Value = orders[i].Id.ToString();
                dgvOrders[1, i].Value = orders[i].CId.ToString();
                dgvOrders[2, i].Value = orders[i].PName.ToString();
                dgvOrders[3, i].Value = orders[i].SName.ToString();
                dgvOrders[4, i].Value = orders[i].CCity.ToString();
            }
        }

        private void btnCloseOrders_Click(object sender, EventArgs e) // Close Form
        {
            this.Close();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            string dbPath = Application.StartupPath + @"\DBsample.accdb";
            if (File.Exists(dbPath))
            {
                dataB = new DBSQL(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + dbPath + ";Persist Security Info=False;");

            }
            else
            {
                MessageBox.Show("DataBase" + dbPath + " not found");
                Application.Exit();
            }
            filldgv();
        }

        private void toolStripDeleteOrder_Click(object sender, EventArgs e) // Delete Selected Order from DB
        {
            if (dgvOrders.SelectedCells.Count > 0)
            {
                int rownum = dgvOrders.CurrentCell.RowIndex;
                string value = dgvOrders[0, rownum].Value.ToString();
                int id = Convert.ToInt32(value);
                dataB.DeleteOrder(id);
                filldgv();
            }
        }
    }
}
