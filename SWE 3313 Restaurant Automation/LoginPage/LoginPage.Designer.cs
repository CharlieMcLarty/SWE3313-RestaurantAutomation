
namespace SWE_3313_Project
{
    partial class LoginPage
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            EmployeeIDBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            EmployeeID = new Label();
            Password = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // EmployeeIDBox
            // 
            EmployeeIDBox.Location = new Point(130, 265);
            EmployeeIDBox.Name = "EmployeeIDBox";
            EmployeeIDBox.Size = new Size(138, 23);
            EmployeeIDBox.TabIndex = 0;
            // 
            // PasswordBox
            // 
            PasswordBox.Location = new Point(130, 309);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(138, 23);
            PasswordBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(51, 352);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(217, 23);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSize = true;
            EmployeeID.ForeColor = SystemColors.ButtonHighlight;
            EmployeeID.Location = new Point(51, 268);
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Size = new Size(73, 15);
            EmployeeID.TabIndex = 4;
            EmployeeID.Text = "Employee ID";
            // 
            // Password
            // 
            Password.AutoSize = true;
            Password.ForeColor = SystemColors.ButtonHighlight;
            Password.Location = new Point(51, 309);
            Password.Name = "Password";
            Password.Size = new Size(57, 15);
            Password.TabIndex = 5;
            Password.Text = "Password";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(69, 73);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(170, 152);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // LoginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 516);
            Controls.Add(pictureBox1);
            Controls.Add(Password);
            Controls.Add(EmployeeID);
            Controls.Add(LoginButton);
            Controls.Add(PasswordBox);
            Controls.Add(EmployeeIDBox);
            Name = "LoginPage";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox EmployeeIDBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label EmployeeID;
        private System.Windows.Forms.Label Password;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

