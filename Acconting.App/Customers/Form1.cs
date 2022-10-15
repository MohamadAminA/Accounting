using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Acconting.App
{
    public partial class UICustomers : Form
    {
        public UICustomers()
        {
            InitializeComponent();
        }


        private void ValidatName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbName.Text))
            {
                e.Cancel = true;
                tbName.Focus();
                errorProviderName.SetError(tbName, "Name should not be left blank!");
            }
            else
            {
                e.Cancel = false;
                errorProviderName.SetError(tbName, "");
            }
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Enabled))
            {
                return;
            }

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            if (tbPhone.Text == "")
                return;
            string txt = tbPhone.Text;
            int tmp;
            for (int i = 0; i < txt.Length; i++)
            {
                if (int.TryParse(tbPhone.Text.Substring(i,1), out tmp) == false)
                {


                    txt = txt.Substring(0, i)+txt.Substring(i+1,txt.Length-(i+1));
                    tbPhone.Text = txt;
                }
            }
           
            //if (!(int.Parse(tbPhone.Text.Last().ToString()) <= 9 || int.Parse(tbPhone.Text.Last().ToString()) >= 0))


        }
    }
}
