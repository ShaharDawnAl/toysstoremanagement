namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.contxtMenuCustomers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuDeleteCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCloseCustomers = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.contxtMenuCustomers.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.AllowUserToAddRows = false;
            this.dgvCustomers.AllowUserToDeleteRows = false;
            this.dgvCustomers.AllowUserToOrderColumns = true;
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.ContextMenuStrip = this.contxtMenuCustomers;
            this.dgvCustomers.Location = new System.Drawing.Point(30, 12);
            this.dgvCustomers.MultiSelect = false;
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.Size = new System.Drawing.Size(404, 275);
            this.dgvCustomers.TabIndex = 0;
            // 
            // contxtMenuCustomers
            // 
            this.contxtMenuCustomers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuDeleteCustomer});
            this.contxtMenuCustomers.Name = "contxtMenuCustomers";
            this.contxtMenuCustomers.Size = new System.Drawing.Size(167, 26);
            // 
            // toolStripMenuDeleteCustomer
            // 
            this.toolStripMenuDeleteCustomer.Name = "toolStripMenuDeleteCustomer";
            this.toolStripMenuDeleteCustomer.Size = new System.Drawing.Size(166, 22);
            this.toolStripMenuDeleteCustomer.Text = "Delete Customer";
            this.toolStripMenuDeleteCustomer.Click += new System.EventHandler(this.toolStripMenuDeleteCustomer_Click);
            // 
            // btnCloseCustomers
            // 
            this.btnCloseCustomers.Location = new System.Drawing.Point(201, 293);
            this.btnCloseCustomers.Name = "btnCloseCustomers";
            this.btnCloseCustomers.Size = new System.Drawing.Size(75, 23);
            this.btnCloseCustomers.TabIndex = 3;
            this.btnCloseCustomers.Text = "Close";
            this.btnCloseCustomers.UseVisualStyleBackColor = true;
            this.btnCloseCustomers.Click += new System.EventHandler(this.btnCloseCustomers_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.btnCloseCustomers);
            this.Controls.Add(this.dgvCustomers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "Customers List";
            this.Load += new System.EventHandler(this.Form2_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.contxtMenuCustomers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.ContextMenuStrip contxtMenuCustomers;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuDeleteCustomer;
        private System.Windows.Forms.Button btnCloseCustomers;
    }
}