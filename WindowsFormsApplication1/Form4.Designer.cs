namespace WindowsFormsApplication1
{
    partial class Form4
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
            this.btnCloseProducts = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.contxtMenuProducts = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripDeleteProduct = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.contxtMenuProducts.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseProducts
            // 
            this.btnCloseProducts.Location = new System.Drawing.Point(201, 290);
            this.btnCloseProducts.Name = "btnCloseProducts";
            this.btnCloseProducts.Size = new System.Drawing.Size(75, 23);
            this.btnCloseProducts.TabIndex = 5;
            this.btnCloseProducts.Text = "Close";
            this.btnCloseProducts.UseVisualStyleBackColor = true;
            this.btnCloseProducts.Click += new System.EventHandler(this.btnCloseProducts_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AllowUserToOrderColumns = true;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.ContextMenuStrip = this.contxtMenuProducts;
            this.dgvProducts.Location = new System.Drawing.Point(30, 9);
            this.dgvProducts.MultiSelect = false;
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(404, 275);
            this.dgvProducts.TabIndex = 4;
            // 
            // contxtMenuProducts
            // 
            this.contxtMenuProducts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDeleteProduct});
            this.contxtMenuProducts.Name = "contxtMenuProducts";
            this.contxtMenuProducts.Size = new System.Drawing.Size(158, 26);
            // 
            // toolStripDeleteProduct
            // 
            this.toolStripDeleteProduct.Name = "toolStripDeleteProduct";
            this.toolStripDeleteProduct.Size = new System.Drawing.Size(157, 22);
            this.toolStripDeleteProduct.Text = "Delete Product";
            this.toolStripDeleteProduct.Click += new System.EventHandler(this.toolStripDeleteProduct_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.btnCloseProducts);
            this.Controls.Add(this.dgvProducts);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "Products List";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.contxtMenuProducts.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseProducts;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.ContextMenuStrip contxtMenuProducts;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteProduct;
    }
}