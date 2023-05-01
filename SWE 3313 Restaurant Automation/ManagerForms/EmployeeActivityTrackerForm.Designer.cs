namespace SWE_3313_Restaurant_Automation.ManagerForms
{
    partial class EmployeeActivityTrackerForm
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
            label1 = new Label();
            EmployeeIDTextBox = new TextBox();
            AssignedTablesLabel = new Label();
            label2 = new Label();
            TableNumberTextBox = new TextBox();
            button2 = new Button();
            TabListBox = new ListBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(122, 90);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 0;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SetEmployeeButton;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(40, 48);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 1;
            label1.Text = "Employee ID:";
            // 
            // EmployeeIDTextBox
            // 
            EmployeeIDTextBox.Location = new Point(122, 45);
            EmployeeIDTextBox.Name = "EmployeeIDTextBox";
            EmployeeIDTextBox.Size = new Size(100, 23);
            EmployeeIDTextBox.TabIndex = 2;
            // 
            // AssignedTablesLabel
            // 
            AssignedTablesLabel.AutoSize = true;
            AssignedTablesLabel.Location = new Point(23, 154);
            AssignedTablesLabel.Name = "AssignedTablesLabel";
            AssignedTablesLabel.Size = new Size(93, 15);
            AssignedTablesLabel.TabIndex = 3;
            AssignedTablesLabel.Text = "Assigned Tables:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(51, 200);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "View Table:";
            // 
            // TableNumberTextBox
            // 
            TableNumberTextBox.Location = new Point(122, 192);
            TableNumberTextBox.Name = "TableNumberTextBox";
            TableNumberTextBox.Size = new Size(100, 23);
            TableNumberTextBox.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(122, 243);
            button2.Name = "button2";
            button2.Size = new Size(100, 23);
            button2.TabIndex = 6;
            button2.Text = "View Tab";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ViewTabButtton_Click;
            // 
            // TabListBox
            // 
            TabListBox.FormattingEnabled = true;
            TabListBox.ItemHeight = 15;
            TabListBox.Location = new Point(257, 29);
            TabListBox.Name = "TabListBox";
            TabListBox.Size = new Size(120, 409);
            TabListBox.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(304, 9);
            label3.Name = "label3";
            label3.Size = new Size(25, 15);
            label3.TabIndex = 8;
            label3.Text = "Tab";
            // 
            // EmployeeActivityTrackerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(466, 450);
            Controls.Add(label3);
            Controls.Add(TabListBox);
            Controls.Add(button2);
            Controls.Add(TableNumberTextBox);
            Controls.Add(label2);
            Controls.Add(AssignedTablesLabel);
            Controls.Add(EmployeeIDTextBox);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "EmployeeActivityTrackerForm";
            Text = "EmployeeActivityTrackerForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox EmployeeIDTextBox;
        private Label AssignedTablesLabel;
        private Label label2;
        private TextBox TableNumberTextBox;
        private Button button2;
        private ListBox TabListBox;
        private Label label3;
    }
}