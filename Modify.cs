using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMPT291_CarScreen
{
    public partial class Modify : Form
    {
        public Modify()
        {
            InitializeComponent();
        }

        private void saveChangesButton_Click(object sender, EventArgs e)
        {
            this.Hide();

        }

        private void cancelChangesButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit without saving your changes?", "Exit Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            { this.Close(); }
        }
    }
}
