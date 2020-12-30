namespace WindowsFormsApplication1
{
    partial class Form3
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
            this.btnCloseSuppliers = new System.Windows.Forms.Button();
            this.dgvSuppliers = new System.Windows.Forms.DataGridView();
            this.contxtMenuSuppliers = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripDeleteSupplier = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).BeginInit();
            this.contxtMenuSuppliers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCloseSuppliers
            // 
            this.btnCloseSuppliers.Location = new System.Drawing.Point(203, 294);
            this.btnCloseSuppliers.Name = "btnCloseSuppliers";
            this.btnCloseSuppliers.Size = new System.Drawing.Size(75, 23);
            this.btnCloseSuppliers.TabIndex = 3;
            this.btnCloseSuppliers.Text = "Close";
            this.btnCloseSuppliers.UseVisualStyleBackColor = true;
            this.btnCloseSuppliers.Click += new System.EventHandler(this.btnCloseSuppliers_Click);
            // 
            // dgvSuppliers
            // 
            this.dgvSuppliers.AllowUserToAddRows = false;
            this.dgvSuppliers.AllowUserToDeleteRows = false;
            this.dgvSuppliers.AllowUserToOrderColumns = true;
            this.dgvSuppliers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSuppliers.ContextMenuStrip = this.contxtMenuSuppliers;
            this.dgvSuppliers.Location = new System.Drawing.Point(32, 13);
            this.dgvSuppliers.MultiSelect = false;
            this.dgvSuppliers.Name = "dgvSuppliers";
            this.dgvSuppliers.ReadOnly = true;
            this.dgvSuppliers.Size = new System.Drawing.Size(404, 275);
            this.dgvSuppliers.TabIndex = 2;
            // 
            // contxtMenuSuppliers
            // 
            this.contxtMenuSuppliers.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDeleteSupplier});
            this.contxtMenuSuppliers.Name = "contxtMenuSuppliers";
            this.contxtMenuSuppliers.Size = new System.Drawing.Size(158, 26);
            // 
            // toolStripDeleteSupplier
            // 
            this.toolStripDeleteSupplier.Name = "toolStripDeleteSupplier";
            this.toolStripDeleteSupplier.Size = new System.Drawing.Size(157, 22);
            this.toolStripDeleteSupplier.Text = "Delete Supplier";
            this.toolStripDeleteSupplier.Click += new System.EventHandler(this.toolStripDeleteSupplier_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 322);
            this.Controls.Add(this.btnCloseSuppliers);
            this.Controls.Add(this.dgvSuppliers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form3";
            this.Text = "Suppliers List";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSuppliers)).EndInit();
            this.contxtMenuSuppliers.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCloseSuppliers;
        private System.Windows.Forms.DataGridView dgvSuppliers;
        private System.Windows.Forms.ContextMenuStrip contxtMenuSuppliers;
        private System.Windows.Forms.ToolStripMenuItem toolStripDeleteSupplier;
    }
}