﻿using System;
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

            

        }

        private void RecordsForm_Load(object sender, EventArgs e)
        {
            StreamReader CTrecord = new StreamReader(@"C:\Users\Nicole\Documents\ContactTracing.txt");
            while (!CTrecord.EndOfStream)
            {
                InfoList.Items.Add(CTrecord.ReadLine());
            }
        }
    }
}
