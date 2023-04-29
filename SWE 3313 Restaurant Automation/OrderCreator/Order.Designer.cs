namespace SWE_3313_Project
{
    partial class Order
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Add_Seat_1 = new Button();
            Add_Seat_2 = new Button();
            Add_Seat_3 = new Button();
            Add_Seat_4 = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(208, 130);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "Seat 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 156);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "Seat 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(208, 185);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "Seat 3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(208, 214);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "Seat 4";
            // 
            // Add_Seat_1
            // 
            Add_Seat_1.Location = new Point(252, 126);
            Add_Seat_1.Name = "Add_Seat_1";
            Add_Seat_1.Size = new Size(75, 23);
            Add_Seat_1.TabIndex = 4;
            Add_Seat_1.Text = "Add";
            Add_Seat_1.UseVisualStyleBackColor = true;
            Add_Seat_1.Click += Add_Seat_1_Click;
            // 
            // Add_Seat_2
            // 
            Add_Seat_2.Location = new Point(252, 156);
            Add_Seat_2.Name = "Add_Seat_2";
            Add_Seat_2.Size = new Size(75, 23);
            Add_Seat_2.TabIndex = 5;
            Add_Seat_2.Text = "Add";
            Add_Seat_2.UseVisualStyleBackColor = true;
            Add_Seat_2.Click += Add_Seat_2_Click;
            // 
            // Add_Seat_3
            // 
            Add_Seat_3.Location = new Point(252, 185);
            Add_Seat_3.Name = "Add_Seat_3";
            Add_Seat_3.Size = new Size(75, 23);
            Add_Seat_3.TabIndex = 6;
            Add_Seat_3.Text = "Add";
            Add_Seat_3.UseVisualStyleBackColor = true;
            Add_Seat_3.Click += Add_Seat_3_Click;
            // 
            // Add_Seat_4
            // 
            Add_Seat_4.Location = new Point(252, 214);
            Add_Seat_4.Name = "Add_Seat_4";
            Add_Seat_4.Size = new Size(75, 23);
            Add_Seat_4.TabIndex = 7;
            Add_Seat_4.Text = "Add";
            Add_Seat_4.UseVisualStyleBackColor = true;
            Add_Seat_4.Click += Add_Seat_4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(412, 375);
            button1.Name = "button1";
            button1.Size = new Size(89, 23);
            button1.TabIndex = 8;
            button1.Text = "Back";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Order
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 450);
            Controls.Add(button1);
            Controls.Add(Add_Seat_4);
            Controls.Add(Add_Seat_3);
            Controls.Add(Add_Seat_2);
            Controls.Add(Add_Seat_1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Order";
            Text = "Order";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Add_Seat_1;
        private System.Windows.Forms.Button Add_Seat_2;
        private System.Windows.Forms.Button Add_Seat_3;
        private System.Windows.Forms.Button Add_Seat_4;
        private Button button1;
    }
}