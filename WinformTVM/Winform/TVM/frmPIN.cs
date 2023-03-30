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
    public partial class frmPIN : Form
    {
        public static String username = "";
        public static string Username
        {
            get { return username; }
            set { username = value; }
        }
        public frmPIN()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Program.strConn);
            String sql = "Select Username, UserPin from AccountCredit where UserPin = '"+textBox1.Text+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                username = dt.Rows[0].Field<String>(0);
                this.Hide();
                frmDetails f = new frmDetails();
                f.Show();

            } else
            {
                MessageBox.Show("Invalid PIN","Warning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
