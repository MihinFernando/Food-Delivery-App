namespace FoodDeliveryApp
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOrders = new System.Windows.Forms.Button();
            this.btnPayments = new System.Windows.Forms.Button();
            this.btnCustomers = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.Panel3 = new System.Windows.Forms.Panel();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.lblTotalOrders = new System.Windows.Forms.Label();
            this.lblTotalCustomers = new System.Windows.Forms.Label();
            this.lblTotalSuppliers = new System.Windows.Forms.Label();
            this.lblTotalPayments = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvRecentOrders = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
            this.Panel3.SuspendLayout();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // btnOrders
            // 
            this.btnOrders.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrders.Location = new System.Drawing.Point(12, 12);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(496, 43);
            this.btnOrders.TabIndex = 33;
            this.btnOrders.Text = "Order Management";
            this.btnOrders.UseVisualStyleBackColor = false;
            this.btnOrders.Click += new System.EventHandler(this.btnOrders_Click);
            // 
            // btnPayments
            // 
            this.btnPayments.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayments.Location = new System.Drawing.Point(12, 110);
            this.btnPayments.Name = "btnPayments";
            this.btnPayments.Size = new System.Drawing.Size(496, 43);
            this.btnPayments.TabIndex = 34;
            this.btnPayments.Text = "Payment Management";
            this.btnPayments.UseVisualStyleBackColor = false;
            this.btnPayments.Click += new System.EventHandler(this.btnPayments_Click);
            // 
            // btnCustomers
            // 
            this.btnCustomers.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomers.Location = new System.Drawing.Point(12, 61);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(496, 43);
            this.btnCustomers.TabIndex = 35;
            this.btnCustomers.Text = "Customer Management";
            this.btnCustomers.UseVisualStyleBackColor = false;
            this.btnCustomers.Click += new System.EventHandler(this.btnCustomers_Click);
            // 
            // btnSupplier
            // 
            this.btnSupplier.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnSupplier.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSupplier.Location = new System.Drawing.Point(12, 159);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(496, 43);
            this.btnSupplier.TabIndex = 36;
            this.btnSupplier.Text = "Supplier Management";
            this.btnSupplier.UseVisualStyleBackColor = false;
            this.btnSupplier.Click += new System.EventHandler(this.btnSupplier_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProduct.Location = new System.Drawing.Point(12, 208);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(496, 43);
            this.btnProduct.TabIndex = 37;
            this.btnProduct.Text = "Product Management";
            this.btnProduct.UseVisualStyleBackColor = false;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblTotalOrders);
            this.panel1.Location = new System.Drawing.Point(1, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(303, 165);
            this.panel1.TabIndex = 38;
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel2.Controls.Add(this.label2);
            this.Panel2.Controls.Add(this.lblTotalCustomers);
            this.Panel2.Location = new System.Drawing.Point(333, 366);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(273, 165);
            this.Panel2.TabIndex = 39;
            // 
            // Panel3
            // 
            this.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel3.Controls.Add(this.label3);
            this.Panel3.Controls.Add(this.lblTotalSuppliers);
            this.Panel3.Location = new System.Drawing.Point(629, 366);
            this.Panel3.Name = "Panel3";
            this.Panel3.Size = new System.Drawing.Size(284, 165);
            this.Panel3.TabIndex = 39;
            // 
            // Panel4
            // 
            this.Panel4.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Panel4.Controls.Add(this.label4);
            this.Panel4.Controls.Add(this.lblTotalPayments);
            this.Panel4.Location = new System.Drawing.Point(933, 366);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(276, 165);
            this.Panel4.TabIndex = 39;
            // 
            // lblTotalOrders
            // 
            this.lblTotalOrders.AutoSize = true;
            this.lblTotalOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalOrders.Location = new System.Drawing.Point(111, 71);
            this.lblTotalOrders.Name = "lblTotalOrders";
            this.lblTotalOrders.Size = new System.Drawing.Size(85, 29);
            this.lblTotalOrders.TabIndex = 0;
            this.lblTotalOrders.Text = "label1";
            // 
            // lblTotalCustomers
            // 
            this.lblTotalCustomers.AutoSize = true;
            this.lblTotalCustomers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCustomers.Location = new System.Drawing.Point(92, 71);
            this.lblTotalCustomers.Name = "lblTotalCustomers";
            this.lblTotalCustomers.Size = new System.Drawing.Size(85, 29);
            this.lblTotalCustomers.TabIndex = 1;
            this.lblTotalCustomers.Text = "label1";
            // 
            // lblTotalSuppliers
            // 
            this.lblTotalSuppliers.AutoSize = true;
            this.lblTotalSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSuppliers.Location = new System.Drawing.Point(93, 71);
            this.lblTotalSuppliers.Name = "lblTotalSuppliers";
            this.lblTotalSuppliers.Size = new System.Drawing.Size(85, 29);
            this.lblTotalSuppliers.TabIndex = 2;
            this.lblTotalSuppliers.Text = "label2";
            // 
            // lblTotalPayments
            // 
            this.lblTotalPayments.AutoSize = true;
            this.lblTotalPayments.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPayments.Location = new System.Drawing.Point(78, 71);
            this.lblTotalPayments.Name = "lblTotalPayments";
            this.lblTotalPayments.Size = new System.Drawing.Size(85, 29);
            this.lblTotalPayments.TabIndex = 3;
            this.lblTotalPayments.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(73, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Orders";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(205, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Customers";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(192, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Total Suppliers";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Total Payments";
            // 
            // dgvRecentOrders
            // 
            this.dgvRecentOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecentOrders.Location = new System.Drawing.Point(580, 58);
            this.dgvRecentOrders.Name = "dgvRecentOrders";
            this.dgvRecentOrders.RowHeadersWidth = 51;
            this.dgvRecentOrders.RowTemplate.Height = 24;
            this.dgvRecentOrders.Size = new System.Drawing.Size(482, 255);
            this.dgvRecentOrders.TabIndex = 40;
            this.dgvRecentOrders.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRecentOrders_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(696, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 29);
            this.label5.TabIndex = 2;
            this.label5.Text = "Show recent orders";
            // 
            // button1
            // 
            this.button1.Image = global::FoodDeliveryApp.Properties.Resources.cross;
            this.button1.Location = new System.Drawing.Point(1214, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 49);
            this.button1.TabIndex = 41;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1291, 769);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvRecentOrders);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.Panel3);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnProduct);
            this.Controls.Add(this.btnSupplier);
            this.Controls.Add(this.btnCustomers);
            this.Controls.Add(this.btnPayments);
            this.Controls.Add(this.btnOrders);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Panel2.ResumeLayout(false);
            this.Panel2.PerformLayout();
            this.Panel3.ResumeLayout(false);
            this.Panel3.PerformLayout();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecentOrders)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrders;
        private System.Windows.Forms.Button btnPayments;
        private System.Windows.Forms.Button btnCustomers;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panel2;
        private System.Windows.Forms.Panel Panel3;
        private System.Windows.Forms.Panel Panel4;
        private System.Windows.Forms.Label lblTotalOrders;
        private System.Windows.Forms.Label lblTotalCustomers;
        private System.Windows.Forms.Label lblTotalSuppliers;
        private System.Windows.Forms.Label lblTotalPayments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvRecentOrders;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}