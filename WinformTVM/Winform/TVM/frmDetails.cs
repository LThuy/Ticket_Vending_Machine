using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVM
{
    public partial class frmDetails : Form
    {
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            label6.Text = frmSelectRoute.Number.ToString();
            label7.Text = frmPIN.Username;
            label8.Text = frmSelectRoute.Departure + " - " + frmSelectRoute.arrival;
            int price = frmSelectRoute.Price * frmSelectRoute.Number;
            label9.Text = price.ToString()  + " VND";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmOutro f = new frmOutro();
            f.Show();
        }
    }
}
