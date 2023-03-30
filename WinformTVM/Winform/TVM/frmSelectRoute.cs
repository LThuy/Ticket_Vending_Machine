using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TVM
{
    public partial class frmSelectRoute : Form
    {
        public static String Departure = "Ben Thanh";
        public static String Arrival = "";
        public static int price = 0;
        public static int number = 0;

        public static string arrival
        {
            get { return Arrival; }
            set { Arrival = value; }
        }

        public static int Number
        {
            get { return number; }
            set {number = value; }
        }

        public static int Price
        {
            get { return price; }
            set { price = value; }
        }


        public frmSelectRoute()
        {
            InitializeComponent();
        }

        public void routeSelected(Button button)
        {
            foreach (var buttonL in this.Controls.OfType<Button>())
            {
                button.ForeColor = Color.LightGray;
                buttonL.BackColor = Color.LimeGreen;
            }
            button.BackColor = Color.Yellow;
            button.ForeColor = Color.Black;
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            routeSelected(button2);
            Arrival = button2.Text;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            routeSelected(button3);
            Arrival = button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            routeSelected(button4);
            Arrival = button4.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            routeSelected(button8);
            Arrival = button8.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            routeSelected(button5);
            Arrival = button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            routeSelected(button6);
            Arrival = button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            routeSelected(button7);
            Arrival = button7.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            routeSelected(button10);
            Arrival = button10.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            routeSelected(button9);
            Arrival = button9.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            routeSelected(button11);
            Arrival = button11.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            routeSelected(button12);
            Arrival = button12.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            String sql = "Select price from RouteP where Arrival = '"+Arrival+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                number = Convert.ToInt32(numericUpDown1.Value);
                if(number == 0)
                {
                    MessageBox.Show("Please choose a number", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                } else
                {
                    price = dt.Rows[0].Field<int>(0);
                    this.Hide();
                    frmSelectPayment f = new frmSelectPayment();
                    f.Show();
                }            
            }

        }
    }
}
