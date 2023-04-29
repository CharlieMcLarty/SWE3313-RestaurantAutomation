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
            SuspendLayout();
            // 
            // CreateProfileButton
            // 
            CreateProfileButton.Location = new Point(337, 121);
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
            // ManagerWelcomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ModifyProfileButton);
            Controls.Add(CreateProfileButton);
            Name = "ManagerWelcomeForm";
            Text = "ManagerWelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button CreateProfileButton;
        private Button ModifyProfileButton;
    }
}