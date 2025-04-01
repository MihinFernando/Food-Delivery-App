using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodDeliveryApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUName.Text;
            string password = txtPassword.Text;

            DatabaseHelper db = new DatabaseHelper();
            string query = $"SELECT COUNT(*) FROM Supplier WHERE Username = '{username}' AND Password = '{password}'";

            DataTable dt = db.ExecuteQuery(query);
            int count = Convert.ToInt32(dt.Rows[0][0]);

            if (count > 0)
            {
                MessageBox.Show("Login Successful!");
                this.Hide();
                new Dashboard().Show();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
