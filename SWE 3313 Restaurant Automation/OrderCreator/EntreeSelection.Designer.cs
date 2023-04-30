namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    partial class EntreeSelection
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
            button1.Location = new Point(137, 63);
            button1.Name = "button1";
            button1.Size = new Size(128, 23);
            button1.TabIndex = 0;
            button1.Text = "Caribbean Chicken";
            button1.UseVisualStyleBackColor = true;
            button1.Click += CC_Click;
            // 
            // button2
            // 
            button2.Location = new Point(137, 92);
            button2.Name = "button2";
            button2.Size = new Size(128, 23);
            button2.TabIndex = 1;
            button2.Text = "Shrimp and Grits";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ShrimpGrits_Click;
            // 
            // button3
            // 
            button3.Location = new Point(137, 121);
            button3.Name = "button3";
            button3.Size = new Size(128, 23);
            button3.TabIndex = 2;
            button3.Text = "Seared Tuna";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Tuna_Click;
            // 
            // button4
            // 
            button4.Location = new Point(137, 150);
            button4.Name = "button4";
            button4.Size = new Size(128, 23);
            button4.TabIndex = 3;
            button4.Text = "New York Strip Steak";
            button4.UseVisualStyleBackColor = true;
            button4.Click += Steak_Click;
            // 
            // EntreeSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 274);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "EntreeSelection";
            Text = "EntreeSelection";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}