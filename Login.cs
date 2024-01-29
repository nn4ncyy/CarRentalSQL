using CMPT291_CarScreen;

namespace LoginScreen_temp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
			this.Hide();
			CarAndRental employee = new CarAndRental();
			employee.ShowDialog();
			employee = null;
		}
    }
}