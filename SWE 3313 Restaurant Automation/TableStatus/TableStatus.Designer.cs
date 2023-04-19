namespace SWE_3313_Project
{
    partial class TableStatus
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
            this.New_Order = new System.Windows.Forms.Button();
            this.Payment = new System.Windows.Forms.Button();
            this.Table_Status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // New_Order
            // 
            this.New_Order.Location = new System.Drawing.Point(142, 132);
            this.New_Order.Name = "New_Order";
            this.New_Order.Size = new System.Drawing.Size(89, 23);
            this.New_Order.TabIndex = 0;
            this.New_Order.Text = "New Order";
            this.New_Order.UseVisualStyleBackColor = true;
            this.New_Order.Click += new System.EventHandler(this.New_Order_Click);
            // 
            // Payment
            // 
            this.Payment.Location = new System.Drawing.Point(142, 180);
            this.Payment.Name = "Payment";
            this.Payment.Size = new System.Drawing.Size(89, 23);
            this.Payment.TabIndex = 1;
            this.Payment.Text = "Payment";
            this.Payment.UseVisualStyleBackColor = true;
            // 
            // Table_Status
            // 
            this.Table_Status.Location = new System.Drawing.Point(142, 229);
            this.Table_Status.Name = "Table_Status";
            this.Table_Status.Size = new System.Drawing.Size(89, 23);
            this.Table_Status.TabIndex = 2;
            this.Table_Status.Text = "Table Status";
            this.Table_Status.UseVisualStyleBackColor = true;
            // 
            // TableStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 450);
            this.Controls.Add(this.Table_Status);
            this.Controls.Add(this.Payment);
            this.Controls.Add(this.New_Order);
            this.Name = "TableStatus";
            this.Text = "TableStatus";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button New_Order;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button Table_Status;
    }
}