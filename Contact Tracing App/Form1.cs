
namespace Contact_Tracing_App
{
    public partial class ContactTracingForm : Form
    {
        public ContactTracingForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void LogoPicBox_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Nicole\Documents\ContactTracing.txt");
            file.WriteLine("Name: " + NameTxtbox.Text);
            file.WriteLine("Student #: " + StudentNumTxtbox.Text);
            file.WriteLine("Contact #: " + ContTxtbox.Text);
            file.WriteLine("Age: " + AgeTxtbox.Text);
            file.WriteLine("Birthday: " + BdayDate.Text);
            file.WriteLine("Address: "+ AddressTxtbox.Text);
            if (MaleRadioButton.Checked)
                file.WriteLine("Sex: Male");
            else if (FemaleRadioButton.Checked)
                file.WriteLine("Sex: Female");
            else
                MessageBox.Show("Please select your sex at birth.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            file.Close();
        }
    }
}