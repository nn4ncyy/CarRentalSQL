namespace LoginScreen_temp
{
    partial class Login
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
            label1 = new Label();
            CustomerButton = new RadioButton();
            LoginButton = new Button();
            EmployeeButton = new RadioButton();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            UserTextBox = new TextBox();
            PassTextBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(296, 46);
            label1.Name = "label1";
            label1.Size = new Size(172, 46);
            label1.TabIndex = 0;
            label1.Text = "Car Rental";
            // 
            // CustomerButton
            // 
            CustomerButton.AutoSize = true;
            CustomerButton.Location = new Point(268, 236);
            CustomerButton.Name = "CustomerButton";
            CustomerButton.Size = new Size(93, 24);
            CustomerButton.TabIndex = 1;
            CustomerButton.TabStop = true;
            CustomerButton.Text = "Customer";
            CustomerButton.UseVisualStyleBackColor = true;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(328, 276);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(94, 29);
            LoginButton.TabIndex = 3;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += button2_Click;
            // 
            // EmployeeButton
            // 
            EmployeeButton.AutoSize = true;
            EmployeeButton.Location = new Point(416, 236);
            EmployeeButton.Name = "EmployeeButton";
            EmployeeButton.Size = new Size(96, 24);
            EmployeeButton.TabIndex = 5;
            EmployeeButton.TabStop = true;
            EmployeeButton.Text = "Employee";
            EmployeeButton.UseVisualStyleBackColor = true;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(268, 131);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(75, 20);
            UsernameLabel.TabIndex = 6;
            UsernameLabel.Text = "Username";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(268, 177);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(70, 20);
            PasswordLabel.TabIndex = 7;
            PasswordLabel.Text = "Password";
            // 
            // UserTextBox
            // 
            UserTextBox.Location = new Point(375, 128);
            UserTextBox.Name = "UserTextBox";
            UserTextBox.Size = new Size(125, 27);
            UserTextBox.TabIndex = 8;
            // 
            // PassTextBox
            // 
            PassTextBox.Location = new Point(373, 170);
            PassTextBox.Name = "PassTextBox";
            PassTextBox.Size = new Size(125, 27);
            PassTextBox.TabIndex = 9;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PassTextBox);
            Controls.Add(UserTextBox);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(EmployeeButton);
            Controls.Add(LoginButton);
            Controls.Add(CustomerButton);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "Login";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton CustomerButton;
        private Button LoginButton;
        private RadioButton EmployeeButton;
        private Label UsernameLabel;
        private Label PasswordLabel;
        private TextBox UserTextBox;
        private TextBox PassTextBox;
    }
}