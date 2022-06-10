
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

            //code for concent 
            if (ConcentChkbox.Checked)
                {
                SubmitButton.Enabled = true;
                MessageBox.Show("Your information has been recorded. Keep safe!",
                    "Information Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            else
                MessageBox.Show("Please check the consent statement",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Personal info
            file.WriteLine("PERSONAL INFORMATION");
            file.WriteLine("Name: " + NameTxtbox.Text);
            file.WriteLine("Student #: " + StudentNumTxtbox.Text);
            file.WriteLine("Contact #: " + ContTxtbox.Text);
            file.WriteLine("Age: " + AgeTxtbox.Text);
            file.WriteLine("Birthday: " + BdayDate.Text);
            //code for radiobutton male/female
            if (MaleRadioButton.Checked)
                file.WriteLine("Sex: Male");
            else if (FemaleRadioButton.Checked)
                file.WriteLine("Sex: Female");
            else
                MessageBox.Show("Please select your sex at birth.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);

            file.WriteLine("Address: " + AddressTxtbox.Text);
            file.WriteLine("");
            file.WriteLine("");

            //Visit info
            file.WriteLine("VISIT INFORMATION");
            file.WriteLine("Date of Visit: " + VisitDate.Text);
            file.WriteLine("Time in: " + TimeIn.Text);
            file.WriteLine("Time out: " + TimeOut.Text);
            file.WriteLine("Reason for visit: " + ReasonTxtbox.Text);
            file.WriteLine("");
            file.WriteLine("");
            

            //Medical info
            file.WriteLine("MEDICAL INFORMATION");
            file.WriteLine("Temperature: " + TemperatureTxtBox.Text);

            //code for radiobutton vaccinated/unvaccinated
            if (YesVacRdioBut.Checked)
                file.WriteLine("Status: Vaccinated");
            else if (NoVacRdioBut.Checked)
                file.WriteLine("Status: Unvaccinated");
            else
                MessageBox.Show("Please select your vaccine status.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // code for flu symptoms
            if (NoFluRdioBut.Checked)
                file.WriteLine("Status: No symptoms of COVID-19");
            else if (YesFluRdioBut.Checked)
                {
                if (SymptomsTxtbox.Text == "")
                    MessageBox.Show("Please specify your syptoms.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    file.WriteLine("Symptoms : ");
                    file.WriteLine(SymptomsTxtbox.Text);
            }
            else
                MessageBox.Show("Please select your health condition.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
            file.Close();


        }
    }
}