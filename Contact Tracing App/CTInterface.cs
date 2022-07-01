using AForge;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Contact_Tracing_App
{
    public partial class CTInterfaceForm : Form
    {
        public CTInterfaceForm()
        {
            InitializeComponent();
        }
        VideoCaptureDevice captureDevice;

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void LogoPicBox_Click(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
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

        private void SubmitButton_Click(object sender, EventArgs e)
        {

            if (ConcentChkbox.Checked && AgeTxtbox.Text != "" && AddressTxtbox.Text != "" &&
                StudentNumTxtbox.Text != "" && NameTxtbox.Text != "" && ContTxtbox.Text != "" &&
                ReasonTxtbox.Text != "" && TemperatureTxtBox.Text != "" && (FemaleRadioButton.Checked
                || MaleRadioButton.Checked) && (YesVacRdioBut.Checked || NoVacRdioBut.Checked) &&
                ((YesFluRdioBut.Checked == true && SymptomsTxtbox.Text != "") || 
                NoFluRdioBut.Checked))
            
            {
                
                StreamWriter file = new StreamWriter(@"C:\Users\Nicole\Documents\ContactTracing.txt", true);


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
                
                file.WriteLine("Address: " + AddressTxtbox.Text);

                //Visit info
                file.WriteLine("VISIT INFORMATION");
                file.WriteLine("Date of Visit: " + VisitDate.Text);
                file.WriteLine("Time in: " + TimeIn.Text);
                file.WriteLine("Time out: " + TimeOut.Text);
                file.WriteLine("Reason for visit: " + ReasonTxtbox.Text);

                //Medical info
                file.WriteLine("MEDICAL INFORMATION");
                file.WriteLine("Temperature: " + TemperatureTxtBox.Text);

                //code for radiobutton vaccinated/unvaccinated
                if (YesVacRdioBut.Checked)
                    file.WriteLine("Status: Vaccinated");
                else if (NoVacRdioBut.Checked)
                    file.WriteLine("Status: Unvaccinated");              

                // code for flu symptoms
                if (NoFluRdioBut.Checked)
                    file.WriteLine("Status: No symptoms of COVID-19");
                else if (YesFluRdioBut.Checked)
                {
                    file.WriteLine("Symptoms : " + SymptomsTxtbox.Text);
                }
                file.WriteLine("");
                MessageBox.Show("Your information has been recorded. Keep safe!",
                      "Information Recorded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                System.IO.File.Delete(@"C:\Users\Nicole\Documents\QRCodeText.txt");
                file.Close();
            }
            

            else
            {
                if(MaleRadioButton.Checked == false && FemaleRadioButton.Checked == false)
                    MessageBox.Show("Please select your sex at birth.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if(YesVacRdioBut.Checked == false && NoVacRdioBut.Checked == false)
                    MessageBox.Show("Please select your vaccine status.",
                        "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (YesFluRdioBut.Checked == true && SymptomsTxtbox.Text == "")
                    MessageBox.Show("Please specify your syptoms.",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (YesFluRdioBut.Checked == false && NoFluRdioBut.Checked == false)
                    MessageBox.Show("Please select your health condition.",
                        "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Please provide the necessary information.",
                      "Incomplete Input", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }

        }

        private void NameTxtbox_Click(object sender, EventArgs e)
        {
            NameTxtbox.Text = ("");
        }

        private void StudentNumTxtbox_Click(object sender, EventArgs e)
        {
            StudentNumTxtbox.Text = ("");
        }

        private void ContTxtbox_Click(object sender, EventArgs e)
        {
            ContTxtbox.Text = ("");
        }

        private void AddressTxtbox_Click(object sender, EventArgs e)
        {
            AddressTxtbox.Text = ("");
        }

        private void TemperatureTxtBox_Click(object sender, EventArgs e)
        {
            TemperatureTxtBox.Text = ("");
        }

        private void ConsentChkbox_CheckedChanged(object sender, EventArgs e)
        {
            if (ConcentChkbox.Checked)
                SubmitButton.Enabled = true;
            else if (ConcentChkbox.Checked == false)
            {
                SubmitButton.Enabled = false;
                MessageBox.Show("Please check the consent statement",
                    "No input", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ReasonTxtbox_Click(object sender, EventArgs e)
        {
            ReasonTxtbox.Text = ("");
        }

        private void SymptomsTxtbox_Click(object sender, EventArgs e)
        {
            SymptomsTxtbox.Text = ("");
        }

        private void AgeTxtbox_Click(object sender, EventArgs e)
        {
            AgeTxtbox.Text = ("");
        }

        private void AccessButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            
        }

        private void QRButton_Click(object sender, EventArgs e)
        {
            QR_Code_Scanner qR_Code_Scanner = new QR_Code_Scanner();
            qR_Code_Scanner.Show();
        }

        private void QRButton_Enter(object sender, EventArgs e)
        {

        }

        private void AutofillButton_Click(object sender, EventArgs e)
        {
            
            StreamReader QRCodeText = new StreamReader(@"C:\Users\Nicole\Documents\QRCodeText.txt");
            string ScannedInfo = "";

            List<string> QRCTextList = new List<string>();
            QRCTextList.Add(QRCodeText.ReadToEnd());
            for (int i = 0; i < QRCTextList.Count; i++)
            {
                    ScannedInfo = QRCTextList[i];
            }
            //Autofill from QRCode txt.file
            QRTxtbox.Text = ScannedInfo;
            NameTxtbox.Text = QRTxtbox.Lines[0];
            StudentNumTxtbox.Text = QRTxtbox.Lines[1];
            ContTxtbox.Text = QRTxtbox.Lines[2];
            AgeTxtbox.Text = QRTxtbox.Lines[3];
            BdayDate.Text = QRTxtbox.Lines[4];
            AddressTxtbox.Text = QRTxtbox.Lines[6];
            if (QRTxtbox.Text.Contains("Female"))
            {
                FemaleRadioButton.Checked = true;
            }
            else
                MaleRadioButton.Checked = true;

            QRCodeText.Close();
        }
    }
}