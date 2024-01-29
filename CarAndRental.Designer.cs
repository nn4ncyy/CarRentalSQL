using System.Data;
using System.Windows.Forms;

namespace CMPT291_CarScreen
{
    partial class CarAndRental
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
            VINTextBox = new TextBox();
            addcarButton = new Button();
            modifycarButton = new Button();
            deletecarButton = new Button();
            searchButton = new Button();
            CTIDTextBox = new TextBox();
            branchIDTextBox = new TextBox();
            yearTextBox = new TextBox();
            pwrsrcComboBox = new ComboBox();
            transmissiontypeComboBox = new ComboBox();
            allCarsView = new DataGridView();
            carScreenTab = new TabControl();
            tabPage1 = new TabPage();
            carScreenBrandTextbox = new TextBox();
            carScreenColourTextBox = new TextBox();
            tabPage2 = new TabPage();
            rentalTransTypeComboBox = new ComboBox();
            rentalPowerSourceComboBox = new ComboBox();
            rentalBrandTextbox = new TextBox();
            rentalColourTextbox = new TextBox();
            rentalYearTextbox = new TextBox();
            rentalBranchID = new TextBox();
            rentalCTIDTextbox = new TextBox();
            rentalVINTextbox = new TextBox();
            rentalBookButton = new Button();
            dataGridView1 = new DataGridView();
            rentalSearchButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            dropOffDateLabel = new Label();
            pickUpDateTimePicker = new DateTimePicker();
            pickUpDateLabel = new Label();
            dropOffRentalComboBox = new ComboBox();
            pickUpRentalComboBox = new ComboBox();
            dropOffLocation = new Label();
            pickupLocationLabel = new Label();
            rentalEmployeeID = new TextBox();
            rentalCustomerID = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)allCarsView).BeginInit();
            carScreenTab.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // VINTextBox
            // 
            VINTextBox.Location = new Point(386, 115);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.PlaceholderText = "VIN";
            VINTextBox.Size = new Size(98, 43);
            VINTextBox.TabIndex = 0;
            // 
            // addcarButton
            // 
            addcarButton.Location = new Point(53, 193);
            addcarButton.Name = "addcarButton";
            addcarButton.Size = new Size(278, 117);
            addcarButton.TabIndex = 1;
            addcarButton.Text = "Add Car";
            addcarButton.UseVisualStyleBackColor = true;
            addcarButton.Click += addcarButton_Click;
            // 
            // modifycarButton
            // 
            modifycarButton.Location = new Point(53, 316);
            modifycarButton.Name = "modifycarButton";
            modifycarButton.Size = new Size(278, 117);
            modifycarButton.TabIndex = 2;
            modifycarButton.Text = "Modify Car";
            modifycarButton.UseVisualStyleBackColor = true;
            modifycarButton.Click += modifycarButton_Click;
            // 
            // deletecarButton
            // 
            deletecarButton.Location = new Point(53, 437);
            deletecarButton.Name = "deletecarButton";
            deletecarButton.Size = new Size(278, 117);
            deletecarButton.TabIndex = 3;
            deletecarButton.Text = "Delete Car";
            deletecarButton.UseVisualStyleBackColor = true;
            deletecarButton.Click += deletecarButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(53, 560);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(278, 117);
            searchButton.TabIndex = 4;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = true;
            // 
            // CTIDTextBox
            // 
            CTIDTextBox.Location = new Point(490, 115);
            CTIDTextBox.Name = "CTIDTextBox";
            CTIDTextBox.PlaceholderText = "CTID";
            CTIDTextBox.Size = new Size(98, 43);
            CTIDTextBox.TabIndex = 5;
            // 
            // branchIDTextBox
            // 
            branchIDTextBox.Location = new Point(594, 115);
            branchIDTextBox.Name = "branchIDTextBox";
            branchIDTextBox.PlaceholderText = "Branch ID";
            branchIDTextBox.Size = new Size(150, 43);
            branchIDTextBox.TabIndex = 6;
            // 
            // yearTextBox
            // 
            yearTextBox.Location = new Point(750, 115);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Year";
            yearTextBox.Size = new Size(90, 43);
            yearTextBox.TabIndex = 7;
            // 
            // pwrsrcComboBox
            // 
            pwrsrcComboBox.FormattingEnabled = true;
            pwrsrcComboBox.Location = new Point(1134, 115);
            pwrsrcComboBox.Name = "pwrsrcComboBox";
            pwrsrcComboBox.Size = new Size(214, 45);
            pwrsrcComboBox.TabIndex = 10;
            pwrsrcComboBox.Text = "Power Source";
            pwrsrcComboBox.SelectedIndexChanged += pwrsrcComboBox_SelectedIndexChanged;
            // 
            // transmissiontypeComboBox
            // 
            transmissiontypeComboBox.FormattingEnabled = true;
            transmissiontypeComboBox.Location = new Point(1354, 115);
            transmissiontypeComboBox.Name = "transmissiontypeComboBox";
            transmissiontypeComboBox.Size = new Size(338, 45);
            transmissiontypeComboBox.TabIndex = 11;
            transmissiontypeComboBox.Text = "Transmission Type";
            // 
            // allCarsView
            // 
            allCarsView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            allCarsView.Location = new Point(386, 193);
            allCarsView.Margin = new Padding(4);
            allCarsView.Name = "allCarsView";
            allCarsView.RowHeadersWidth = 62;
            allCarsView.RowTemplate.Height = 33;
            allCarsView.Size = new Size(1308, 484);
            allCarsView.TabIndex = 12;
            allCarsView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // carScreenTab
            // 
            carScreenTab.Controls.Add(tabPage1);
            carScreenTab.Controls.Add(tabPage2);
            carScreenTab.Location = new Point(12, 12);
            carScreenTab.Name = "carScreenTab";
            carScreenTab.SelectedIndex = 0;
            carScreenTab.Size = new Size(1856, 1376);
            carScreenTab.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(carScreenBrandTextbox);
            tabPage1.Controls.Add(carScreenColourTextBox);
            tabPage1.Controls.Add(allCarsView);
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(transmissiontypeComboBox);
            tabPage1.Controls.Add(deletecarButton);
            tabPage1.Controls.Add(VINTextBox);
            tabPage1.Controls.Add(modifycarButton);
            tabPage1.Controls.Add(pwrsrcComboBox);
            tabPage1.Controls.Add(addcarButton);
            tabPage1.Controls.Add(CTIDTextBox);
            tabPage1.Controls.Add(branchIDTextBox);
            tabPage1.Controls.Add(yearTextBox);
            tabPage1.Location = new Point(10, 55);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1836, 1139);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Car Screen";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // carScreenBrandTextbox
            // 
            carScreenBrandTextbox.Location = new Point(978, 115);
            carScreenBrandTextbox.Name = "carScreenBrandTextbox";
            carScreenBrandTextbox.PlaceholderText = "Brand";
            carScreenBrandTextbox.Size = new Size(150, 43);
            carScreenBrandTextbox.TabIndex = 14;
            carScreenBrandTextbox.TextChanged += carScreenBrandTextbox_TextChanged;
            // 
            // carScreenColourTextBox
            // 
            carScreenColourTextBox.Location = new Point(846, 115);
            carScreenColourTextBox.Name = "carScreenColourTextBox";
            carScreenColourTextBox.PlaceholderText = "Colour";
            carScreenColourTextBox.Size = new Size(126, 43);
            carScreenColourTextBox.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(label1);
            tabPage2.Controls.Add(rentalCustomerID);
            tabPage2.Controls.Add(rentalEmployeeID);
            tabPage2.Controls.Add(rentalTransTypeComboBox);
            tabPage2.Controls.Add(rentalPowerSourceComboBox);
            tabPage2.Controls.Add(rentalBrandTextbox);
            tabPage2.Controls.Add(rentalColourTextbox);
            tabPage2.Controls.Add(rentalYearTextbox);
            tabPage2.Controls.Add(rentalBranchID);
            tabPage2.Controls.Add(rentalCTIDTextbox);
            tabPage2.Controls.Add(rentalVINTextbox);
            tabPage2.Controls.Add(rentalBookButton);
            tabPage2.Controls.Add(dataGridView1);
            tabPage2.Controls.Add(rentalSearchButton);
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(dropOffDateLabel);
            tabPage2.Controls.Add(pickUpDateTimePicker);
            tabPage2.Controls.Add(pickUpDateLabel);
            tabPage2.Controls.Add(dropOffRentalComboBox);
            tabPage2.Controls.Add(pickUpRentalComboBox);
            tabPage2.Controls.Add(dropOffLocation);
            tabPage2.Controls.Add(pickupLocationLabel);
            tabPage2.Location = new Point(10, 55);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1836, 1311);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Rental Screen";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // rentalTransTypeComboBox
            // 
            rentalTransTypeComboBox.FormattingEnabled = true;
            rentalTransTypeComboBox.Location = new Point(1320, 360);
            rentalTransTypeComboBox.Name = "rentalTransTypeComboBox";
            rentalTransTypeComboBox.Size = new Size(270, 45);
            rentalTransTypeComboBox.TabIndex = 18;
            rentalTransTypeComboBox.Text = "Transmission Type";
            // 
            // rentalPowerSourceComboBox
            // 
            rentalPowerSourceComboBox.FormattingEnabled = true;
            rentalPowerSourceComboBox.Location = new Point(1098, 360);
            rentalPowerSourceComboBox.Name = "rentalPowerSourceComboBox";
            rentalPowerSourceComboBox.Size = new Size(216, 45);
            rentalPowerSourceComboBox.TabIndex = 17;
            rentalPowerSourceComboBox.Text = "Power Source";
            // 
            // rentalBrandTextbox
            // 
            rentalBrandTextbox.Location = new Point(976, 360);
            rentalBrandTextbox.Name = "rentalBrandTextbox";
            rentalBrandTextbox.PlaceholderText = "Brand";
            rentalBrandTextbox.Size = new Size(116, 43);
            rentalBrandTextbox.TabIndex = 16;
            // 
            // rentalColourTextbox
            // 
            rentalColourTextbox.Location = new Point(827, 360);
            rentalColourTextbox.Name = "rentalColourTextbox";
            rentalColourTextbox.PlaceholderText = "Colour";
            rentalColourTextbox.Size = new Size(143, 43);
            rentalColourTextbox.TabIndex = 15;
            // 
            // rentalYearTextbox
            // 
            rentalYearTextbox.Location = new Point(738, 360);
            rentalYearTextbox.Name = "rentalYearTextbox";
            rentalYearTextbox.PlaceholderText = "Year";
            rentalYearTextbox.Size = new Size(83, 43);
            rentalYearTextbox.TabIndex = 14;
            // 
            // rentalBranchID
            // 
            rentalBranchID.Location = new Point(589, 360);
            rentalBranchID.Name = "rentalBranchID";
            rentalBranchID.PlaceholderText = "Branch ID";
            rentalBranchID.Size = new Size(143, 43);
            rentalBranchID.TabIndex = 13;
            // 
            // rentalCTIDTextbox
            // 
            rentalCTIDTextbox.Location = new Point(501, 360);
            rentalCTIDTextbox.Name = "rentalCTIDTextbox";
            rentalCTIDTextbox.PlaceholderText = "CTID";
            rentalCTIDTextbox.Size = new Size(82, 43);
            rentalCTIDTextbox.TabIndex = 12;
            // 
            // rentalVINTextbox
            // 
            rentalVINTextbox.Location = new Point(413, 360);
            rentalVINTextbox.Name = "rentalVINTextbox";
            rentalVINTextbox.PlaceholderText = "VIN";
            rentalVINTextbox.Size = new Size(82, 43);
            rentalVINTextbox.TabIndex = 11;
            // 
            // rentalBookButton
            // 
            rentalBookButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rentalBookButton.Location = new Point(1551, 1157);
            rentalBookButton.Name = "rentalBookButton";
            rentalBookButton.Size = new Size(217, 111);
            rentalBookButton.TabIndex = 10;
            rentalBookButton.Text = "Book";
            rentalBookButton.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(73, 440);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 92;
            dataGridView1.RowTemplate.Height = 45;
            dataGridView1.Size = new Size(1698, 500);
            dataGridView1.TabIndex = 9;
            // 
            // rentalSearchButton
            // 
            rentalSearchButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rentalSearchButton.Location = new Point(1599, 352);
            rentalSearchButton.Name = "rentalSearchButton";
            rentalSearchButton.Size = new Size(169, 59);
            rentalSearchButton.TabIndex = 8;
            rentalSearchButton.Text = "Search";
            rentalSearchButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1272, 285);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(496, 43);
            dateTimePicker1.TabIndex = 7;
            // 
            // dropOffDateLabel
            // 
            dropOffDateLabel.AutoSize = true;
            dropOffDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dropOffDateLabel.ImageAlign = ContentAlignment.MiddleLeft;
            dropOffDateLabel.Location = new Point(932, 285);
            dropOffDateLabel.Name = "dropOffDateLabel";
            dropOffDateLabel.Size = new Size(269, 48);
            dropOffDateLabel.TabIndex = 6;
            dropOffDateLabel.Text = "Drop Off Date:";
            // 
            // pickUpDateTimePicker
            // 
            pickUpDateTimePicker.Location = new Point(413, 294);
            pickUpDateTimePicker.Name = "pickUpDateTimePicker";
            pickUpDateTimePicker.Size = new Size(496, 43);
            pickUpDateTimePicker.TabIndex = 5;
            // 
            // pickUpDateLabel
            // 
            pickUpDateLabel.AutoSize = true;
            pickUpDateLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pickUpDateLabel.ImageAlign = ContentAlignment.MiddleLeft;
            pickUpDateLabel.Location = new Point(73, 283);
            pickUpDateLabel.Name = "pickUpDateLabel";
            pickUpDateLabel.Size = new Size(246, 48);
            pickUpDateLabel.TabIndex = 4;
            pickUpDateLabel.Text = "Pick Up Date:";
            // 
            // dropOffRentalComboBox
            // 
            dropOffRentalComboBox.FormattingEnabled = true;
            dropOffRentalComboBox.Location = new Point(1272, 220);
            dropOffRentalComboBox.Name = "dropOffRentalComboBox";
            dropOffRentalComboBox.Size = new Size(496, 45);
            dropOffRentalComboBox.TabIndex = 3;
            dropOffRentalComboBox.Text = "Select Branch Location for Drop Off...";
            // 
            // pickUpRentalComboBox
            // 
            pickUpRentalComboBox.FormattingEnabled = true;
            pickUpRentalComboBox.Location = new Point(413, 223);
            pickUpRentalComboBox.Name = "pickUpRentalComboBox";
            pickUpRentalComboBox.Size = new Size(496, 45);
            pickUpRentalComboBox.TabIndex = 2;
            pickUpRentalComboBox.Text = "Select Branch Location for Pick Up...";
            // 
            // dropOffLocation
            // 
            dropOffLocation.AutoSize = true;
            dropOffLocation.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            dropOffLocation.ImageAlign = ContentAlignment.MiddleLeft;
            dropOffLocation.Location = new Point(932, 214);
            dropOffLocation.Name = "dropOffLocation";
            dropOffLocation.Size = new Size(334, 48);
            dropOffLocation.TabIndex = 1;
            dropOffLocation.Text = "Drop Off Location:";
            // 
            // pickupLocationLabel
            // 
            pickupLocationLabel.AutoSize = true;
            pickupLocationLabel.FlatStyle = FlatStyle.Flat;
            pickupLocationLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            pickupLocationLabel.ImageAlign = ContentAlignment.MiddleLeft;
            pickupLocationLabel.Location = new Point(73, 214);
            pickupLocationLabel.Name = "pickupLocationLabel";
            pickupLocationLabel.Size = new Size(311, 48);
            pickupLocationLabel.TabIndex = 0;
            pickupLocationLabel.Text = "Pick Up Location:";
            pickupLocationLabel.Click += label1_Click;
            // 
            // rentalEmployeeID
            // 
            rentalEmployeeID.Location = new Point(418, 64);
            rentalEmployeeID.Name = "rentalEmployeeID";
            rentalEmployeeID.PlaceholderText = "Employee ID";
            rentalEmployeeID.Size = new Size(337, 43);
            rentalEmployeeID.TabIndex = 19;
            // 
            // rentalCustomerID
            // 
            rentalCustomerID.Location = new Point(418, 135);
            rentalCustomerID.Name = "rentalCustomerID";
            rentalCustomerID.PlaceholderText = "Customer ID";
            rentalCustomerID.Size = new Size(336, 43);
            rentalCustomerID.TabIndex = 20;
            rentalCustomerID.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(73, 64);
            label1.Name = "label1";
            label1.Size = new Size(339, 48);
            label1.TabIndex = 21;
            label1.Text = "Enter Employee ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(73, 135);
            label2.Name = "label2";
            label2.Size = new Size(338, 48);
            label2.TabIndex = 22;
            label2.Text = "Enter Customer ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label3.Location = new Point(73, 981);
            label3.Name = "label3";
            label3.Size = new Size(537, 48);
            label3.TabIndex = 23;
            label3.Text = "Rates: (Calculation to be done)";
            // 
            // CarAndRental
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1892, 1400);
            Controls.Add(carScreenTab);
            Name = "CarAndRental";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)allCarsView).EndInit();
            carScreenTab.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox VINTextBox;
        private Button addcarButton;
        private Button modifycarButton;
        private Button deletecarButton;
        private Button searchButton;
        private TextBox CTIDTextBox;
        private TextBox branchIDTextBox;
        private TextBox yearTextBox;
        private ComboBox pwrsrcComboBox;
        private ComboBox transmissiontypeComboBox;
        private DataGridView allCarsView;
        private TabControl carScreenTab;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label pickupLocationLabel;
        private Label dropOffLocation;
        private ComboBox pickUpRentalComboBox;
        private ComboBox dropOffRentalComboBox;
        private Label pickUpDateLabel;
        private DateTimePicker dateTimePicker1;
        private Label dropOffDateLabel;
        private DateTimePicker pickUpDateTimePicker;
        private Button rentalSearchButton;
        private DataGridView dataGridView1;
        private Button rentalBookButton;
        private TextBox rentalVINTextbox;
        private TextBox rentalBranchID;
        private TextBox rentalCTIDTextbox;
        private TextBox rentalYearTextbox;
        private TextBox rentalColourTextbox;
        private ComboBox rentalTransTypeComboBox;
        private ComboBox rentalPowerSourceComboBox;
        private TextBox rentalBrandTextbox;
        private TextBox carScreenColourTextBox;
        private TextBox carScreenBrandTextbox;
        private TextBox rentalCustomerID;
        private TextBox rentalEmployeeID;
        private Label label2;
        private Label label1;
        private Label label3;
    }
}