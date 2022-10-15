namespace Acconting.App
{
    partial class UI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UI));
            this.dgvCustomersTable = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_Photo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ToolStripMain = new System.Windows.Forms.ToolStrip();
            this.tsbAddCustomer = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteCoustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.tspRefreshTable = new System.Windows.Forms.ToolStripButton();
            this.accountingDataSet = new Acconting.App.AccountingDataSet();
            this.tblAccountingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblAccountingTableAdapter = new Acconting.App.AccountingDataSetTableAdapters.tblAccountingTableAdapter();
            this.tblAccountingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersTable)).BeginInit();
            this.ToolStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountingBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomersTable
            // 
            this.dgvCustomersTable.AllowUserToAddRows = false;
            this.dgvCustomersTable.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.dgvCustomersTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCustomersTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCustomersTable.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvCustomersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomersTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.customer_Name,
            this.customer_Phone,
            this.customer_Address,
            this.customer_Email,
            this.customer_Photo});
            this.dgvCustomersTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvCustomersTable.Location = new System.Drawing.Point(0, 250);
            this.dgvCustomersTable.Name = "dgvCustomersTable";
            this.dgvCustomersTable.ReadOnly = true;
            this.dgvCustomersTable.RowHeadersWidth = 102;
            this.dgvCustomersTable.RowTemplate.Height = 40;
            this.dgvCustomersTable.Size = new System.Drawing.Size(1764, 658);
            this.dgvCustomersTable.TabIndex = 0;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 12;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // customer_Name
            // 
            this.customer_Name.DataPropertyName = "Name";
            this.customer_Name.HeaderText = "Name";
            this.customer_Name.MinimumWidth = 12;
            this.customer_Name.Name = "customer_Name";
            this.customer_Name.ReadOnly = true;
            // 
            // customer_Phone
            // 
            this.customer_Phone.DataPropertyName = "Phone";
            this.customer_Phone.HeaderText = "Phone";
            this.customer_Phone.MinimumWidth = 12;
            this.customer_Phone.Name = "customer_Phone";
            this.customer_Phone.ReadOnly = true;
            // 
            // customer_Address
            // 
            this.customer_Address.DataPropertyName = "Address";
            this.customer_Address.HeaderText = "Address";
            this.customer_Address.MinimumWidth = 12;
            this.customer_Address.Name = "customer_Address";
            this.customer_Address.ReadOnly = true;
            // 
            // customer_Email
            // 
            this.customer_Email.DataPropertyName = "Email";
            this.customer_Email.HeaderText = "Email";
            this.customer_Email.MinimumWidth = 12;
            this.customer_Email.Name = "customer_Email";
            this.customer_Email.ReadOnly = true;
            // 
            // customer_Photo
            // 
            this.customer_Photo.DataPropertyName = "Photo";
            this.customer_Photo.HeaderText = "Photo";
            this.customer_Photo.MinimumWidth = 12;
            this.customer_Photo.Name = "customer_Photo";
            this.customer_Photo.ReadOnly = true;
            this.customer_Photo.Visible = false;
            // 
            // ToolStripMain
            // 
            this.ToolStripMain.BackColor = System.Drawing.Color.FloralWhite;
            this.ToolStripMain.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.ToolStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAddCustomer,
            this.tsbDeleteCoustomer,
            this.toolStripButton1,
            this.tspRefreshTable});
            this.ToolStripMain.Location = new System.Drawing.Point(0, 0);
            this.ToolStripMain.Name = "ToolStripMain";
            this.ToolStripMain.Size = new System.Drawing.Size(1764, 150);
            this.ToolStripMain.TabIndex = 1;
            this.ToolStripMain.Text = "toolStrip1";
            // 
            // tsbAddCustomer
            // 
            this.tsbAddCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tsbAddCustomer.Font = new System.Drawing.Font("Comic Sans MS", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbAddCustomer.ForeColor = System.Drawing.Color.Salmon;
            this.tsbAddCustomer.Image = global::Acconting.App.Properties.Resources.icons8_add_file_100;
            this.tsbAddCustomer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbAddCustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbAddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddCustomer.Name = "tsbAddCustomer";
            this.tsbAddCustomer.Size = new System.Drawing.Size(205, 143);
            this.tsbAddCustomer.Text = "Add Customer";
            this.tsbAddCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.tsbAddCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbAddCustomer.Click += new System.EventHandler(this.tsbAddCustomer_Click);
            // 
            // tsbDeleteCoustomer
            // 
            this.tsbDeleteCoustomer.Font = new System.Drawing.Font("Comic Sans MS", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbDeleteCoustomer.ForeColor = System.Drawing.Color.Salmon;
            this.tsbDeleteCoustomer.Image = global::Acconting.App.Properties.Resources.icons8_remove_100;
            this.tsbDeleteCoustomer.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbDeleteCoustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteCoustomer.Name = "tsbDeleteCoustomer";
            this.tsbDeleteCoustomer.Size = new System.Drawing.Size(239, 143);
            this.tsbDeleteCoustomer.Text = "Delete Customer";
            this.tsbDeleteCoustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Font = new System.Drawing.Font("Comic Sans MS", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripButton1.ForeColor = System.Drawing.Color.Salmon;
            this.toolStripButton1.Image = global::Acconting.App.Properties.Resources.icons8_create_100;
            this.toolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(207, 143);
            this.toolStripButton1.Text = "Edit Customer";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // tspRefreshTable
            // 
            this.tspRefreshTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tspRefreshTable.Font = new System.Drawing.Font("Comic Sans MS", 8.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tspRefreshTable.ForeColor = System.Drawing.Color.Salmon;
            this.tspRefreshTable.Image = global::Acconting.App.Properties.Resources.refresh;
            this.tspRefreshTable.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tspRefreshTable.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tspRefreshTable.Name = "tspRefreshTable";
            this.tspRefreshTable.Size = new System.Drawing.Size(184, 143);
            this.tspRefreshTable.Text = "Refresh List";
            this.tspRefreshTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.tspRefreshTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tspRefreshTable.Click += new System.EventHandler(this.tspRefreshTable_Click);
            // 
            // accountingDataSet
            // 
            this.accountingDataSet.DataSetName = "AccountingDataSet";
            this.accountingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblAccountingBindingSource
            // 
            this.tblAccountingBindingSource.DataMember = "tblAccounting";
            this.tblAccountingBindingSource.DataSource = this.accountingDataSet;
            // 
            // tblAccountingTableAdapter
            // 
            this.tblAccountingTableAdapter.ClearBeforeFill = true;
            // 
            // tblAccountingBindingSource1
            // 
            this.tblAccountingBindingSource1.DataMember = "tblAccounting";
            this.tblAccountingBindingSource1.DataSource = this.accountingDataSet;
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 46F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1764, 908);
            this.Controls.Add(this.ToolStripMain);
            this.Controls.Add(this.dgvCustomersTable);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            //this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "UI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personal Accounting";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomersTable)).EndInit();
            this.ToolStripMain.ResumeLayout(false);
            this.ToolStripMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountingDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblAccountingBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomersTable;
        private System.Windows.Forms.ToolStrip ToolStripMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_Photo;
        private AccountingDataSet accountingDataSet;
        private System.Windows.Forms.BindingSource tblAccountingBindingSource;
        private AccountingDataSetTableAdapters.tblAccountingTableAdapter tblAccountingTableAdapter;
        private System.Windows.Forms.BindingSource tblAccountingBindingSource1;
        private System.Windows.Forms.ToolStripButton tsbAddCustomer;
        private System.Windows.Forms.ToolStripButton tsbDeleteCoustomer;
        private System.Windows.Forms.ToolStripButton tspRefreshTable;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

