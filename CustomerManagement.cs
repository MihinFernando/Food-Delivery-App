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
    public partial class CustomerManagement : Form
    {
        public CustomerManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contactNo = txtContact.Text;

            string query = $"INSERT INTO Customer (Cus_name, Address, Contact_Number) VALUES ('{name}', '{address}', '{contactNo}')";

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Customer Added Successfully!");
            else
                MessageBox.Show("Error Adding Customer");
        }
    }
}
