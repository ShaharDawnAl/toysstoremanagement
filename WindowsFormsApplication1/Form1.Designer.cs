namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnCreateCustomerPDF = new System.Windows.Forms.Button();
            this.lblCID = new System.Windows.Forms.Label();
            this.txtCID = new System.Windows.Forms.TextBox();
            this.btnShowDeleteCustomer = new System.Windows.Forms.Button();
            this.lblCCity = new System.Windows.Forms.Label();
            this.txtCCity = new System.Windows.Forms.TextBox();
            this.lblCLName = new System.Windows.Forms.Label();
            this.txtCLName = new System.Windows.Forms.TextBox();
            this.lblCTitle = new System.Windows.Forms.Label();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lblCFName = new System.Windows.Forms.Label();
            this.txtCFName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnShowDeleteSupplier = new System.Windows.Forms.Button();
            this.lblSTitle = new System.Windows.Forms.Label();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbBoxPSName = new System.Windows.Forms.ComboBox();
            this.lblPSname = new System.Windows.Forms.Label();
            this.btnShowDeleteProduct = new System.Windows.Forms.Button();
            this.lblPTitle = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.lblPName = new System.Windows.Forms.Label();
            this.txtPName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbBoxCID = new System.Windows.Forms.ComboBox();
            this.cmbBoxPName = new System.Windows.Forms.ComboBox();
            this.lblOPName = new System.Windows.Forms.Label();
            this.btnShowDeleteOrder = new System.Windows.Forms.Button();
            this.lblOTitle = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.lblOCID = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dgvSearch = new System.Windows.Forms.DataGridView();
            this.cmbBoxSearchOpt = new System.Windows.Forms.ComboBox();
            this.lblSearchOpt = new System.Windows.Forms.Label();
            this.cmbBoxSearchBy = new System.Windows.Forms.ComboBox();
            this.lblTab = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(23, 28);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 332);
            this.tabControl1.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnCreateCustomerPDF);
            this.tabPage1.Controls.Add(this.lblCID);
            this.tabPage1.Controls.Add(this.txtCID);
            this.tabPage1.Controls.Add(this.btnShowDeleteCustomer);
            this.tabPage1.Controls.Add(this.lblCCity);
            this.tabPage1.Controls.Add(this.txtCCity);
            this.tabPage1.Controls.Add(this.lblCLName);
            this.tabPage1.Controls.Add(this.txtCLName);
            this.tabPage1.Controls.Add(this.lblCTitle);
            this.tabPage1.Controls.Add(this.btnAddCustomer);
            this.tabPage1.Controls.Add(this.lblCFName);
            this.tabPage1.Controls.Add(this.txtCFName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(376, 306);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnCreateCustomerPDF
            // 
            this.btnCreateCustomerPDF.Location = new System.Drawing.Point(251, 156);
            this.btnCreateCustomerPDF.Name = "btnCreateCustomerPDF";
            this.btnCreateCustomerPDF.Size = new System.Drawing.Size(75, 23);
            this.btnCreateCustomerPDF.TabIndex = 11;
            this.btnCreateCustomerPDF.Text = "Create PDF";
            this.btnCreateCustomerPDF.UseVisualStyleBackColor = true;
            this.btnCreateCustomerPDF.Click += new System.EventHandler(this.btnCreateCustomerPDF_Click);
            // 
            // lblCID
            // 
            this.lblCID.AutoSize = true;
            this.lblCID.Location = new System.Drawing.Point(34, 48);
            this.lblCID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCID.Name = "lblCID";
            this.lblCID.Size = new System.Drawing.Size(68, 13);
            this.lblCID.TabIndex = 10;
            this.lblCID.Text = "Customer ID:";
            // 
            // txtCID
            // 
            this.txtCID.Location = new System.Drawing.Point(140, 45);
            this.txtCID.Margin = new System.Windows.Forms.Padding(2);
            this.txtCID.MaxLength = 9;
            this.txtCID.Name = "txtCID";
            this.txtCID.Size = new System.Drawing.Size(204, 20);
            this.txtCID.TabIndex = 9;
            // 
            // btnShowDeleteCustomer
            // 
            this.btnShowDeleteCustomer.Location = new System.Drawing.Point(141, 156);
            this.btnShowDeleteCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDeleteCustomer.Name = "btnShowDeleteCustomer";
            this.btnShowDeleteCustomer.Size = new System.Drawing.Size(105, 24);
            this.btnShowDeleteCustomer.TabIndex = 8;
            this.btnShowDeleteCustomer.Text = "Show All/Delete...";
            this.btnShowDeleteCustomer.UseVisualStyleBackColor = true;
            this.btnShowDeleteCustomer.Click += new System.EventHandler(this.btnShowDeleteCustomer_Click);
            // 
            // lblCCity
            // 
            this.lblCCity.AutoSize = true;
            this.lblCCity.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCCity.Location = new System.Drawing.Point(34, 120);
            this.lblCCity.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCCity.Name = "lblCCity";
            this.lblCCity.Size = new System.Drawing.Size(73, 13);
            this.lblCCity.TabIndex = 7;
            this.lblCCity.Text = "Customer city:";
            // 
            // txtCCity
            // 
            this.txtCCity.Location = new System.Drawing.Point(140, 117);
            this.txtCCity.Margin = new System.Windows.Forms.Padding(2);
            this.txtCCity.MaxLength = 20;
            this.txtCCity.Name = "txtCCity";
            this.txtCCity.Size = new System.Drawing.Size(204, 20);
            this.txtCCity.TabIndex = 6;
            // 
            // lblCLName
            // 
            this.lblCLName.AutoSize = true;
            this.lblCLName.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblCLName.Location = new System.Drawing.Point(34, 96);
            this.lblCLName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCLName.Name = "lblCLName";
            this.lblCLName.Size = new System.Drawing.Size(102, 13);
            this.lblCLName.TabIndex = 5;
            this.lblCLName.Text = "Customer last name:";
            // 
            // txtCLName
            // 
            this.txtCLName.Location = new System.Drawing.Point(140, 93);
            this.txtCLName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCLName.MaxLength = 20;
            this.txtCLName.Name = "txtCLName";
            this.txtCLName.Size = new System.Drawing.Size(204, 20);
            this.txtCLName.TabIndex = 4;
            // 
            // lblCTitle
            // 
            this.lblCTitle.AutoSize = true;
            this.lblCTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblCTitle.Location = new System.Drawing.Point(93, 19);
            this.lblCTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCTitle.Name = "lblCTitle";
            this.lblCTitle.Size = new System.Drawing.Size(179, 16);
            this.lblCTitle.TabIndex = 3;
            this.lblCTitle.Text = "Add/Select/Delete Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(55, 156);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(82, 24);
            this.btnAddCustomer.TabIndex = 2;
            this.btnAddCustomer.Text = "Add";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lblCFName
            // 
            this.lblCFName.AutoSize = true;
            this.lblCFName.Location = new System.Drawing.Point(34, 72);
            this.lblCFName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCFName.Name = "lblCFName";
            this.lblCFName.Size = new System.Drawing.Size(102, 13);
            this.lblCFName.TabIndex = 1;
            this.lblCFName.Text = "Customer first name:";
            // 
            // txtCFName
            // 
            this.txtCFName.Location = new System.Drawing.Point(140, 69);
            this.txtCFName.Margin = new System.Windows.Forms.Padding(2);
            this.txtCFName.MaxLength = 20;
            this.txtCFName.Name = "txtCFName";
            this.txtCFName.Size = new System.Drawing.Size(204, 20);
            this.txtCFName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnShowDeleteSupplier);
            this.tabPage2.Controls.Add(this.lblSTitle);
            this.tabPage2.Controls.Add(this.btnAddSupplier);
            this.tabPage2.Controls.Add(this.lblSupplier);
            this.tabPage2.Controls.Add(this.txtSName);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(376, 306);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Suppliers";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnShowDeleteSupplier
            // 
            this.btnShowDeleteSupplier.Location = new System.Drawing.Point(182, 156);
            this.btnShowDeleteSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDeleteSupplier.Name = "btnShowDeleteSupplier";
            this.btnShowDeleteSupplier.Size = new System.Drawing.Size(105, 24);
            this.btnShowDeleteSupplier.TabIndex = 15;
            this.btnShowDeleteSupplier.Text = "Show All/Delete...";
            this.btnShowDeleteSupplier.UseVisualStyleBackColor = true;
            this.btnShowDeleteSupplier.Click += new System.EventHandler(this.btnShowDeleteSupplier_Click);
            // 
            // lblSTitle
            // 
            this.lblSTitle.AutoSize = true;
            this.lblSTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblSTitle.Location = new System.Drawing.Point(93, 19);
            this.lblSTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSTitle.Name = "lblSTitle";
            this.lblSTitle.Size = new System.Drawing.Size(179, 16);
            this.lblSTitle.TabIndex = 14;
            this.lblSTitle.Text = "Add/Select/Delete Suppliers";
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(96, 156);
            this.btnAddSupplier.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(82, 24);
            this.btnAddSupplier.TabIndex = 13;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(34, 49);
            this.lblSupplier.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(77, 13);
            this.lblSupplier.TabIndex = 12;
            this.lblSupplier.Text = "Supplier name:";
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(140, 46);
            this.txtSName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSName.MaxLength = 40;
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(204, 20);
            this.txtSName.TabIndex = 11;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbBoxPSName);
            this.tabPage3.Controls.Add(this.lblPSname);
            this.tabPage3.Controls.Add(this.btnShowDeleteProduct);
            this.tabPage3.Controls.Add(this.lblPTitle);
            this.tabPage3.Controls.Add(this.btnAddProduct);
            this.tabPage3.Controls.Add(this.lblPName);
            this.tabPage3.Controls.Add(this.txtPName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(376, 306);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Products";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Enter += new System.EventHandler(this.tabPage3_Enter);
            // 
            // cmbBoxPSName
            // 
            this.cmbBoxPSName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPSName.FormattingEnabled = true;
            this.cmbBoxPSName.Location = new System.Drawing.Point(140, 71);
            this.cmbBoxPSName.Name = "cmbBoxPSName";
            this.cmbBoxPSName.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxPSName.TabIndex = 23;
            // 
            // lblPSname
            // 
            this.lblPSname.AutoSize = true;
            this.lblPSname.Location = new System.Drawing.Point(34, 73);
            this.lblPSname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPSname.Name = "lblPSname";
            this.lblPSname.Size = new System.Drawing.Size(88, 13);
            this.lblPSname.TabIndex = 22;
            this.lblPSname.Text = "Product Supplier:";
            // 
            // btnShowDeleteProduct
            // 
            this.btnShowDeleteProduct.Location = new System.Drawing.Point(182, 156);
            this.btnShowDeleteProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDeleteProduct.Name = "btnShowDeleteProduct";
            this.btnShowDeleteProduct.Size = new System.Drawing.Size(105, 24);
            this.btnShowDeleteProduct.TabIndex = 20;
            this.btnShowDeleteProduct.Text = "Show All/Delete...";
            this.btnShowDeleteProduct.UseVisualStyleBackColor = true;
            this.btnShowDeleteProduct.Click += new System.EventHandler(this.btnShowDeleteProduct_Click);
            // 
            // lblPTitle
            // 
            this.lblPTitle.AutoSize = true;
            this.lblPTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblPTitle.Location = new System.Drawing.Point(93, 19);
            this.lblPTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPTitle.Name = "lblPTitle";
            this.lblPTitle.Size = new System.Drawing.Size(175, 16);
            this.lblPTitle.TabIndex = 19;
            this.lblPTitle.Text = "Add/Select/Delete Products";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(96, 156);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(82, 24);
            this.btnAddProduct.TabIndex = 18;
            this.btnAddProduct.Text = "Add";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // lblPName
            // 
            this.lblPName.AutoSize = true;
            this.lblPName.Location = new System.Drawing.Point(34, 49);
            this.lblPName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPName.Name = "lblPName";
            this.lblPName.Size = new System.Drawing.Size(76, 13);
            this.lblPName.TabIndex = 17;
            this.lblPName.Text = "Product name:";
            // 
            // txtPName
            // 
            this.txtPName.Location = new System.Drawing.Point(140, 46);
            this.txtPName.Margin = new System.Windows.Forms.Padding(2);
            this.txtPName.MaxLength = 40;
            this.txtPName.Name = "txtPName";
            this.txtPName.Size = new System.Drawing.Size(204, 20);
            this.txtPName.TabIndex = 16;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbBoxCID);
            this.tabPage4.Controls.Add(this.cmbBoxPName);
            this.tabPage4.Controls.Add(this.lblOPName);
            this.tabPage4.Controls.Add(this.btnShowDeleteOrder);
            this.tabPage4.Controls.Add(this.lblOTitle);
            this.tabPage4.Controls.Add(this.btnOrder);
            this.tabPage4.Controls.Add(this.lblOCID);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(376, 306);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Orders";
            this.tabPage4.UseVisualStyleBackColor = true;
            this.tabPage4.Enter += new System.EventHandler(this.tabPage4_Enter);
            // 
            // cmbBoxCID
            // 
            this.cmbBoxCID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxCID.FormattingEnabled = true;
            this.cmbBoxCID.Location = new System.Drawing.Point(140, 46);
            this.cmbBoxCID.Name = "cmbBoxCID";
            this.cmbBoxCID.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxCID.TabIndex = 31;
            // 
            // cmbBoxPName
            // 
            this.cmbBoxPName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxPName.FormattingEnabled = true;
            this.cmbBoxPName.Location = new System.Drawing.Point(140, 71);
            this.cmbBoxPName.Name = "cmbBoxPName";
            this.cmbBoxPName.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxPName.TabIndex = 30;
            // 
            // lblOPName
            // 
            this.lblOPName.AutoSize = true;
            this.lblOPName.Location = new System.Drawing.Point(34, 73);
            this.lblOPName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOPName.Name = "lblOPName";
            this.lblOPName.Size = new System.Drawing.Size(76, 13);
            this.lblOPName.TabIndex = 29;
            this.lblOPName.Text = "Product name:";
            // 
            // btnShowDeleteOrder
            // 
            this.btnShowDeleteOrder.Location = new System.Drawing.Point(182, 156);
            this.btnShowDeleteOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDeleteOrder.Name = "btnShowDeleteOrder";
            this.btnShowDeleteOrder.Size = new System.Drawing.Size(105, 24);
            this.btnShowDeleteOrder.TabIndex = 28;
            this.btnShowDeleteOrder.Text = "Show All/Delete...";
            this.btnShowDeleteOrder.UseVisualStyleBackColor = true;
            this.btnShowDeleteOrder.Click += new System.EventHandler(this.btnShowDeleteOrder_Click);
            // 
            // lblOTitle
            // 
            this.lblOTitle.AutoSize = true;
            this.lblOTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblOTitle.Location = new System.Drawing.Point(93, 19);
            this.lblOTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOTitle.Name = "lblOTitle";
            this.lblOTitle.Size = new System.Drawing.Size(163, 16);
            this.lblOTitle.TabIndex = 27;
            this.lblOTitle.Text = "Add/Select/Delete Orders";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(96, 156);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(82, 24);
            this.btnOrder.TabIndex = 26;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // lblOCID
            // 
            this.lblOCID.AutoSize = true;
            this.lblOCID.Location = new System.Drawing.Point(34, 49);
            this.lblOCID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOCID.Name = "lblOCID";
            this.lblOCID.Size = new System.Drawing.Size(68, 13);
            this.lblOCID.TabIndex = 25;
            this.lblOCID.Text = "Customer ID:";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dgvSearch);
            this.tabPage5.Controls.Add(this.cmbBoxSearchOpt);
            this.tabPage5.Controls.Add(this.lblSearchOpt);
            this.tabPage5.Controls.Add(this.cmbBoxSearchBy);
            this.tabPage5.Controls.Add(this.lblTab);
            this.tabPage5.Controls.Add(this.lblSearch);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(376, 306);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Search";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dgvSearch
            // 
            this.dgvSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearch.Location = new System.Drawing.Point(6, 100);
            this.dgvSearch.Name = "dgvSearch";
            this.dgvSearch.Size = new System.Drawing.Size(364, 200);
            this.dgvSearch.TabIndex = 37;
            // 
            // cmbBoxSearchOpt
            // 
            this.cmbBoxSearchOpt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSearchOpt.FormattingEnabled = true;
            this.cmbBoxSearchOpt.Location = new System.Drawing.Point(115, 73);
            this.cmbBoxSearchOpt.Name = "cmbBoxSearchOpt";
            this.cmbBoxSearchOpt.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxSearchOpt.TabIndex = 36;
            this.cmbBoxSearchOpt.Visible = false;
            this.cmbBoxSearchOpt.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSeachOpt_SelectedIndexChanged);
            // 
            // lblSearchOpt
            // 
            this.lblSearchOpt.AutoSize = true;
            this.lblSearchOpt.Location = new System.Drawing.Point(35, 76);
            this.lblSearchOpt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearchOpt.Name = "lblSearchOpt";
            this.lblSearchOpt.Size = new System.Drawing.Size(0, 13);
            this.lblSearchOpt.TabIndex = 35;
            // 
            // cmbBoxSearchBy
            // 
            this.cmbBoxSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxSearchBy.FormattingEnabled = true;
            this.cmbBoxSearchBy.Items.AddRange(new object[] {
            "All Products by specific Supplier",
            "All Order by specific Customer"});
            this.cmbBoxSearchBy.Location = new System.Drawing.Point(115, 46);
            this.cmbBoxSearchBy.Name = "cmbBoxSearchBy";
            this.cmbBoxSearchBy.Size = new System.Drawing.Size(204, 21);
            this.cmbBoxSearchBy.TabIndex = 34;
            this.cmbBoxSearchBy.SelectedIndexChanged += new System.EventHandler(this.cmbBoxSearchBy_SelectedIndexChanged);
            // 
            // lblTab
            // 
            this.lblTab.AutoSize = true;
            this.lblTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblTab.Location = new System.Drawing.Point(141, 19);
            this.lblTab.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTab.Name = "lblTab";
            this.lblTab.Size = new System.Drawing.Size(79, 16);
            this.lblTab.TabIndex = 33;
            this.lblTab.Text = "Search Tab";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(34, 49);
            this.lblSearch.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(59, 13);
            this.lblSearch.TabIndex = 32;
            this.lblSearch.Text = "Search By:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 407);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Toys Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearch)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label lblCFName;
        private System.Windows.Forms.TextBox txtCFName;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Label lblCTitle;
        private System.Windows.Forms.Button btnShowDeleteCustomer;
        private System.Windows.Forms.Label lblCCity;
        private System.Windows.Forms.TextBox txtCCity;
        private System.Windows.Forms.Label lblCLName;
        private System.Windows.Forms.TextBox txtCLName;
        private System.Windows.Forms.Label lblCID;
        private System.Windows.Forms.TextBox txtCID;
        private System.Windows.Forms.Button btnShowDeleteSupplier;
        private System.Windows.Forms.Label lblSTitle;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.ComboBox cmbBoxPSName;
        private System.Windows.Forms.Label lblPSname;
        private System.Windows.Forms.Button btnShowDeleteProduct;
        private System.Windows.Forms.Label lblPTitle;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Label lblPName;
        private System.Windows.Forms.TextBox txtPName;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ComboBox cmbBoxCID;
        private System.Windows.Forms.ComboBox cmbBoxPName;
        private System.Windows.Forms.Label lblOPName;
        private System.Windows.Forms.Button btnShowDeleteOrder;
        private System.Windows.Forms.Label lblOTitle;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label lblOCID;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.ComboBox cmbBoxSearchBy;
        private System.Windows.Forms.Label lblTab;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.DataGridView dgvSearch;
        private System.Windows.Forms.ComboBox cmbBoxSearchOpt;
        private System.Windows.Forms.Label lblSearchOpt;
        private System.Windows.Forms.Button btnCreateCustomerPDF;
    }
}

