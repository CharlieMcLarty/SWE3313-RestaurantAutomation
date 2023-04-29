namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    partial class CreateProfileForm
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
            employeeIDBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            label4 = new Label();
            usernameBox = new TextBox();
            SuspendLayout();
            // 
            // employeeIDBox
            // 
            employeeIDBox.Location = new Point(244, 98);
            employeeIDBox.Name = "employeeIDBox";
            employeeIDBox.Size = new Size(100, 23);
            employeeIDBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.Location = new Point(244, 168);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(100, 23);
            passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(162, 101);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 176);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // button1
            // 
            button1.Location = new Point(206, 234);
            button1.Name = "button1";
            button1.Size = new Size(172, 23);
            button1.TabIndex = 4;
            button1.Text = "Create Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += FinishCreateProfile;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(206, 43);
            label3.Name = "label3";
            label3.Size = new Size(160, 15);
            label3.TabIndex = 5;
            label3.Text = "Create New Employee Profile";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 138);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 6;
            label4.Text = "Username:";
            // 
            // textBox1
            // 
            usernameBox.Location = new Point(244, 135);
            usernameBox.Name = "textBox1";
            usernameBox.Size = new Size(100, 23);
            usernameBox.TabIndex = 7;
            // 
            // CreateProfileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(578, 331);
            Controls.Add(usernameBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(employeeIDBox);
            Name = "CreateProfileForm";
            Text = "CreateProfileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox employeeIDBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Label label4;
        private TextBox usernameBox;
    }
}