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
    public partial class PaymentManagement : Form
    {
        private bool isCustomerLoaded = false;
        private bool isSupplierLoaded = false;
        public PaymentManagement()
        {
            InitializeComponent();
            LoadSupplierIds();
            LoadCustomerIds();
        }
        private void LoadSupplierIds()
        {
            string query = "SELECT SupplierID FROM Supplier";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.ExecuteQuery(query);

            cmbSupplierId.DataSource = dt;
            cmbSupplierId.DisplayMember = "SupplierID";
            cmbSupplierId.ValueMember = "SupplierID";

            isSupplierLoaded = true;  // ✅ Set flag after data loads
        }


        private void LoadCustomerIds()
        {
            string query = "SELECT Customer_ID FROM Customer";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.ExecuteQuery(query);

            cmbCustomerId.DataSource = dt;
            cmbCustomerId.DisplayMember = "Customer_ID";
            cmbCustomerId.ValueMember = "Customer_ID";

            isCustomerLoaded = true;  //Set flag after data loads
        }

        private void cmbCustomerId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isCustomerLoaded) return; //Ignore event on form load

            if (cmbCustomerId.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbCustomerId.SelectedItem;
                int selectedCustomerId = Convert.ToInt32(drv["Customer_ID"]);
                MessageBox.Show("Selected Customer ID: " + selectedCustomerId);
            }
        }

        private void cmbSupplierId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isSupplierLoaded) return; // ✅ Skip event on form load

            if (cmbSupplierId.SelectedItem != null)
            {
                DataRowView drv = (DataRowView)cmbSupplierId.SelectedItem;
                int selectedSupplierId = Convert.ToInt32(drv["SupplierID"]);
                MessageBox.Show("Selected Supplier ID: " + selectedSupplierId);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int customerId = Convert.ToInt32(cmbCustomerId.Text);
            int supplierId = Convert.ToInt32(cmbSupplierId.Text);
            decimal amount = Convert.ToDecimal(txtAmount.Text);
            string paymentType = cmbPaymentType.Text;

            string query = $"INSERT INTO Customer_Payment (P_type, Payment_Date, P_status, Amount, Supplier_Id, Customer_Id) VALUES ('{paymentType}', SYSDATE, 'Completed', {amount}, {supplierId}, {customerId})";

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Payment Recorded Successfully!");
            else
                MessageBox.Show("Error Recording Payment");
        }
    }
}
