namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    partial class BeverageSelection
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(154, 66);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 0;
            button1.Text = "Coke";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Coke_Click;
            // 
            // button2
            // 
            button2.Location = new Point(154, 95);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Lemonade";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Lemonade_Click;
            // 
            // button3
            // 
            button3.Location = new Point(154, 124);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Sweet Tea";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Tea_Click;
            // 
            // button4
            // 
            button4.Location = new Point(154, 153);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "Coffee";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Coffee_Click;
            // 
            // BeverageSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(386, 292);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BeverageSelection";
            Text = "BeverageSelection";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}