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
    public partial class ProductManagement : Form
    {
        public ProductManagement()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string productName = txtProductName.Text;
            string productType = txtProductType.Text;
            decimal price = Convert.ToDecimal(txtPrice.Text);

            string query = $"INSERT INTO Product (Product_Name, Product_Type, Price) VALUES ('{productName}', '{productType}', {price})";

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Product Added Successfully!");
            else
                MessageBox.Show("Error Adding Product");
        }
    }
}
