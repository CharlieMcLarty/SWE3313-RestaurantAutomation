namespace SWE_3313_Restaurant_Automation
{
    partial class AppetizerSelection
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
            this.Chicken_Nachos = new System.Windows.Forms.Button();
            this.Pork_Nachos = new System.Windows.Forms.Button();
            this.Catfish_Bites = new System.Windows.Forms.Button();
            this.Fried_Veggies = new System.Windows.Forms.Button();
            this.Apps_Finished = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Chicken_Nachos
            // 
            this.Chicken_Nachos.Location = new System.Drawing.Point(45, 92);
            this.Chicken_Nachos.Name = "Chicken_Nachos";
            this.Chicken_Nachos.Size = new System.Drawing.Size(111, 23);
            this.Chicken_Nachos.TabIndex = 0;
            this.Chicken_Nachos.Text = "Chicken Nachos";
            this.Chicken_Nachos.UseVisualStyleBackColor = true;
            this.Chicken_Nachos.Click += new System.EventHandler(this.Chicken_Nachos_Click);
            // 
            // Pork_Nachos
            // 
            this.Pork_Nachos.Location = new System.Drawing.Point(45, 52);
            this.Pork_Nachos.Name = "Pork_Nachos";
            this.Pork_Nachos.Size = new System.Drawing.Size(111, 23);
            this.Pork_Nachos.TabIndex = 1;
            this.Pork_Nachos.Text = "Pork Nachos";
            this.Pork_Nachos.UseVisualStyleBackColor = true;
            this.Pork_Nachos.Click += new System.EventHandler(this.Pork_Nachos_Click);
            // 
            // Catfish_Bites
            // 
            this.Catfish_Bites.Location = new System.Drawing.Point(173, 52);
            this.Catfish_Bites.Name = "Catfish_Bites";
            this.Catfish_Bites.Size = new System.Drawing.Size(111, 23);
            this.Catfish_Bites.TabIndex = 2;
            this.Catfish_Bites.Text = "Catfish Bites";
            this.Catfish_Bites.UseVisualStyleBackColor = true;
            this.Catfish_Bites.Click += new System.EventHandler(this.Catfish_Bites_Click);
            // 
            // Fried_Veggies
            // 
            this.Fried_Veggies.Location = new System.Drawing.Point(173, 91);
            this.Fried_Veggies.Name = "Fried_Veggies";
            this.Fried_Veggies.Size = new System.Drawing.Size(111, 23);
            this.Fried_Veggies.TabIndex = 3;
            this.Fried_Veggies.Text = "Fried Veggies";
            this.Fried_Veggies.UseVisualStyleBackColor = true;
            this.Fried_Veggies.Click += new System.EventHandler(this.Fried_Veggies_Click);
            // 
            // Apps_Finished
            // 
            this.Apps_Finished.Location = new System.Drawing.Point(133, 163);
            this.Apps_Finished.Name = "Apps_Finished";
            this.Apps_Finished.Size = new System.Drawing.Size(75, 23);
            this.Apps_Finished.TabIndex = 8;
            this.Apps_Finished.Text = "Done";
            this.Apps_Finished.UseVisualStyleBackColor = true;
            this.Apps_Finished.Click += new System.EventHandler(this.Apps_Finished_Click);
            // 
            // Apps_Table_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 212);
            this.Controls.Add(this.Apps_Finished);
            this.Controls.Add(this.Fried_Veggies);
            this.Controls.Add(this.Catfish_Bites);
            this.Controls.Add(this.Pork_Nachos);
            this.Controls.Add(this.Chicken_Nachos);
            this.Name = "Apps_Table_1";
            this.Text = "Apps_Table_1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Chicken_Nachos;
        private Button Pork_Nachos;
        private Button Catfish_Bites;
        private Button Fried_Veggies;
        private Button Apps_Finished;
    }
}