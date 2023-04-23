namespace SWE_3313_Restaurant_Automation
{
    partial class Order_Table_1
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
            this.Order_Appetizers = new System.Windows.Forms.Button();
            this.Order_Salads = new System.Windows.Forms.Button();
            this.Order_Entrees = new System.Windows.Forms.Button();
            this.Order_Burgers = new System.Windows.Forms.Button();
            this.Order_Beverages = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Order_Appetizers
            // 
            this.Order_Appetizers.Location = new System.Drawing.Point(21, 26);
            this.Order_Appetizers.Name = "Order_Appetizers";
            this.Order_Appetizers.Size = new System.Drawing.Size(75, 23);
            this.Order_Appetizers.TabIndex = 0;
            this.Order_Appetizers.Text = "Appetizers";
            this.Order_Appetizers.UseVisualStyleBackColor = true;
            this.Order_Appetizers.Click += new System.EventHandler(this.Order_Appetizers_Click);
            // 
            // Order_Salads
            // 
            this.Order_Salads.Location = new System.Drawing.Point(127, 26);
            this.Order_Salads.Name = "Order_Salads";
            this.Order_Salads.Size = new System.Drawing.Size(75, 23);
            this.Order_Salads.TabIndex = 1;
            this.Order_Salads.Text = "Salads";
            this.Order_Salads.UseVisualStyleBackColor = true;
            // 
            // Order_Entrees
            // 
            this.Order_Entrees.Location = new System.Drawing.Point(234, 26);
            this.Order_Entrees.Name = "Order_Entrees";
            this.Order_Entrees.Size = new System.Drawing.Size(75, 23);
            this.Order_Entrees.TabIndex = 2;
            this.Order_Entrees.Text = "Entrees";
            this.Order_Entrees.UseVisualStyleBackColor = true;
            // 
            // Order_Burgers
            // 
            this.Order_Burgers.Location = new System.Drawing.Point(21, 84);
            this.Order_Burgers.Name = "Order_Burgers";
            this.Order_Burgers.Size = new System.Drawing.Size(75, 23);
            this.Order_Burgers.TabIndex = 3;
            this.Order_Burgers.Text = "Burgers";
            this.Order_Burgers.UseVisualStyleBackColor = true;
            // 
            // Order_Beverages
            // 
            this.Order_Beverages.Location = new System.Drawing.Point(127, 84);
            this.Order_Beverages.Name = "Order_Beverages";
            this.Order_Beverages.Size = new System.Drawing.Size(75, 23);
            this.Order_Beverages.TabIndex = 4;
            this.Order_Beverages.Text = "Beverages";
            this.Order_Beverages.UseVisualStyleBackColor = true;
            // 
            // Order_Table_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 145);
            this.Controls.Add(this.Order_Beverages);
            this.Controls.Add(this.Order_Burgers);
            this.Controls.Add(this.Order_Entrees);
            this.Controls.Add(this.Order_Salads);
            this.Controls.Add(this.Order_Appetizers);
            this.Name = "Order_Table_1";
            this.Text = "Order_Table_1";
            this.ResumeLayout(false);

        }

        #endregion

        private Button Order_Appetizers;
        private Button Order_Salads;
        private Button Order_Entrees;
        private Button Order_Burgers;
        private Button Order_Beverages;
    }
}