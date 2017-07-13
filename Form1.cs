using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seating1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            try {
                double dblA, dblB, dblC,dblOutA,dblOutB, dblOutC, dblTotal;
                dblA = Convert.ToDouble(txtA.Text);
                dblB = Convert.ToDouble(txtB.Text);
                dblC = Convert.ToDouble(txtC.Text);
                dblOutA = 15 * dblA;
                dblOutB = 12 * dblB;
                dblOutC = 9 * dblC;
                dblTotal = dblOutA + dblOutB + dblOutC;
                lblOutA.Text = "Class: A: " + dblOutA + "$";
                lblOutB.Text = "Class: B: " + dblOutB + "$";
                lblOutC.Text = "Class: C: " + dblOutC + "$";
                lblTotal.Text = "Total: " + dblTotal + "$";
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtA.Text = "";
            txtB.Text = "";
            txtC.Text = ""; 
            lblOutA.Text = "Class: A: ";
            lblOutB.Text = "Class: B: ";
            lblOutC.Text = "Class: C: ";
            lblTotal.Text = "Total: ";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
