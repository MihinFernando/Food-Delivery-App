using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; // If using SQL Server
using Oracle.ManagedDataAccess.Client; // If using Oracle


namespace FoodDeliveryApp
{
    public partial class SupplierManagement : Form
    {
        public SupplierManagement()
        {
            InitializeComponent();
            LoadSupplierIds();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contactNo = txtContact.Text;
            string username = txtUName.Text;
            string password = txtPassword.Text;

            string query = $"INSERT INTO Supplier (Name, Address, ContactNo, Username, Password) VALUES ('{name}', '{address}', '{contactNo}', '{username}', '{password}')";

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Supplier Added Successfully!");
            else
                MessageBox.Show("Error Adding Supplier");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(cmbSupplierId.Text);
            string name = txtName.Text;
            string address = txtAddress.Text;
            string contactNo = txtContact.Text;
            string username = txtUName.Text;
            string password = txtPassword.Text;

            string query = $"UPDATE Supplier SET Name='{name}', Address='{address}', ContactNo='{contactNo}', Username='{username}', Password='{password}' WHERE SupplierID={supplierId}";

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Supplier Updated Successfully!");
            else
                MessageBox.Show("Error Updating Supplier");
        }

        private void LoadSupplierIds()
        {
            string query = "SELECT SupplierID FROM Supplier";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.ExecuteQuery(query);

            // Add a new row for "Add New Supplier"
            DataRow newRow = dt.NewRow();
            newRow["SupplierID"] = -1;  // Use -1 as a special identifier for "Add New Supplier"
            dt.Rows.InsertAt(newRow, 0);

            // Bind the updated DataTable to the ComboBox
            cmbSupplierId.DataSource = dt;
            cmbSupplierId.DisplayMember = "SupplierID";
            cmbSupplierId.ValueMember = "SupplierID";

            // Set default selection to "Add New Supplier"
            cmbSupplierId.SelectedIndex = 0;
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSupplierId.SelectedItem != null)
            {
                DataRowView drv = cmbSupplierId.SelectedItem as DataRowView;
                if (drv != null)
                {
                    int selectedId = Convert.ToInt32(drv["SupplierID"]);

                    if (selectedId == -1)
                    {
                        // Clear textboxes to add a new supplier
                        txtName.Text = "";
                        txtAddress.Text = "";
                        txtContact.Text = "";
                        txtUName.Text = "";
                        txtPassword.Text = "";
                    }
                    else
                    {
                        // Load existing supplier details
                        LoadSupplierDetails(selectedId);
                    }
                }
            }
        }

        // Function to load supplier details into textboxes
        private void LoadSupplierDetails(int supplierId)
        {
            string query = $"SELECT Name, Address, ContactNo, Username, Password FROM Supplier WHERE SupplierID = {supplierId}";
            DatabaseHelper db = new DatabaseHelper();
            DataTable dt = db.ExecuteQuery(query);

            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                txtName.Text = row["Name"].ToString();
                txtAddress.Text = row["Address"].ToString();
                txtContact.Text = row["ContactNo"].ToString();
                txtUName.Text = row["Username"].ToString();
                txtPassword.Text = row["Password"].ToString();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int supplierId = Convert.ToInt32(cmbSupplierId.Text);
            string query = $"DELETE FROM Supplier WHERE SupplierID={supplierId}";

            DatabaseHelper db = new DatabaseHelper();
            int result = db.ExecuteNonQuery(query);

            if (result > 0)
                MessageBox.Show("Supplier Deleted Successfully!");
            else
                MessageBox.Show("Error Deleting Supplier");
        }
    }
}
