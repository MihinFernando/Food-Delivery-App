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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            LoadDashboardData();
        }

        private void btnOrders_Click(object sender, EventArgs e)
        {
            OrderManagement orderForm = new OrderManagement();
            orderForm.Show();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            CustomerManagement customerForm = new CustomerManagement();
            customerForm.Show();
        }

        private void btnPayments_Click(object sender, EventArgs e)
        {
            PaymentManagement paymentForm = new PaymentManagement();
            paymentForm.Show();
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            SupplierManagement supplierForm = new SupplierManagement();
            supplierForm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            ProductManagement productForm = new ProductManagement();
            productForm.Show();
        }
        private void LoadDashboardData()
        {
            try
            {
                DatabaseHelper db = new DatabaseHelper();

                // Get total orders
                string orderQuery = "SELECT COUNT(*) FROM Orders";
                lblTotalOrders.Text = Convert.ToInt32(db.ExecuteScalar(orderQuery) ?? 0).ToString();

                // Get total customers
                string customerQuery = "SELECT COUNT(*) FROM Customer";
                lblTotalCustomers.Text = Convert.ToInt32(db.ExecuteScalar(customerQuery) ?? 0).ToString();

                // Get total suppliers
                string supplierQuery = "SELECT COUNT(*) FROM Supplier";
                lblTotalSuppliers.Text = Convert.ToInt32(db.ExecuteScalar(supplierQuery) ?? 0).ToString();

                // Get total payments
                string paymentQuery = "SELECT COUNT(*) FROM Customer_Payment";
                lblTotalPayments.Text = Convert.ToInt32(db.ExecuteScalar(paymentQuery) ?? 0).ToString();

                // Load recent orders into DataGridView
                LoadRecentOrders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard data: " + ex.Message);
            }
        }

        private void dgvRecentOrders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadRecentOrders()
        {
            string query = "SELECT Order_ID, Order_Amount, Order_Date FROM Orders ORDER BY Order_Date DESC FETCH FIRST 5 ROWS ONLY";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.ExecuteQuery(query);

            dgvRecentOrders.DataSource = dt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
