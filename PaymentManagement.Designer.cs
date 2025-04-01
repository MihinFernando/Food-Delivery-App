namespace FoodDeliveryApp
{
    partial class PaymentManagement
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
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label4;
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cmbSupplierId = new System.Windows.Forms.ComboBox();
            this.cmbCustomerId = new System.Windows.Forms.ComboBox();
            this.cmbPaymentType = new System.Windows.Forms.ComboBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(377, 344);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 31);
            this.btnAdd.TabIndex = 32;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(178, 259);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(151, 25);
            label2.TabIndex = 31;
            label2.Text = "Payment Type";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(243, 200);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(86, 25);
            label3.TabIndex = 29;
            label3.Text = "Amount";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(344, 204);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(164, 22);
            this.txtAmount.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(210, 137);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(119, 25);
            label1.TabIndex = 27;
            label1.Text = "Supplier ID";
            // 
            // cmbSupplierId
            // 
            this.cmbSupplierId.FormattingEnabled = true;
            this.cmbSupplierId.Location = new System.Drawing.Point(344, 137);
            this.cmbSupplierId.Name = "cmbSupplierId";
            this.cmbSupplierId.Size = new System.Drawing.Size(164, 24);
            this.cmbSupplierId.TabIndex = 26;
            this.cmbSupplierId.SelectedIndexChanged += new System.EventHandler(this.cmbSupplierId_SelectedIndexChanged);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(197, 76);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 25);
            label4.TabIndex = 25;
            label4.Text = "Customer ID";
            // 
            // cmbCustomerId
            // 
            this.cmbCustomerId.FormattingEnabled = true;
            this.cmbCustomerId.Location = new System.Drawing.Point(344, 76);
            this.cmbCustomerId.Name = "cmbCustomerId";
            this.cmbCustomerId.Size = new System.Drawing.Size(164, 24);
            this.cmbCustomerId.TabIndex = 24;
            this.cmbCustomerId.SelectedIndexChanged += new System.EventHandler(this.cmbCustomerId_SelectedIndexChanged);
            // 
            // cmbPaymentType
            // 
            this.cmbPaymentType.FormattingEnabled = true;
            this.cmbPaymentType.Items.AddRange(new object[] {
            "Cach",
            "Paypal",
            "Credit Card"});
            this.cmbPaymentType.Location = new System.Drawing.Point(344, 263);
            this.cmbPaymentType.Name = "cmbPaymentType";
            this.cmbPaymentType.Size = new System.Drawing.Size(164, 24);
            this.cmbPaymentType.TabIndex = 33;
            // 
            // PaymentManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbPaymentType);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(label2);
            this.Controls.Add(label3);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(label1);
            this.Controls.Add(this.cmbSupplierId);
            this.Controls.Add(label4);
            this.Controls.Add(this.cmbCustomerId);
            this.Name = "PaymentManagement";
            this.Text = "PaymentManagement";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cmbSupplierId;
        private System.Windows.Forms.ComboBox cmbCustomerId;
        private System.Windows.Forms.ComboBox cmbPaymentType;
    }
}