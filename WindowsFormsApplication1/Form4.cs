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
    public partial class Form4 : Form
    {
        private DBSQL dataB;
        public Form4()
        {
            InitializeComponent();
        }

        public void filldgv() // fill DGV with Products data from DB
        {
            if (dataB.GetProductsNumber() <= 0)
            {
                MessageBox.Show("No more items in table");
                this.Close();
                return;
            }
            dgvProducts.RowCount = dataB.GetProductsNumber();
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProducts.ColumnCount = 3;
            dgvProducts.Columns[0].HeaderText = "ID";
            dgvProducts.Columns[1].HeaderText = "Product Name";
            dgvProducts.Columns[2].HeaderText = "Supplier Name";

            Products[] products;
            products = dataB.GetProductData();

            for (int i = 0; i < products.Length; i++)
            {
                dgvProducts[0, i].Value = products[i].Id.ToString();
                dgvProducts[1, i].Value = products[i].PName.ToString();
                dgvProducts[2, i].Value = products[i].SName.ToString();
            }
        }

        private void btnCloseProducts_Click(object sender, EventArgs e) // Close Form
        {
            this.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
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

        private void toolStripDeleteProduct_Click(object sender, EventArgs e) // Delete Selected Product from DB
        {
            if (dgvProducts.SelectedCells.Count > 0)
            {
                int rownum = dgvProducts.CurrentCell.RowIndex;
                string value = dgvProducts[0, rownum].Value.ToString();
                int id = Convert.ToInt32(value);
                dataB.DeleteProduct(id);
                filldgv();
            }
        }
    }
}
