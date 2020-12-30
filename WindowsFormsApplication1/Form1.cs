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
using iTextSharp;
using iTextSharp.text;
using iTextSharp.text.pdf;
// C# Project by Aviad Kattav 305200446, Shahar Alaluf 038101507
// הפרויקט מאפשר קליטת/הכנסת/מחיקת נתונים מתוך הבסיס נתונים של לקוחות/מוצרים מסוג צעצועים/ספקים

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        private DBSQL dataB;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) //on load connect to data base
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

        }

        private void btnAddCustomer_Click (object sender, EventArgs e) // Add customer to DB
        {
            int result;
            if ((txtCID.Text != "" && (int.TryParse(txtCID.Text,out result))!=false) && (txtCFName.Text != "" && (int.TryParse(txtCFName.Text, out result)) != true) && (txtCLName.Text != "" && (int.TryParse(txtCLName.Text, out result)) != true) && (txtCCity.Text != "" && (int.TryParse(txtCCity.Text, out result)) != true))
            {
                if (dataB.ReturntCustomers(Convert.ToInt32(txtCID.Text)) == 0)
                {
                    Customers c = new Customers();
                    c.Ide = Convert.ToInt32(txtCID.Text);
                    c.FName = txtCFName.Text;
                    c.LName = txtCLName.Text;
                    c.City = txtCCity.Text;
                    dataB.InsertCustomer(c);
                    MessageBox.Show("Customer added!");
                }
                else
                    MessageBox.Show("ID already exists!");
            }
            else
            {
                MessageBox.Show("Error");
            }

        }

        public void FillPSName() // Filling Combo Box with all Suppliers names in Products
        {
            Suppliers[] supArr;
            supArr = dataB.GetSupplierData();

            for (int i = 0; i < supArr.Length; i++)
            {
                cmbBoxPSName.Items.Add(supArr[i].SName);
            }

        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            cmbBoxPSName.Items.Clear();

            FillPSName();
        }

        public void FillCID() // Filling Combo Box with all Customers IDs in Products
        {
            Customers[] cusArr;
            cusArr = dataB.GetCustomerData();

            for (int i = 0; i < cusArr.Length; i++)
            {
                cmbBoxCID.Items.Add(cusArr[i].Ide);
            }

        }

        public void FillPName() // Filling Combo Box with all Products Names
        {
            Products[] proArr;
            proArr = dataB.GetProductData();

            for (int i = 0; i < proArr.Length; i++)
            {
                cmbBoxPName.Items.Add(proArr[i].PName);
            }

        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            cmbBoxCID.Items.Clear();
            cmbBoxPName.Items.Clear();

            FillCID();
            FillPName();
        }

        private void btnShowDeleteCustomer_Click(object sender, EventArgs e) // Open form to show all/delete customers from DB
        {
            if (dataB.GetCustomersNumber()>0)
            {
                Form2 newForm = new Form2();
                newForm.Show();
            }
            else
                MessageBox.Show("There are no items in table");
        }

        private void btnAddSupplier_Click(object sender, EventArgs e) // Add Supplier to DB
        {
            int result;
            if ((txtSName.Text != "" && (int.TryParse(txtSName.Text, out result)) != true))
            {
                if (dataB.ReturntSuppliers(txtSName.Text) == 0)
                {
                    Suppliers s = new Suppliers();
                    s.SName = txtSName.Text;
                    dataB.InsertSupplier(s);
                    MessageBox.Show("Supplier added!");
                }
                else
                    MessageBox.Show("Supplier already exists!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShowDeleteSupplier_Click(object sender, EventArgs e) // Open form to show all/delete suppliers from DB
        {
            if (dataB.GetSuppliersNumber() > 0)
            {
                Form3 newForm = new Form3();
                newForm.Show();
            }
            else
                MessageBox.Show("There are no items in table");
        }

        private void btnAddProduct_Click(object sender, EventArgs e) // Add Product to DB
        {
            int result;
            if ((txtPName.Text != "" && (int.TryParse(txtPName.Text, out result)) != true) && cmbBoxPSName.SelectedItem != null)
            {
                if (dataB.ReturntProducts(txtPName.Text) == 0)
                {
                    Products p = new Products();
                    p.PName = txtPName.Text;
                    p.SName = cmbBoxPSName.SelectedItem.ToString();
                    dataB.InsertProduct(p);
                    MessageBox.Show("Product added!");
                }
                else
                    MessageBox.Show("Product already exists!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShowDeleteProduct_Click(object sender, EventArgs e) // Open form to show all/delete products from DB
        {
            if (dataB.GetProductsNumber() > 0)
            {
                Form4 newForm = new Form4();
                newForm.Show();
            }
            else
                MessageBox.Show("There are no items in table");
        }

        private void btnOrder_Click(object sender, EventArgs e) // Add an Order to DB
        {
            if (cmbBoxCID.SelectedItem != null && cmbBoxPName.SelectedItem != null)
            {
                Orders o = new Orders();
                o.CId = Convert.ToInt32(cmbBoxCID.SelectedItem.ToString());
                o.PName = cmbBoxPName.SelectedItem.ToString();
                o.SName = dataB.GetSupplierByPName(o.PName);
                o.CCity = dataB.GetCityByCID(Convert.ToInt32(cmbBoxCID.SelectedItem));
                dataB.InsertOrder(o);
                MessageBox.Show("Order confirmed!");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btnShowDeleteOrder_Click(object sender, EventArgs e) // Open form to show all/delete orders from DB
        {
            if (dataB.GetOrdersNumber() > 0)
            {
                Form5 newForm = new Form5();
                newForm.Show();
            }
            else
                MessageBox.Show("There are no items in table");
        }

        public void FillSSName() // Filling Combo Box with all Suppliers names in Search tab
        {
            Suppliers[] supArr;
            supArr = dataB.GetSupplierData();

            for (int i = 0; i < supArr.Length; i++)
            {
                cmbBoxSearchOpt.Items.Add(supArr[i].SName);
            }

        }

        public void FillSC() // Filling Combo Box with all Customers IDs in search
        {
            Customers[] cusArr;
            cusArr = dataB.GetCustomerData();

            for (int i = 0; i < cusArr.Length; i++)
            {
                cmbBoxSearchOpt.Items.Add(cusArr[i].Ide);
            }

        }

        private void cmbBoxSearchBy_SelectedIndexChanged(object sender, EventArgs e) // check selected in Search By Combo Box
        {
            if (cmbBoxSearchBy.SelectedIndex == 0)
            {
                cmbBoxSearchOpt.Items.Clear();
                lblSearchOpt.Visible = true;
                lblSearchOpt.Text = "Supplier name:";
                cmbBoxSearchOpt.Visible = true;
                FillSSName();
            }
            if (cmbBoxSearchBy.SelectedIndex == 1)
            {
                cmbBoxSearchOpt.Items.Clear();
                lblSearchOpt.Visible = true;
                lblSearchOpt.Text = "Customer ID:";
                cmbBoxSearchOpt.Visible = true;
                FillSC();
            }
        }

        public void filldgvCustomer(int cid) // fill the DGV if Customers selected
        {
            if (dataB.GetSearchOrdersNumber(cid) <= 0)
            {
                MessageBox.Show("No items in table");
                return;
            }
            dgvSearch.RowCount = dataB.GetSearchOrdersNumber(cid);
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearch.ColumnCount = 5;
            dgvSearch.Columns[0].HeaderText = "Order ID";
            dgvSearch.Columns[1].HeaderText = "Customer ID";
            dgvSearch.Columns[2].HeaderText = "Product Name";
            dgvSearch.Columns[3].HeaderText = "Supplier Name";
            dgvSearch.Columns[4].HeaderText = "Shipment Address";

            Orders[] orders;
            orders = dataB.GetSearchOrderData(cid);

            for (int i = 0; i < orders.Length; i++)
            {
                dgvSearch[0, i].Value = orders[i].Id.ToString();
                dgvSearch[1, i].Value = orders[i].CId.ToString();
                dgvSearch[2, i].Value = orders[i].PName.ToString();
                dgvSearch[3, i].Value = orders[i].SName.ToString();
                dgvSearch[4, i].Value = orders[i].CCity.ToString();
            }
        }

        public void filldgvSupplier(string sname) // fill the DGV if Suppliers selected
        {
            if (dataB.GetSearchSuppliersNumber(sname) <= 0)
            {
                MessageBox.Show("No items in table");
                return;
            }
            dgvSearch.RowCount = dataB.GetSearchSuppliersNumber(sname);
            dgvSearch.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvSearch.ColumnCount = 3;
            dgvSearch.Columns[0].HeaderText = "Product ID";
            dgvSearch.Columns[1].HeaderText = "Product Name";
            dgvSearch.Columns[2].HeaderText = "Supplier Name";

            Products[] products;
            products = dataB.GetSearchSupplierData(sname);

            for (int i = 0; i < products.Length; i++)
            {
                dgvSearch[0, i].Value = products[i].Id.ToString();
                dgvSearch[1, i].Value = products[i].PName.ToString();
                dgvSearch[2, i].Value = products[i].SName.ToString();
            }
        }

        private void cmbBoxSeachOpt_SelectedIndexChanged(object sender, EventArgs e) // check selected in Search Option Combo Box
        {
            if (cmbBoxSearchBy.SelectedIndex == 0)
            {
                string sname = cmbBoxSearchOpt.SelectedItem.ToString();
                filldgvSupplier(sname);
            }

            if (cmbBoxSearchBy.SelectedIndex == 1)
            {
                int cid = Convert.ToInt32(cmbBoxSearchOpt.SelectedItem.ToString());
                filldgvCustomer(cid);
            }
        }

        private void btnCreateCustomerPDF_Click(object sender, EventArgs e) // Create a PDF to present Customers List
        {
            Customers[] custs;
            custs = dataB.GetCustomerData();
            string countcusts = dataB.GetCustomersNumber().ToString();

            pdfReport pdfDoc = new pdfReport();
            pdfDoc.SetTitle("Customers Report");
            pdfDoc.SetImage("customers.jpg");
            pdfDoc.SetCounter(countcusts);
            pdfDoc.SetCustomersTable(custs);

            pdfDoc.CloseReport();
            MessageBox.Show("PDF created successfully!");
        }
    }
}