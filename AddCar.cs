using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace CMPT291_CarScreen
{
	public partial class AddCar : Form
	{
		public SqlConnection myConnection;
		public SqlCommand myCommand;
		public SqlDataReader myReader;
		public AddCar()
		{
            String connectionString = "Server = SOLITO; Database = car_rental_project; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
			try
			{
				myConnection.Open();
				myCommand = new SqlCommand();
				myCommand.CommandText = "select * from car where VIN IS NOT NULL";
				myCommand.Connection = myConnection;
				InitializeComponent();
				DataTable table = new DataTable();
				string selectquery = "select * from car where VIN IS NOT NULL";
			}
			catch (Exception e)
			{
				MessageBox.Show(e.ToString(), "Error");
				this.Close();
			}
		}

		private void addcarButton_Click(object sender, EventArgs e)
		{
            String connectionString = "Server = SOLITO; Database = car_rental_project; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
			String query = "insert into car(VIN, car_year, colour, brand, power_source, transmission_type, CTID, branchID)values('" + VINTextBox.Text + "', " + yearTextBox.Text + ", '" + clr_textBox.Text + "', '" + brnd_textBox.Text + "', '" + pwrsrcComboBox.SelectedItem.ToString() + "', '" + transmissiontypeComboBox.SelectedItem.ToString() + "', '" + CTIDTextBox.Text + "', '" + branchIDTextBox.Text + "')";
			MessageBox.Show(query);
			myConnection.Open();
			myCommand = new SqlCommand(query, myConnection);
			myCommand.CommandText = query;
			if (myCommand.ExecuteNonQuery() == 1)
			{
				MessageBox.Show("DATA INSERTED SUCCESSFULLY");
			}
			else
			{
				MessageBox.Show("DATA NOT INSERTED SUCCESSFULLY");
			}
			myConnection.Close();
			this.Hide();
		}



		private void cancelAddCarButton_Click_1(object sender, EventArgs e)
		{

			if (MessageBox.Show("Are you sure you want to exit without adding this car?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
			{

				this.Close();
			}
		}

		private void yearTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void VINTextBox_TextChanged(object sender, EventArgs e)
		{

		}

		private void selectedRow_Click(System.EventArgs e)
		{
		}
	}
}
