namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    partial class ManagerAuthorizationsForm
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
            EmployeeAuthorizationTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // EmployeeAuthorizationTextBox
            // 
            EmployeeAuthorizationTextBox.Location = new Point(200, 68);
            EmployeeAuthorizationTextBox.Name = "EmployeeAuthorizationTextBox";
            EmployeeAuthorizationTextBox.Size = new Size(100, 23);
            EmployeeAuthorizationTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 71);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(118, 30);
            label2.Name = "label2";
            label2.Size = new Size(233, 15);
            label2.TabIndex = 2;
            label2.Text = "Select Employee to Manage Authorizations";
            // 
            // button1
            // 
            button1.Location = new Point(200, 97);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 3;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SelectEmployeeAuthorizationButtonClick;
            // 
            // ManagerAuthorizationsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 157);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(EmployeeAuthorizationTextBox);
            Name = "ManagerAuthorizationsForm";
            Text = "ManagerAuthorizationsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox EmployeeAuthorizationTextBox;
        private Label label1;
        private Label label2;
        private Button button1;
    }
}