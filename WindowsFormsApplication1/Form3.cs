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
    public partial class Form3 : Form
    {
        private DBSQL dataB;
        public Form3()
        {
            InitializeComponent();
        }

        public void filldgv() // fill DGV with Suppliers data from DB
        {
            if (dataB.GetSuppliersNumber() <= 0)
            {
                MessageBox.Show("No more items in table");
                this.Close();
                return;
            }
            dgvSuppliers.RowCount = dataB.GetSuppliersNumber();
            dgvSuppliers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSuppliers.ColumnCount = 2;
            dgvSuppliers.Columns[0].HeaderText = "ID";
            dgvSuppliers.Columns[1].HeaderText = "Supplier Name";

            Suppliers[] suppliers;
            suppliers = dataB.GetSupplierData();

            for (int i = 0; i < suppliers.Length; i++)
            {
                dgvSuppliers[0, i].Value = suppliers[i].Id.ToString();
                dgvSuppliers[1, i].Value = suppliers[i].SName.ToString();
            }
        }

        private void Form3_Load(object sender, EventArgs e)
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

        private void toolStripDeleteSupplier_Click(object sender, EventArgs e) // Delete Selected Supplier
        {
            if (dgvSuppliers.SelectedCells.Count > 0)
            {
                int rownum = dgvSuppliers.CurrentCell.RowIndex;
                string value = dgvSuppliers[0, rownum].Value.ToString();
                int id = Convert.ToInt32(value);
                dataB.DeleteSupplier(id);
                filldgv();
            }
        }

        private void btnCloseSuppliers_Click(object sender, EventArgs e) // Close Form
        {
            this.Close();
        }
    }
}
