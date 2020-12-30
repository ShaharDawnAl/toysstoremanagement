namespace WindowsFormsApplication1
{
    partial class Form5
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
            this.btnCloseOrders = new System.Windows.Forms.Button();
            this.dgvOrders = new System.Windows.Forms.DataGridView();
            this.contxtMenuOrders = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripDeleteOrder = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).BeginInit();
            this.contxtMenuOrders.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseOrders
            // 
            this.btnCloseOrders.Location = new System.Drawing.Point(201, 290);
            this.btnCloseOrders.Name = "btnCloseOrders";
            this.btnCloseOrders.Size = new System.Drawing.Size(75, 23);
            this.btnCloseOrders.TabIndex = 7;
            this.btnCloseOrders.Text = "Close";
            this.btnCloseOrders.UseVisualStyleBackColor = true;
            this.btnCloseOrders.Click += new System.EventHandler(this.btnCloseOrders_Click);
            // 
            // dgvOrders
            // 
            this.dgvOrders.AllowUserToAddRows = false;
            this.dgvOrders.AllowUserToDeleteRows = false;
            this.dgvOrders.AllowUserToOrderColumns = true;
            this.dgvOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrders.ContextMenuStrip = this.contxtMenuOrders;
            this.dgvOrders.Location = new System.Drawing.Point(30, 9);
            this.dgvOrders.MultiSelect = false;
            this.dgvOrders.Name = "dgvOrders";
            this.dgvOrders.ReadOnly = true;
            this.dgvOrders.Size = new System.Drawing.Size(404, 275);
            this.dgvOrders.TabIndex = 6;
            // 
            // contxtMenuOrders
            // 
            this.contxtMenuOrders.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDeleteOrder});
            this.contxtMenuOrders.Name = "contxtMenuOrders";
            this.contxtMenuOrders.Size = new System.Drawing.Size(153, 48);
            // 
            // toolStripDeleteOrder
            // 
            this.toolStripDeleteOrder.Name = "toolStripDeleteOrder";
            this.toolStripDeleteOrder.Size = new System.Drawing.Size(152, 22);
            this.toolStripDeleteOrder.Text = "Delete Order";
            this.toolStripDeleteOrder.Click += new System.EventHandler(this.toolStripDeleteOrder_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.btnCloseOrders);
            this.Controls.Add(this.dgvOrders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.Text = "Orders List";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrders)).EndInit();
            this.contxtMenuOrders.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseOrders;
        private System.Windows.Forms.DataGridView dgvOrders;
        private System.Windows.Forms.ContextMenuStrip contxtMenuOrders;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteOrder;
    }
}