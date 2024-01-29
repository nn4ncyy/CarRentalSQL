using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace CMPT291_CarScreen
{
    public partial class CarAndRental : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        public CarAndRental()
        {
            // CHANGE SERVER HERE
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
                SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
                adpt.Fill(table);
                allCarsView.DataSource = table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void addcarButton_Click(object sender, EventArgs e)
        {

            this.Hide();
            AddCar addcarForm = new AddCar();
            addcarForm.ShowDialog();
            addcarForm = null;
			String connectionString = "Server = SOLITO; Database = car_rental_project; Trusted_Connection = yes;";
			SqlConnection myConnection = new SqlConnection(connectionString);
			myConnection.Open();
			myCommand = new SqlCommand();
			myCommand.CommandText = "select * from car where VIN IS NOT NULL";
			myCommand.Connection = myConnection;
			DataTable table = new DataTable();
			string selectquery = "select * from car where VIN IS NOT NULL";
			SqlDataAdapter adpt = new SqlDataAdapter(myCommand.CommandText, myConnection);
			table.Clear();
			adpt.Fill(table);
			allCarsView.DataSource = table;
			this.Show();

        }

        private void modifycarButton_Click(object sender, EventArgs e)
        {
			string connectionString = "Server=SOLITO; Database=car_rental_project; Trusted_Connection=yes;";
			string color = carScreenColourTextBox.Text;
			string ctid = CTIDTextBox.Text;
			string branchid = branchIDTextBox.Text;
			string year = yearTextBox.Text;
			string brand = carScreenBrandTextbox.Text;
			string pwrSrc = pwrsrcComboBox.Text;
			string transType = transmissiontypeComboBox.Text;

			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				string selectQuery = "SELECT * FROM car WHERE VIN IS NOT NULL";

				using (SqlCommand selectCommand = new SqlCommand(selectQuery, connection))
				{
					SqlDataReader reader = selectCommand.ExecuteReader();

					if (reader.HasRows)
					{
						reader.Read(); // Assuming you want to modify the first car in the resultset
                        reader.Close();
						string vin = VINTextBox.Text;

						string updateQuery = "UPDATE car SET colour = @color, CTID = @ctid, branchID = @branchid, car_year = @year, brand = @brand, power_Source = @pwrSrc, transmission_Type = @transType WHERE VIN = @vin";

						using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
						{
							updateCommand.Parameters.AddWithValue("@color", color);
							updateCommand.Parameters.AddWithValue("@vin", vin);
							updateCommand.Parameters.AddWithValue("@ctid", ctid);
							updateCommand.Parameters.AddWithValue("@branchid", branchid);
							updateCommand.Parameters.AddWithValue("@year", year);
							updateCommand.Parameters.AddWithValue("@brand", brand);
							updateCommand.Parameters.AddWithValue("@pwrSrc", pwrSrc);
							updateCommand.Parameters.AddWithValue("@transType", transType);
							int rowsAffected = updateCommand.ExecuteNonQuery();
							if (rowsAffected > 0)
							{
								// Update the color directly in the UI control
								carScreenColourTextBox.Text = color;
								CTIDTextBox.Text = ctid;
								carScreenColourTextBox.Text = color;

								MessageBox.Show("Car color modified successfully!");
							}
							else
							{
								MessageBox.Show("Car not found or color was not modified.");
							}
						}
					}
					else
					{
						MessageBox.Show("No cars found.");
					}
				}
				DataTable table = new DataTable();
				string selectquery = "select * from car where VIN IS NOT NULL";
				SqlDataAdapter adpt = new SqlDataAdapter(selectquery, connection);
				table.Clear();
				adpt.Fill(table);
				allCarsView.DataSource = table;
			}
		}

        private void deletecarButton_Click(object sender, EventArgs e)
        {
            // CHANGE SERVER HERE
            String connectionString = "Server = SOLITO; Database = car_rental_project; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            if (MessageBox.Show("Are you sure you want to delete this car permanently?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                String query = "delete from car where VIN =" + VINTextBox.Text;
                myConnection.Open();
                myCommand = new SqlCommand(query, myConnection);
                myCommand.CommandText = query;
                if (myCommand.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("DATA REMOVED SUCCESSFULLY");
					DataTable table = new DataTable();
					string selectquery = "select * from car where VIN IS NOT NULL";
					SqlDataAdapter adpt = new SqlDataAdapter(selectquery, myConnection);
					table.Clear();
					adpt.Fill(table);
					allCarsView.DataSource = table;
				}
                else
                {
                    MessageBox.Show("DATA NOT REMOVED SUCCESSFULLY");
                }
                myConnection.Close();
            };
        }

        private void allCarsView_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in allCarsView.SelectedRows)
            {
                VINTextBox.Text = row.Cells[0].Value.ToString();
                yearTextBox.Text = row.Cells[1].Value.ToString();
                carScreenColourTextBox.Text = row.Cells[2].Value.ToString();
                carScreenBrandTextbox.Text = row.Cells[3].Value.ToString();
                pwrsrcComboBox.SelectedIndex = pwrsrcComboBox.Items.IndexOf(row.Cells[4].Value.ToString().Trim());
                transmissiontypeComboBox.SelectedIndex = transmissiontypeComboBox.Items.IndexOf(row.Cells[5].Value.ToString().Trim());
                CTIDTextBox.Text = row.Cells[6].Value.ToString();
                branchIDTextBox.Text = row.Cells[7].Value.ToString();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            // CHANGE SERVER HERE
            String connectionString = "Server = SOLITO; Database = car_rental_project; Trusted_Connection = yes;";
            SqlConnection myConnection = new SqlConnection(connectionString);
            myConnection.Open();
            myCommand = new SqlCommand();
            myCommand.CommandText = "select * from car where VIN =" + VINTextBox.Text;
            myCommand.Connection = myConnection;
            DataTable table = new DataTable();
            string selectquery = "select * from car where VIN =" + VINTextBox.Text;
            SqlDataAdapter adpt = new SqlDataAdapter(myCommand.CommandText, myConnection);
            table.Clear();
            adpt.Fill(table);
            allCarsView.DataSource = table;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pwrsrcComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void carScreenBrandTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}