namespace FoodDeliveryApp
{
    partial class OrderManagement
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.cmbSupplierId = new System.Windows.Forms.ComboBox();
            this.txtOrderAmount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            label4 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(202, 94);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 25);
            label4.TabIndex = 16;
            label4.Text = "Customer ID";
            // 
            // cmbCustomerId
            // 
            this.cmbCustomerId.FormattingEnabled = true;
            this.cmbCustomerId.Location = new System.Drawing.Point(349, 94);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(164, 24);
            this.cmbCustomerId.TabIndex = 15;
            this.cmbCustomerId.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerId_SelectedIndexChanged);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(215, 155);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 25);
            label1.TabIndex = 18;
            label1.Text = "Supplier ID";
            // 
            // cmbSupplierId
            // 
            this.cmbSupplierId.FormattingEnabled = true;
            this.cmbSupplierId.Location = new System.Drawing.Point(349, 155);
            this.cmbSupplierId.Name = "cmbSupplierId";
            this.cmbSupplierId.Size = new System.Drawing.Size(164, 24);
            this.cmbSupplierId.TabIndex = 17;
            this.cmbSupplierId.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierId_SelectedIndexChanged);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(187, 218);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(147, 25);
            label3.TabIndex = 20;
            label3.Text = "Order Amount";
            // 
            // txtOrderAmount
            // 
            this.txtOrderAmount.Location = new System.Drawing.Point(349, 222);
            this.txtOrderAmount.Name = "txtOrderAmount";
            this.txtOrderAmount.Size = new System.Drawing.Size(164, 22);
            this.txtOrderAmount.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(241, 277);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 25);
            label2.TabIndex = 22;
            label2.Text = "Quantity";
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(349, 280);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(164, 22);
            this.txtQuantity.TabIndex = 21;
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(396, 360);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 31);
            this.btnAdd.TabIndex = 23;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(label2);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtOrderAmount);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbSupplierId);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbCustomerId);
            this.Name = "OrderManagement";
            this.Text = "OrderManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.ComboBox cmbSupplierId;
        private System.Windows.Forms.TextBox txtOrderAmount;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAdd;
    }
}