namespace SWE_3313_Restaurant_Automation
{
    partial class OrderCategory
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
            Order_Appetizers = new Button();
            Order_Salads = new Button();
            Order_Entrees = new Button();
            Order_Burgers = new Button();
            Order_Beverages = new Button();
            SuspendLayout();
            // 
            // Order_Appetizers
            // 
            Order_Appetizers.Location = new Point(21, 26);
            Order_Appetizers.Name = "Order_Appetizers";
            Order_Appetizers.Size = new Size(75, 23);
            Order_Appetizers.TabIndex = 0;
            Order_Appetizers.Text = "Appetizers";
            Order_Appetizers.UseVisualStyleBackColor = true;
            Order_Appetizers.Click += Order_Appetizers_Click;
            // 
            // Order_Salads
            // 
            Order_Salads.Location = new Point(127, 26);
            Order_Salads.Name = "Order_Salads";
            Order_Salads.Size = new Size(75, 23);
            Order_Salads.TabIndex = 1;
            Order_Salads.Text = "Salads";
            Order_Salads.UseVisualStyleBackColor = true;
            Order_Salads.Click += Salad_Click;
            // 
            // Order_Entrees
            // 
            Order_Entrees.Location = new Point(234, 26);
            Order_Entrees.Name = "Order_Entrees";
            Order_Entrees.Size = new Size(75, 23);
            Order_Entrees.TabIndex = 2;
            Order_Entrees.Text = "Entrees";
            Order_Entrees.UseVisualStyleBackColor = true;
            Order_Entrees.Click += Entree_Click;
            // 
            // Order_Burgers
            // 
            Order_Burgers.Location = new Point(21, 84);
            Order_Burgers.Name = "Order_Burgers";
            Order_Burgers.Size = new Size(75, 23);
            Order_Burgers.TabIndex = 3;
            Order_Burgers.Text = "Burgers";
            Order_Burgers.UseVisualStyleBackColor = true;
            Order_Burgers.Click += Burger_Click;
            // 
            // Order_Beverages
            // 
            Order_Beverages.Location = new Point(127, 84);
            Order_Beverages.Name = "Order_Beverages";
            Order_Beverages.Size = new Size(75, 23);
            Order_Beverages.TabIndex = 4;
            Order_Beverages.Text = "Beverages";
            Order_Beverages.UseVisualStyleBackColor = true;
            Order_Beverages.Click += Beverage_Click;
            // 
            // OrderCategory
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 145);
            Controls.Add(Order_Beverages);
            Controls.Add(Order_Burgers);
            Controls.Add(Order_Entrees);
            Controls.Add(Order_Salads);
            Controls.Add(Order_Appetizers);
            Name = "OrderCategory";
            Text = "Order_Table_1";
            ResumeLayout(false);
        }

        #endregion

        private Button Order_Appetizers;
        private Button Order_Salads;
        private Button Order_Entrees;
        private Button Order_Burgers;
        private Button Order_Beverages;
    }
}