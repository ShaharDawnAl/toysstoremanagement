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
    public partial class Form2 : Form
    {

        private DBSQL dataB;

        public Form2()
        {
            InitializeComponent();
        }

        public void filldgv() // fill DGV with Customers data
        {
            if (dataB.GetCustomersNumber() <= 0)
            {
                MessageBox.Show("No more items in table");
                this.Close();
                return;
            }
            dgvCustomers.RowCount = dataB.GetCustomersNumber();
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvCustomers.ColumnCount = 5;
            dgvCustomers.Columns[0].HeaderText = "ID AI";
            dgvCustomers.Columns[1].HeaderText = "ID";
            dgvCustomers.Columns[2].HeaderText = "First Name";
            dgvCustomers.Columns[3].HeaderText = "Last Name";
            dgvCustomers.Columns[4].HeaderText = "City";

            Customers[] customers;
            customers = dataB.GetCustomerData();

            for (int i = 0; i < customers.Length; i++)
            {
                dgvCustomers[0, i].Value = customers[i].Id.ToString();
                dgvCustomers[1, i].Value = customers[i].Ide.ToString();
                dgvCustomers[2, i].Value = customers[i].FName.ToString();
                dgvCustomers[3, i].Value = customers[i].LName.ToString();
                dgvCustomers[4, i].Value = customers[i].City.ToString();
            }
        }

        

        private void Form2_Load_1(object sender, EventArgs e)
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

        private void toolStripMenuDeleteCustomer_Click(object sender, EventArgs e) // Delete selected Customer
        {
            if (dgvCustomers.SelectedCells.Count > 0)
            {
                int rownum = dgvCustomers.CurrentCell.RowIndex;
                string value = dgvCustomers[0, rownum].Value.ToString();
                int id = Convert.ToInt32(value);
                dataB.DeleteCustomer(id);
                filldgv();
            }
        }

        private void btnCloseCustomers_Click(object sender, EventArgs e) // Close Form
        {
            this.Close();
        }
    }
}
