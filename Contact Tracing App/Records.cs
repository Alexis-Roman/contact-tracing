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
            /*
             Since di talaga gumana lahat ng ni try ko para sa pag filter 
             pseudo code muna...

            DIBAAAAA may laman yung textbox ko na record ng students
            sooo... yung laman nun at yung naka input sa sa DatePicker
            icocompare ko then hahanapin nya same na value nun
            THENNN kung same value, hahanapin ko index nya?(yung position nya sa line)
            after nun need ko palabasin dun sa list yung NAME ng student na nagvisit sa school
            So... (index-n) siguro n = kung gano kalayo yung index ng date sa index ng name. (ewan ko lang kung may code ba na ganito)
            After lumitaw nung name ng nag visit... dapat pag nipindot yun LALABAS LAHAT NG INFO 
            TUNGKOL SA KANYA SA MESSAGE BOX (idk how).

            if (yung date sa DATEPICKER is may kaparehas sa TEXTBOX)
            {
                hanapin mo index nun sa TEXTBOX (NAHANAP KO NA)
                index nung indexN-indexTEXTBOX (NAGAWA KO NA DIN)
                PERO NEED LAHAT NG NAMES NA SAME DATE (ITERATE DI KO PA SURE KUNG PANO)
                Ilagay sa listbox as item yung line indexN (name dapat lalabas dito)(again idk how)
            }
                
             */
            string Date;
            Date = ("Date of Visit: " + FindDatePicker.Text);
            int LineCount = File.ReadAllLines(@"C:\Users\Nicole\Documents\ContactTracing.txt").Length;
            int DateIndexFinder = RecordTextBox.Text.IndexOf(Date);
            int DateIndex = RecordTextBox.GetLineFromCharIndex(DateIndexFinder);
            

            string DateOfVisit = RecordTextBox.Lines[(DateIndex)].ToString();

            if (RecordTextBox.Text.Contains(Date))
            {
                while(DateOfVisit.Contains(Date) && DateIndex < LineCount)
                {
                    int NameIndex = (DateIndex - 8);
                    FilterList.Items.Add(RecordTextBox.Lines[(NameIndex)].ToString());
                    DateIndex += 18;
                    //dagdagan yung date index ng +18 then pag yung line na yun contains date of visit + date
                    MessageBox.Show(DateIndex.ToString());
                    
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
    }
}
