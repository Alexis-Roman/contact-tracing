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
            this.FindButton = new System.Windows.Forms.Button();
            this.RecordLabel = new System.Windows.Forms.Label();
            this.NamesLabel = new System.Windows.Forms.Label();
            this.FindDatePicker = new System.Windows.Forms.DateTimePicker();
            this.RecordTextBox = new System.Windows.Forms.TextBox();
            this.FilterList = new System.Windows.Forms.ListBox();
            this.InspectButton = new System.Windows.Forms.Button();
            this.DetailsTextBox = new System.Windows.Forms.TextBox();
            this.DetailsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(534, 110);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // RecordLabel
            // 
            this.RecordLabel.AutoSize = true;
            this.RecordLabel.Location = new System.Drawing.Point(26, 78);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(219, 20);
            this.RecordLabel.TabIndex = 5;
            this.RecordLabel.Text = "Students\' Recorded Information";
            // 
            // NamesLabel
            // 
            this.NamesLabel.AutoSize = true;
            this.NamesLabel.Location = new System.Drawing.Point(394, 160);
            this.NamesLabel.Name = "NamesLabel";
            this.NamesLabel.Size = new System.Drawing.Size(119, 20);
            this.NamesLabel.TabIndex = 6;
            this.NamesLabel.Text = "Name of Visitors";
            this.NamesLabel.Click += new System.EventHandler(this.FilteredLabel_Click);
            // 
            // FindDatePicker
            // 
            this.FindDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FindDatePicker.Location = new System.Drawing.Point(394, 112);
            this.FindDatePicker.Name = "FindDatePicker";
            this.FindDatePicker.Size = new System.Drawing.Size(131, 27);
            this.FindDatePicker.TabIndex = 10;
            // 
            // RecordTextBox
            // 
            this.RecordTextBox.Location = new System.Drawing.Point(26, 112);
            this.RecordTextBox.Multiline = true;
            this.RecordTextBox.Name = "RecordTextBox";
            this.RecordTextBox.ReadOnly = true;
            this.RecordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.RecordTextBox.Size = new System.Drawing.Size(352, 328);
            this.RecordTextBox.TabIndex = 11;
            // 
            // FilterList
            // 
            this.FilterList.FormattingEnabled = true;
            this.FilterList.ItemHeight = 20;
            this.FilterList.Location = new System.Drawing.Point(394, 196);
            this.FilterList.Name = "FilterList";
            this.FilterList.Size = new System.Drawing.Size(270, 244);
            this.FilterList.TabIndex = 12;
            // 
            // InspectButton
            // 
            this.InspectButton.Location = new System.Drawing.Point(534, 156);
            this.InspectButton.Name = "InspectButton";
            this.InspectButton.Size = new System.Drawing.Size(94, 29);
            this.InspectButton.TabIndex = 13;
            this.InspectButton.Text = "Inspect";
            this.InspectButton.UseVisualStyleBackColor = true;
            this.InspectButton.Click += new System.EventHandler(this.InspectButton_Click);
            // 
            // DetailsTextBox
            // 
            this.DetailsTextBox.Location = new System.Drawing.Point(26, 471);
            this.DetailsTextBox.Multiline = true;
            this.DetailsTextBox.Name = "DetailsTextBox";
            this.DetailsTextBox.ReadOnly = true;
            this.DetailsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DetailsTextBox.Size = new System.Drawing.Size(638, 149);
            this.DetailsTextBox.TabIndex = 14;
            // 
            // DetailsLabel
            // 
            this.DetailsLabel.AutoSize = true;
            this.DetailsLabel.Location = new System.Drawing.Point(26, 448);
            this.DetailsLabel.Name = "DetailsLabel";
            this.DetailsLabel.Size = new System.Drawing.Size(55, 20);
            this.DetailsLabel.TabIndex = 15;
            this.DetailsLabel.Text = "Details";
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(688, 640);
            this.Controls.Add(this.DetailsLabel);
            this.Controls.Add(this.DetailsTextBox);
            this.Controls.Add(this.InspectButton);
            this.Controls.Add(this.FilterList);
            this.Controls.Add(this.RecordTextBox);
            this.Controls.Add(this.FindDatePicker);
            this.Controls.Add(this.NamesLabel);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.FindButton);
            this.Name = "RecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Contact Tracing Records";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RecordsForm_Load);
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
    }
}