using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS223LecAssignmentII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            double doubleAmount;
            if (txtAmount.Text != "")
            {
                try
                {
                    doubleAmount = Convert.ToDouble(txtAmount.Text);
                    double doubleVAT = 0.15 * doubleAmount;
                    txtVAT.Text = Convert.ToString(doubleVAT);
                    double doubleTotal = doubleAmount + doubleVAT;
                    txtTotal.Text = Convert.ToString(doubleTotal);
                }
                catch (Exception)
                {
                    MessageBox.Show("Please enter a numeric value.", "Invalid Input");
                    txtAmount.Clear();
                    txtVAT.Clear();
                    txtTotal.Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtAmount.Clear();
            txtVAT.Clear();
            txtTotal.Clear();
        }
    }
}
