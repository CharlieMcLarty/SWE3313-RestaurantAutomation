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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Add_Seat_1 = new System.Windows.Forms.Button();
            this.Add_Seat_2 = new System.Windows.Forms.Button();
            this.Add_Seat_3 = new System.Windows.Forms.Button();
            this.Add_Seat_4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seat 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(208, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seat 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(208, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Seat 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(208, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Seat 4";
            // 
            // Add_Seat_1
            // 
            this.Add_Seat_1.Location = new System.Drawing.Point(252, 126);
            this.Add_Seat_1.Name = "Add_Seat_1";
            this.Add_Seat_1.Size = new System.Drawing.Size(75, 23);
            this.Add_Seat_1.TabIndex = 4;
            this.Add_Seat_1.Text = "Add";
            this.Add_Seat_1.UseVisualStyleBackColor = true;
            this.Add_Seat_1.Click += new System.EventHandler(this.Add_Seat_1_Click);
            // 
            // Add_Seat_2
            // 
            this.Add_Seat_2.Location = new System.Drawing.Point(252, 156);
            this.Add_Seat_2.Name = "Add_Seat_2";
            this.Add_Seat_2.Size = new System.Drawing.Size(75, 23);
            this.Add_Seat_2.TabIndex = 5;
            this.Add_Seat_2.Text = "Add";
            this.Add_Seat_2.UseVisualStyleBackColor = true;
            // 
            // Add_Seat_3
            // 
            this.Add_Seat_3.Location = new System.Drawing.Point(252, 185);
            this.Add_Seat_3.Name = "Add_Seat_3";
            this.Add_Seat_3.Size = new System.Drawing.Size(75, 23);
            this.Add_Seat_3.TabIndex = 6;
            this.Add_Seat_3.Text = "Add";
            this.Add_Seat_3.UseVisualStyleBackColor = true;
            // 
            // Add_Seat_4
            // 
            this.Add_Seat_4.Location = new System.Drawing.Point(252, 214);
            this.Add_Seat_4.Name = "Add_Seat_4";
            this.Add_Seat_4.Size = new System.Drawing.Size(75, 23);
            this.Add_Seat_4.TabIndex = 7;
            this.Add_Seat_4.Text = "Add";
            this.Add_Seat_4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(412, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Add_Seat_4);
            this.Controls.Add(this.Add_Seat_3);
            this.Controls.Add(this.Add_Seat_2);
            this.Controls.Add(this.Add_Seat_1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Order";
            this.Text = "Order";
            this.ResumeLayout(false);
            this.PerformLayout();

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