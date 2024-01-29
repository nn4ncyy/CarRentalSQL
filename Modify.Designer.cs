namespace CMPT291_CarScreen
{
    partial class Modify
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
            
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            cancelChangesButton = new Button();
            textBox4 = new TextBox();
            saveChangesButton = new Button();
            SuspendLayout();
            // 
           
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1243, 149);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(338, 45);
            comboBox1.TabIndex = 30;
            comboBox1.Text = "Transmission Type";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(1023, 149);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(214, 45);
            comboBox2.TabIndex = 29;
            comboBox2.Text = "Power Source";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(879, 149);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(138, 45);
            comboBox3.TabIndex = 28;
            comboBox3.Text = "Brand";
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(735, 149);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(138, 45);
            comboBox4.TabIndex = 27;
            comboBox4.Text = "Colour";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(639, 149);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 43);
            textBox1.TabIndex = 26;
            textBox1.Text = "Year";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(483, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 43);
            textBox2.TabIndex = 25;
            textBox2.Text = "Branch ID";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(379, 149);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 43);
            textBox3.TabIndex = 24;
            textBox3.Text = "CTID";
            // 
            // cancelChangesButton
            // 
            cancelChangesButton.Location = new Point(1304, 682);
            cancelChangesButton.Name = "cancelChangesButton";
            cancelChangesButton.Size = new Size(277, 117);
            cancelChangesButton.TabIndex = 23;
            cancelChangesButton.Text = "Cancel";
            cancelChangesButton.UseVisualStyleBackColor = true;
            cancelChangesButton.Click += cancelChangesButton_Click;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(275, 149);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(98, 43);
            textBox4.TabIndex = 22;
            textBox4.Text = "VIN";
            // 
            // saveChangesButton
            // 
            saveChangesButton.Location = new Point(1011, 682);
            saveChangesButton.Name = "saveChangesButton";
            saveChangesButton.Size = new Size(277, 117);
            saveChangesButton.TabIndex = 23;
            saveChangesButton.Text = "Save Changes";
            saveChangesButton.UseVisualStyleBackColor = true;
            saveChangesButton.Click += saveChangesButton_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1856, 989);
            Controls.Add(comboBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox3);
            Controls.Add(comboBox4);
            Controls.Add(textBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox3);
            Controls.Add(saveChangesButton);
            Controls.Add(cancelChangesButton);
            Controls.Add(textBox4);
            Name = "Form2";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private Button cancelAddCarButton;
        
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button cancelChangesButton;
        private TextBox textBox4;
        private Button saveChangesButton;
    }
}