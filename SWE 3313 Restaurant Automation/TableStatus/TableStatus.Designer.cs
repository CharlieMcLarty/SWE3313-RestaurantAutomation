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
            New_Order = new Button();
            Payment = new Button();
            Table_Status = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // New_Order
            // 
            New_Order.Location = new Point(142, 132);
            New_Order.Name = "New_Order";
            New_Order.Size = new Size(89, 23);
            New_Order.TabIndex = 0;
            New_Order.Text = "New Order";
            New_Order.UseVisualStyleBackColor = true;
            New_Order.Click += New_Order_Click;
            // 
            // Payment
            // 
            Payment.Location = new Point(142, 180);
            Payment.Name = "Payment";
            Payment.Size = new Size(89, 23);
            Payment.TabIndex = 1;
            Payment.Text = "Payment";
            Payment.UseVisualStyleBackColor = true;
            // 
            // Table_Status
            // 
            Table_Status.Location = new Point(142, 229);
            Table_Status.Name = "Table_Status";
            Table_Status.Size = new Size(89, 23);
            Table_Status.TabIndex = 2;
            Table_Status.Text = "Table Status";
            Table_Status.UseVisualStyleBackColor = true;
            Table_Status.Click += Table_Status_Click;
            // 
            // button1
            // 
            button1.Location = new Point(256, 386);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 3;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButton_Click;
            // 
            // TableStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(button1);
            Controls.Add(Table_Status);
            Controls.Add(Payment);
            Controls.Add(New_Order);
            Name = "TableStatus";
            Text = "TableStatus";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button New_Order;
        private System.Windows.Forms.Button Payment;
        private System.Windows.Forms.Button Table_Status;
        private Button button1;
    }
}