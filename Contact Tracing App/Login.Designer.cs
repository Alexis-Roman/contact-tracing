namespace Contact_Tracing_App
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.EmployeeLabel = new System.Windows.Forms.Label();
            this.IDTextbox = new System.Windows.Forms.TextBox();
            this.InfoLabel = new System.Windows.Forms.Label();
            this.AkademiPic = new System.Windows.Forms.PictureBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AkademiPic)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeLabel
            // 
            this.EmployeeLabel.AutoSize = true;
            this.EmployeeLabel.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmployeeLabel.Location = new System.Drawing.Point(21, 94);
            this.EmployeeLabel.Name = "EmployeeLabel";
            this.EmployeeLabel.Size = new System.Drawing.Size(109, 20);
            this.EmployeeLabel.TabIndex = 1;
            this.EmployeeLabel.Text = "Employee I.D #";
            // 
            // IDTextbox
            // 
            this.IDTextbox.Location = new System.Drawing.Point(136, 91);
            this.IDTextbox.Name = "IDTextbox";
            this.IDTextbox.Size = new System.Drawing.Size(212, 27);
            this.IDTextbox.TabIndex = 2;
            // 
            // InfoLabel
            // 
            this.InfoLabel.AutoSize = true;
            this.InfoLabel.Font = new System.Drawing.Font("Trebuchet MS", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InfoLabel.Location = new System.Drawing.Point(12, 54);
            this.InfoLabel.Name = "InfoLabel";
            this.InfoLabel.Size = new System.Drawing.Size(350, 23);
            this.InfoLabel.TabIndex = 3;
            this.InfoLabel.Text = "Please enter your I.D number to continue.";
            // 
            // AkademiPic
            // 
            this.AkademiPic.BackColor = System.Drawing.Color.Transparent;
            this.AkademiPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AkademiPic.BackgroundImage")));
            this.AkademiPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AkademiPic.Location = new System.Drawing.Point(-2, 8);
            this.AkademiPic.Name = "AkademiPic";
            this.AkademiPic.Size = new System.Drawing.Size(368, 41);
            this.AkademiPic.TabIndex = 4;
            this.AkademiPic.TabStop = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.Color.DarkSalmon;
            this.SubmitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitButton.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SubmitButton.Location = new System.Drawing.Point(254, 135);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(94, 29);
            this.SubmitButton.TabIndex = 5;
            this.SubmitButton.Text = "submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(370, 176);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AkademiPic);
            this.Controls.Add(this.InfoLabel);
            this.Controls.Add(this.IDTextbox);
            this.Controls.Add(this.EmployeeLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.AkademiPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label EmployeeLabel;
        private TextBox IDTextbox;
        private Label InfoLabel;
        private PictureBox AkademiPic;
        private Button SubmitButton;
    }
}