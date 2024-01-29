namespace CMPT291_CarScreen
{
	partial class AddCar
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
			transmissiontypeComboBox = new ComboBox();
			pwrsrcComboBox = new ComboBox();
			yearTextBox = new TextBox();
			branchIDTextBox = new TextBox();
			CTIDTextBox = new TextBox();
			addcarButton = new Button();
			VINTextBox = new TextBox();
			cancelAddCarButton = new Button();
			clr_textBox = new TextBox();
			brnd_textBox = new TextBox();
			SuspendLayout();
			// 
			// transmissiontypeComboBox
			// 
			transmissiontypeComboBox.FormattingEnabled = true;
			transmissiontypeComboBox.Items.AddRange(new object[] { "Automatic", "Manual" });
			transmissiontypeComboBox.Location = new Point(756, 70);
			transmissiontypeComboBox.Margin = new Padding(2);
			transmissiontypeComboBox.Name = "transmissiontypeComboBox";
			transmissiontypeComboBox.Size = new Size(227, 33);
			transmissiontypeComboBox.TabIndex = 20;
			transmissiontypeComboBox.Text = "Transmission Type";
			// 
			// pwrsrcComboBox
			// 
			pwrsrcComboBox.FormattingEnabled = true;
			pwrsrcComboBox.Items.AddRange(new object[] { "Electric", "Gas" });
			pwrsrcComboBox.Location = new Point(609, 70);
			pwrsrcComboBox.Margin = new Padding(2);
			pwrsrcComboBox.Name = "pwrsrcComboBox";
			pwrsrcComboBox.Size = new Size(144, 33);
			pwrsrcComboBox.TabIndex = 19;
			pwrsrcComboBox.Text = "Power Source";
			// 
			// yearTextBox
			// 
			yearTextBox.Location = new Point(353, 70);
			yearTextBox.Margin = new Padding(2);
			yearTextBox.Name = "yearTextBox";
			yearTextBox.Size = new Size(61, 31);
			yearTextBox.TabIndex = 16;
			yearTextBox.Text = "Year";
			yearTextBox.TextChanged += yearTextBox_TextChanged;
			// 
			// branchIDTextBox
			// 
			branchIDTextBox.Location = new Point(249, 70);
			branchIDTextBox.Margin = new Padding(2);
			branchIDTextBox.Name = "branchIDTextBox";
			branchIDTextBox.Size = new Size(101, 31);
			branchIDTextBox.TabIndex = 15;
			branchIDTextBox.Text = "Branch ID";
			// 
			// CTIDTextBox
			// 
			CTIDTextBox.Location = new Point(180, 70);
			CTIDTextBox.Margin = new Padding(2);
			CTIDTextBox.Name = "CTIDTextBox";
			CTIDTextBox.Size = new Size(67, 31);
			CTIDTextBox.TabIndex = 14;
			CTIDTextBox.Text = "CTID";
			// 
			// addcarButton
			// 
			addcarButton.Location = new Point(608, 458);
			addcarButton.Margin = new Padding(2);
			addcarButton.Name = "addcarButton";
			addcarButton.Size = new Size(185, 79);
			addcarButton.TabIndex = 13;
			addcarButton.Text = "Add New Car";
			addcarButton.UseVisualStyleBackColor = true;
			addcarButton.Click += addcarButton_Click;
			// 
			// VINTextBox
			// 
			VINTextBox.Location = new Point(111, 70);
			VINTextBox.Margin = new Padding(2);
			VINTextBox.Name = "VINTextBox";
			VINTextBox.Size = new Size(67, 31);
			VINTextBox.TabIndex = 12;
			VINTextBox.Text = "VIN";
			VINTextBox.TextChanged += VINTextBox_TextChanged;
			// 
			// cancelAddCarButton
			// 
			cancelAddCarButton.Location = new Point(797, 458);
			cancelAddCarButton.Margin = new Padding(2);
			cancelAddCarButton.Name = "cancelAddCarButton";
			cancelAddCarButton.Size = new Size(185, 79);
			cancelAddCarButton.TabIndex = 21;
			cancelAddCarButton.Text = "Cancel";
			cancelAddCarButton.UseVisualStyleBackColor = true;
			cancelAddCarButton.Click += cancelAddCarButton_Click_1;
			// 
			// clr_textBox
			// 
			clr_textBox.Location = new Point(416, 70);
			clr_textBox.Name = "clr_textBox";
			clr_textBox.Size = new Size(93, 31);
			clr_textBox.TabIndex = 22;
			clr_textBox.Text = "Colour";
			// 
			// brnd_textBox
			// 
			brnd_textBox.Location = new Point(511, 70);
			brnd_textBox.Name = "brnd_textBox";
			brnd_textBox.Size = new Size(93, 31);
			brnd_textBox.TabIndex = 23;
			brnd_textBox.Text = "Brand";
			// 
			// Form3
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1109, 618);
			Controls.Add(brnd_textBox);
			Controls.Add(clr_textBox);
			Controls.Add(cancelAddCarButton);
			Controls.Add(transmissiontypeComboBox);
			Controls.Add(pwrsrcComboBox);
			Controls.Add(yearTextBox);
			Controls.Add(branchIDTextBox);
			Controls.Add(CTIDTextBox);
			Controls.Add(addcarButton);
			Controls.Add(VINTextBox);
			Margin = new Padding(2);
			Name = "Form3";
			Text = "Form3";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ComboBox transmissiontypeComboBox;
		private ComboBox pwrsrcComboBox;
		private TextBox yearTextBox;
		private TextBox branchIDTextBox;
		private TextBox CTIDTextBox;
		private Button addcarButton;
		private TextBox VINTextBox;
		private Button cancelAddCarButton;
		private TextBox clr_textBox;
		private TextBox brnd_textBox;
	}
}