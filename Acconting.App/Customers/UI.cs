using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataBase;

namespace Acconting.App
{
    public partial class UI : Form
    {
        public UI()
        {

            InitializeComponent();
        }

        private void UI_Load(object sender, EventArgs e)
        {
            dgvCustomersTable.AutoGenerateColumns = false;
            Refresh_CustomersTable();


            ToolStripMain.AutoSize = true;
            ToolStripMain.Height = 100;
            ToolStripMain.Width = 100;
            this.ToolStripMain.ImageScalingSize = new Size(60, 60);
        }
        void Refresh_CustomersTable()
        {
            sql_DB sql_DB = new sql_DB();
            dgvCustomersTable.DataSource = sql_DB.DB.GetAll();
        }

        private void tsbAddCustomer_Click(object sender, EventArgs e)
        {
            UICustomers form = new UICustomers();
            form.ShowDialog();
            Refresh_CustomersTable();
        }

        private void tspRefreshTable_Click(object sender, EventArgs e)
        {
            Refresh_CustomersTable();
        }
    }
}
