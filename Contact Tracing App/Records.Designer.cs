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
            this.FilteredLabel = new System.Windows.Forms.Label();
            this.FilterTextBox = new System.Windows.Forms.TextBox();
            this.RecordList = new System.Windows.Forms.ListBox();
            this.FindDatePicker = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(38, 88);
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
            this.RecordLabel.Location = new System.Drawing.Point(190, 32);
            this.RecordLabel.Name = "RecordLabel";
            this.RecordLabel.Size = new System.Drawing.Size(219, 20);
            this.RecordLabel.TabIndex = 5;
            this.RecordLabel.Text = "Students\' Recorded Information";
            // 
            // FilteredLabel
            // 
            this.FilteredLabel.AutoSize = true;
            this.FilteredLabel.Location = new System.Drawing.Point(26, 326);
            this.FilteredLabel.Name = "FilteredLabel";
            this.FilteredLabel.Size = new System.Drawing.Size(229, 20);
            this.FilteredLabel.TabIndex = 6;
            this.FilteredLabel.Text = "Filtered according to date of visit";
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Location = new System.Drawing.Point(26, 350);
            this.FilterTextBox.Multiline = true;
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.ReadOnly = true;
            this.FilterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FilterTextBox.Size = new System.Drawing.Size(639, 174);
            this.FilterTextBox.TabIndex = 7;
            // 
            // RecordList
            // 
            this.RecordList.FormattingEnabled = true;
            this.RecordList.ItemHeight = 20;
            this.RecordList.Location = new System.Drawing.Point(190, 55);
            this.RecordList.Name = "RecordList";
            this.RecordList.Size = new System.Drawing.Size(475, 264);
            this.RecordList.TabIndex = 3;
            // 
            // FindDatePicker
            // 
            this.FindDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.FindDatePicker.Location = new System.Drawing.Point(38, 55);
            this.FindDatePicker.Name = "FindDatePicker";
            this.FindDatePicker.Size = new System.Drawing.Size(131, 27);
            this.FindDatePicker.TabIndex = 10;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(688, 538);
            this.Controls.Add(this.FindDatePicker);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.FilteredLabel);
            this.Controls.Add(this.RecordLabel);
            this.Controls.Add(this.RecordList);
            this.Controls.Add(this.FindButton);
            this.Name = "RecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Label FilteredLabel;
        private TextBox FilterTextBox;
        private ListBox RecordList;
        private DateTimePicker FindDatePicker;
    }
}