namespace Contact_Tracing_App
{
    partial class RecordsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecordsForm));
            this.FindButton = new System.Windows.Forms.Button();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.NamesLabel = new System.Windows.Forms.Label();
            this.FindDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.FilterList = new System.Windows.Forms.ListBox();
            this.InspectButton = new System.Windows.Forms.Button();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.TitlePicBox = new System.Windows.Forms.PictureBox();
            this.Logo1PicBox = new System.Windows.Forms.PictureBox();
            this.LogoPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1PicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.BackColor = System.Drawing.Color.LightCoral;
            this.FindButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.FindButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FindButton.ForeColor = System.Drawing.Color.White;
            this.FindButton.Location = new System.Drawing.Point(616, 150);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = false;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecordLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.RecordLabel.Location = new System.Drawing.Point(26, 118);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(246, 25);
            this.RecordLabel.TabIndex = 5;
            this.RecordLabel.Text = "Students\' Recorded Information";
            // 
            // NamesLabel
            // 
            this.NamesLabel.AutoSize = true;
            this.NamesLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NamesLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.NamesLabel.Location = new System.Drawing.Point(476, 200);
            this.NamesLabel.Name = "NamesLabel";
            this.NamesLabel.Size = new System.Drawing.Size(129, 25);
            this.NamesLabel.TabIndex = 6;
            this.NamesLabel.Text = "Name of Visitors";
            this.NamesLabel.Click += new System.EventHandler(this.FilteredLabel_Click);
            // 
            // FindDatePicker
            // 
            this.FindDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FindDatePicker.Location = new System.Drawing.Point(476, 152);
            this.FindDatePicker.Name = "FindDatePicker";
            this.FindDatePicker.Size = new System.Drawing.Size(131, 27);
            this.FindDatePicker.TabIndex = 10;
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.BackColor = System.Drawing.Color.LightPink;
            this.RecordTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RecordTextBox.Location = new System.Drawing.Point(26, 152);
            this.RecordTextBox.Multiline = true;
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.ReadOnly = true;
            this.RecordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RecordTextBox.Size = new System.Drawing.Size(430, 328);
            this.RecordTextBox.TabIndex = 11;
            // 
            // FilterList
            // 
            this.FilterList.BackColor = System.Drawing.Color.LightPink;
            this.FilterList.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterList.FormattingEnabled = true;
            this.FilterList.ItemHeight = 20;
            this.FilterList.Location = new System.Drawing.Point(476, 236);
            this.FilterList.Name = "FilterList";
            this.FilterList.ScrollAlwaysVisible = true;
            this.FilterList.Size = new System.Drawing.Size(270, 244);
            this.FilterList.TabIndex = 12;
            // 
            // InspectButton
            // 
            this.InspectButton.BackColor = System.Drawing.Color.LightCoral;
            this.InspectButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.InspectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspectButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InspectButton.ForeColor = System.Drawing.Color.White;
            this.InspectButton.Location = new System.Drawing.Point(616, 196);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(94, 29);
            this.InspectButton.TabIndex = 13;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = false;
            this.InspectButton.Click += new System.EventHandler(this.InspectButton_Click);
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.BackColor = System.Drawing.Color.LightPink;
            this.DetailsTextBox.Font = new System.Drawing.Font("Malgun Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailsTextBox.Location = new System.Drawing.Point(26, 511);
            this.DetailsTextBox.Multiline = true;
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.ReadOnly = true;
            this.DetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailsTextBox.Size = new System.Drawing.Size(720, 149);
            this.DetailsTextBox.TabIndex = 14;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DetailsLabel.ForeColor = System.Drawing.Color.LightCoral;
            this.DetailsLabel.Location = new System.Drawing.Point(26, 485);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(62, 25);
            this.DetailsLabel.TabIndex = 15;
            this.DetailsLabel.Text = "Details";
            // 
            // TitlePicBox
            // 
            this.TitlePicBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.TitlePicBox.Image = global::Contact_Tracing_App.Properties.Resources.info;
            this.TitlePicBox.Location = new System.Drawing.Point(244, 11);
            this.TitlePicBox.Name = "TitlePicBox";
            this.TitlePicBox.Size = new System.Drawing.Size(307, 86);
            this.TitlePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.TitlePicBox.TabIndex = 16;
            this.TitlePicBox.TabStop = false;
            // 
            // Logo1PicBox
            // 
            this.Logo1PicBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.Logo1PicBox.Image = ((System.Drawing.Image)(resources.GetObject("Logo1PicBox.Image")));
            this.Logo1PicBox.Location = new System.Drawing.Point(561, 11);
            this.Logo1PicBox.Name = "Logo1PicBox";
            this.Logo1PicBox.Size = new System.Drawing.Size(94, 86);
            this.Logo1PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo1PicBox.TabIndex = 17;
            this.Logo1PicBox.TabStop = false;
            // 
            // LogoPicBox
            // 
            this.LogoPicBox.BackColor = System.Drawing.Color.PaleVioletRed;
            this.LogoPicBox.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.static_assets_upload9291112882646985227;
            this.LogoPicBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPicBox.Location = new System.Drawing.Point(151, 7);
            this.LogoPicBox.Name = "LogoPicBox";
            this.LogoPicBox.Size = new System.Drawing.Size(85, 90);
            this.LogoPicBox.TabIndex = 18;
            this.LogoPicBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(3, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(777, 108);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImage = global::Contact_Tracing_App.Properties.Resources.img_106832;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ResetButton.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
            this.ResetButton.FlatAppearance.BorderSize = 0;
            this.ResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ResetButton.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.ForeColor = System.Drawing.Color.White;
            this.ResetButton.Location = new System.Drawing.Point(725, 150);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(35, 29);
            this.ResetButton.TabIndex = 20;
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(772, 688);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.LogoPicBox);
            this.Controls.Add(this.Logo1PicBox);
            this.Controls.Add(this.TitlePicBox);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.DetailsTextBox);
            this.Controls.Add(this.InspectButton);
            this.Controls.Add(this.FilterList);
            this.Controls.Add(this.RecordTextBox);
            this.Controls.Add(this.FindDatePicker);
            this.Controls.Add(this.NamesLabel);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact Tracing Records";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TitlePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Logo1PicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button FindButton;
        private ListView InfoListView;
        private Label RecordLabel;
        private Label NamesLabel;
        private DateTimePicker FindDatePicker;
        private TextBox RecordTextBox;
        private ListBox FilterList;
        private Button InspectButton;
        private TextBox DetailsTextBox;
        private Label DetailsLabel;
        private PictureBox TitlePicBox;
        private PictureBox Logo1PicBox;
        private PictureBox LogoPicBox;
        private PictureBox pictureBox1;
        private Button ResetButton;
    }
}