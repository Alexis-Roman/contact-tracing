using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace Contact_Tracing_App
{
    
    public partial class QR_Code_Scanner : Form
    {
        
        public QR_Code_Scanner()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;
        private void QR_Code_Scanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
            {
                CamComboBox.Items.Add(filterInfo.Name);
            }
            CamComboBox.SelectedIndex = 0;
            captureDevice = new VideoCaptureDevice();

        }

        private void QRLbl_Click(object sender, EventArgs e)
        {

        }

        private void ScanButton_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(filterInfoCollection
                [CamComboBox.SelectedIndex].MonikerString);
            captureDevice.NewFrame += new NewFrameEventHandler(CaptureDevice_NewFrame);
            captureDevice.Start();
            


        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            ScannerPictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QR_Code_Scanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning == true)
            {
                captureDevice.Stop();
            }
        }

        private void TickTimer_Tick(object sender, EventArgs e)
        {
            BarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode((Bitmap) ScannerPictureBox.Image);
            
                string QRCodeText = result.ToString().Trim();
                if(QRCodeText != "")
                {
                    textBox1.Text = QRCodeText;
                }
                
          
            else 
            {

            }
            
            /*
            if (result != null)
                {
                    textBox1.Text = result.ToString();
                    TickTimer.Stop();

                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                    }

                }
            */
            
            
        }

        private void ReadButton_Click(object sender, EventArgs e)
        {
            TickTimer.Start();
        }
    }
}
