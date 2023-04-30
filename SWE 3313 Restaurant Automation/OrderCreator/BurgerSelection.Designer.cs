namespace SWE_3313_Restaurant_Automation.OrderCreator
{
    partial class BurgerSelection
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
            button1.Location = new Point(223, 73);
            button1.Name = "button1";
            button1.Size = new Size(151, 23);
            button1.TabIndex = 0;
            button1.Text = "Mushroom Swiss Burger";
            button1.UseVisualStyleBackColor = true;
            button1.Click += MushroomSwiss_Click;
            // 
            // button2
            // 
            button2.Location = new Point(223, 102);
            button2.Name = "button2";
            button2.Size = new Size(151, 23);
            button2.TabIndex = 1;
            button2.Text = "Bacon Cheeseburger";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Bacon_Click;
            // 
            // button3
            // 
            button3.Location = new Point(223, 131);
            button3.Name = "button3";
            button3.Size = new Size(151, 23);
            button3.TabIndex = 2;
            button3.Text = "Carolina Burger";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Carolina_Click;
            // 
            // button4
            // 
            button4.Location = new Point(223, 160);
            button4.Name = "button4";
            button4.Size = new Size(151, 23);
            button4.TabIndex = 3;
            button4.Text = "Vegan Boca Burger";
            button4.UseVisualStyleBackColor = true;
            button4.Click += VeganBoca_Click;
            // 
            // BurgerSelection
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(633, 318);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "BurgerSelection";
            Text = "BurgerSelection";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
    }
}