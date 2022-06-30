namespace Contact_Tracing_App
{
    partial class QR_Code_Scanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CamComboBox = new System.Windows.Forms.ComboBox();
            this.QRLbl = new System.Windows.Forms.Label();
            this.ScanButton = new System.Windows.Forms.Button();
            this.ScannerPictureBox = new System.Windows.Forms.PictureBox();
            this.TickTimer = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ScannerPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CamComboBox
            // 
            this.CamComboBox.FormattingEnabled = true;
            this.CamComboBox.Location = new System.Drawing.Point(55, 58);
            this.CamComboBox.Name = "CamComboBox";
            this.CamComboBox.Size = new System.Drawing.Size(319, 28);
            this.CamComboBox.TabIndex = 0;
            // 
            // QRLbl
            // 
            this.QRLbl.AutoSize = true;
            this.QRLbl.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.QRLbl.Location = new System.Drawing.Point(134, 19);
            this.QRLbl.Name = "QRLbl";
            this.QRLbl.Size = new System.Drawing.Size(186, 36);
            this.QRLbl.TabIndex = 1;
            this.QRLbl.Text = "QR code scanner";
            this.QRLbl.Click += new System.EventHandler(this.QRLbl_Click);
            // 
            // ScanButton
            // 
            this.ScanButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ScanButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ScanButton.ForeColor = System.Drawing.Color.White;
            this.ScanButton.Location = new System.Drawing.Point(162, 445);
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Size = new System.Drawing.Size(120, 44);
            this.ScanButton.TabIndex = 21;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = false;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // ScannerPictureBox
            // 
            this.ScannerPictureBox.Location = new System.Drawing.Point(24, 101);
            this.ScannerPictureBox.Name = "ScannerPictureBox";
            this.ScannerPictureBox.Size = new System.Drawing.Size(396, 328);
            this.ScannerPictureBox.TabIndex = 22;
            this.ScannerPictureBox.TabStop = false;
            // 
            // TickTimer
            // 
            this.TickTimer.Tick += new System.EventHandler(this.TickTimer_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(455, 101);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(334, 328);
            this.textBox1.TabIndex = 23;
            // 
            // QR_Code_Scanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(825, 499);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ScannerPictureBox);
            this.Controls.Add(this.ScanButton);
            this.Controls.Add(this.QRLbl);
            this.Controls.Add(this.CamComboBox);
            this.Name = "QR_Code_Scanner";
            this.Text = "QR_Code_Scanner";
            this.Load += new System.EventHandler(this.QR_Code_Scanner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ScannerPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox CamComboBox;
        private Label QRLbl;
        private Button ScanButton;
        private PictureBox ScannerPictureBox;
        private System.Windows.Forms.Timer TickTimer;
        private TextBox textBox1;
    }
}