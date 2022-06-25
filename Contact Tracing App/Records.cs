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
                index nung indexN-indexTEXTBOX
                Ilagay sa listbox as item yung line indexN (name dapat lalabas dito)(again idk how)
            }
                
             */
            string date;
            date = FindDatePicker.Text;

            string FindDate = date;
            int DateIndexFinder = RecordTextBox.Text.IndexOf("Date of Visit: " + FindDate);
            int DateIndex = RecordTextBox.GetLineFromCharIndex(DateIndexFinder);
            int NameIndex = (DateIndex - 8);

            MessageBox.Show(RecordTextBox.GetLineFromCharIndex(DateIndexFinder).ToString());
            MessageBox.Show(RecordTextBox.Lines[(NameIndex)].ToString());
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
