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
    public partial class RecordsForm : Form
    {
        public RecordsForm()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void FindButton_Click(object sender, EventArgs e)
        {
          
            string Date;
            Date = ("Date of Visit: " + FindDatePicker.Text);
            int LineCount = File.ReadAllLines(@"C:\Users\Nicole\Documents\ContactTracing.txt").Length;
            int DateIndexFinder = RecordTextBox.Text.IndexOf(Date);
            int DateIndex = RecordTextBox.GetLineFromCharIndex(DateIndexFinder);
            string DateOfVisit = RecordTextBox.Lines[(DateIndex)].ToString();



            if (RecordTextBox.Text.Contains(Date))
            {
                
                while (DateOfVisit.Contains(Date) && DateIndex < LineCount)
                {
                    int NameIndex = (DateIndex - 8);
                    FilterList.Items.Add(RecordTextBox.Lines[(NameIndex)].ToString());
                    DateIndex += 18;
                    if(DateIndex < LineCount)
                    {
                        DateOfVisit = RecordTextBox.Lines[(DateIndex)].ToString();
                    }
                   else
                    { }
                }
                

            }
            else
            {
                MessageBox.Show("No record for this date. Try another date.",
                               "Uhh oh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            
            StreamReader CTrecord = new StreamReader(@"C:\Users\Nicole\Documents\ContactTracing.txt");

            List<string> Records = new List<string>();
            Records.Add(CTrecord.ReadToEnd());
            for (int i = 0; i < Records.Count; i++)
            {
                RecordTextBox.Text = Records[i];

            }
            
        }

        private void InspectButton_Click(object sender, EventArgs e)
        {
            if (FilterList.SelectedItem != null)
            {
                string SelectedName = FilterList.SelectedItem.ToString();
                int NameIndexFinder = RecordTextBox.Text.IndexOf(SelectedName);
                int NameIndex = RecordTextBox.GetLineFromCharIndex(NameIndexFinder);
               
                var Source = RecordTextBox.Lines;
                var Details = Source.Take(NameIndex +17);
                DetailsTextBox.Text = String.Join(Environment.NewLine,Details.Skip(NameIndex));

            }
            else
            {
                MessageBox.Show("Don't forget to select a name.",
                               "Uhh oh!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void FilteredLabel_Click(object sender, EventArgs e)
        {

        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            FilterList.Items.Clear();
        }
    }
}
