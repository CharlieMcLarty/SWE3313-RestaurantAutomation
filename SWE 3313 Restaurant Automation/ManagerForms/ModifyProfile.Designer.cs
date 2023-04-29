namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    partial class ModifyProfile
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
            EmployeeIDTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            NewUsernameTextBox = new TextBox();
            NewEmployeeIDTextBox = new TextBox();
            DeleteProfileButton = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // EmployeeIDTextBox
            // 
            EmployeeIDTextBox.Location = new Point(402, 96);
            EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            EmployeeIDTextBox.Size = new Size(100, 23);
            EmployeeIDTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(278, 99);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 1;
            label1.Text = "Select Employee (ID):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(249, 157);
            label2.Name = "label2";
            label2.Size = new Size(147, 15);
            label2.TabIndex = 2;
            label2.Text = "New Username (Optional):\r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(291, 216);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 3;
            label3.Text = "New ID (Optional):";
            // 
            // textBox2
            // 
            NewUsernameTextBox.Location = new Point(402, 149);
            NewUsernameTextBox.Name = "textBox2";
            NewUsernameTextBox.Size = new Size(100, 23);
            NewUsernameTextBox.TabIndex = 4;
            // 
            // textBox3
            // 
            NewEmployeeIDTextBox.Location = new Point(402, 208);
            NewEmployeeIDTextBox.Name = "textBox3";
            NewEmployeeIDTextBox.Size = new Size(100, 23);
            NewEmployeeIDTextBox.TabIndex = 5;
            // 
            // DeleteProfileButton
            // 
            DeleteProfileButton.Location = new Point(338, 292);
            DeleteProfileButton.Name = "DeleteProfileButton";
            DeleteProfileButton.Size = new Size(124, 23);
            DeleteProfileButton.TabIndex = 6;
            DeleteProfileButton.Text = "Delete Profile";
            DeleteProfileButton.UseVisualStyleBackColor = true;
            DeleteProfileButton.Click += DeleteProfileButtonClick;
            // 
            // button1
            // 
            button1.Location = new Point(338, 263);
            button1.Name = "button1";
            button1.Size = new Size(124, 23);
            button1.TabIndex = 7;
            button1.Text = "Confirm Changes";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ConfirmChangesButtonClick;
            // 
            // ModifyProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(DeleteProfileButton);
            Controls.Add(NewEmployeeIDTextBox);
            Controls.Add(NewUsernameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmployeeIDTextBox);
            Name = "ModifyProfile";
            Text = "ModifyProfile";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmployeeIDTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox NewUsernameTextBox;
        private TextBox NewEmployeeIDTextBox;
        private Button DeleteProfileButton;
        private Button button1;
    }
}