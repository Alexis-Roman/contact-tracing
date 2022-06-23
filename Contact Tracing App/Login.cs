using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_App
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SubmittButton_Click(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            RecordsForm recordsForm = new RecordsForm();

            
            if (IDTextbox.Text == "ID 0001-0123")
            {
                recordsForm.Show();
                this.Close();

            }
            else
                MessageBox.Show("Invalid Employee ID. Please try again.",
                    "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
