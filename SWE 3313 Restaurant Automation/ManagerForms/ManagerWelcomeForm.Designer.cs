namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    partial class ManagerWelcomeForm
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
            CreateProfileButton = new Button();
            ModifyProfileButton = new Button();
            AuthorizationsButton = new Button();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // CreateProfileButton
            // 
            CreateProfileButton.Location = new Point(337, 147);
            CreateProfileButton.Name = "CreateProfileButton";
            CreateProfileButton.Size = new Size(139, 23);
            CreateProfileButton.TabIndex = 0;
            CreateProfileButton.Text = "Create New Profile";
            CreateProfileButton.UseVisualStyleBackColor = true;
            CreateProfileButton.Click += CreateProfileButtonClick;
            // 
            // ModifyProfileButton
            // 
            ModifyProfileButton.Location = new Point(337, 176);
            ModifyProfileButton.Name = "ModifyProfileButton";
            ModifyProfileButton.Size = new Size(139, 23);
            ModifyProfileButton.TabIndex = 1;
            ModifyProfileButton.Text = "Modify Profile";
            ModifyProfileButton.UseVisualStyleBackColor = true;
            ModifyProfileButton.Click += ModifyProfileButtonClick;
            // 
            // AuthorizationsButton
            // 
            AuthorizationsButton.Location = new Point(337, 205);
            AuthorizationsButton.Name = "AuthorizationsButton";
            AuthorizationsButton.Size = new Size(139, 23);
            AuthorizationsButton.TabIndex = 2;
            AuthorizationsButton.Text = "Authorizations";
            AuthorizationsButton.UseVisualStyleBackColor = true;
            AuthorizationsButton.Click += AuthorizationsButtonClick;
            // 
            // button1
            // 
            button1.Location = new Point(334, 234);
            button1.Name = "button1";
            button1.Size = new Size(142, 23);
            button1.TabIndex = 3;
            button1.Text = "Employee Activities";
            button1.UseVisualStyleBackColor = true;
            button1.Click += EmployeeActivitiesButtonClick;
            // 
            // button2
            // 
            button2.Location = new Point(337, 263);
            button2.Name = "button2";
            button2.Size = new Size(139, 23);
            button2.TabIndex = 4;
            button2.Text = "Layout Editor";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Layout_Click;
            // 
            // ManagerWelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(AuthorizationsButton);
            Controls.Add(ModifyProfileButton);
            Controls.Add(CreateProfileButton);
            Name = "ManagerWelcomeForm";
            Text = "ManagerWelcomeForm";
            Click += EmployeeActivitiesButtonClick;
            ResumeLayout(false);
        }

        #endregion

        private Button CreateProfileButton;
        private Button ModifyProfileButton;
        private Button AuthorizationsButton;
        private Button button1;
        private Button button2;
    }
}