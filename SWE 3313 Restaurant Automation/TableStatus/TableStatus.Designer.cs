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
            button1 = new Button();
            radioButton1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            button2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // New_Order
            // 
            New_Order.Location = new Point(142, 90);
            New_Order.Name = "New_Order";
            New_Order.Size = new Size(89, 23);
            New_Order.TabIndex = 0;
            New_Order.Text = "Add to Order";
            New_Order.UseVisualStyleBackColor = true;
            New_Order.Click += AddToOrderClick;
            // 
            // Payment
            // 
            Payment.Location = new Point(142, 180);
            Payment.Name = "Payment";
            Payment.Size = new Size(89, 23);
            Payment.TabIndex = 1;
            Payment.Text = "Payment";
            Payment.UseVisualStyleBackColor = true;
            Payment.Click += Payment_Click;
            // 
            // button1
            // 
            button1.Location = new Point(256, 386);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 3;
            button1.Text = "Done";
            button1.UseVisualStyleBackColor = true;
            button1.Click += BackButton_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(6, 22);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 19);
            radioButton1.TabIndex = 4;
            radioButton1.TabStop = true;
            radioButton1.Text = "Clean";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButtonClean_CheckedChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Location = new Point(145, 228);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(86, 100);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Table Status";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(7, 75);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 19);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Dirty";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButtonDirty_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 47);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(44, 19);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Full";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButtonFull_CheckedChanged;
            // 
            // button2
            // 
            button2.Location = new Point(142, 136);
            button2.Name = "button2";
            button2.Size = new Size(89, 23);
            button2.TabIndex = 6;
            button2.Text = "New Order";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // TableStatus
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 450);
            Controls.Add(button2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(Payment);
            Controls.Add(New_Order);
            Name = "TableStatus";
            Text = "TableStatus";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button New_Order;
        private System.Windows.Forms.Button Payment;
        private Button button1;
        private RadioButton radioButton1;
        private GroupBox groupBox1;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private Button button2;
    }
}