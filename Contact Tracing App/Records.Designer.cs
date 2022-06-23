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
            this.FindDatePicker = new System.Windows.Forms.DateTimePicker();
            this.FindButton = new System.Windows.Forms.Button();
            this.InfoList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // FindDatePicker
            // 
            this.FindDatePicker.Location = new System.Drawing.Point(43, 51);
            this.FindDatePicker.Name = "FindDatePicker";
            this.FindDatePicker.Size = new System.Drawing.Size(250, 27);
            this.FindDatePicker.TabIndex = 1;
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(43, 84);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 29);
            this.FindButton.TabIndex = 2;
            this.FindButton.Text = "Find";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // InfoList
            // 
            this.InfoList.FormattingEnabled = true;
            this.InfoList.ItemHeight = 20;
            this.InfoList.Location = new System.Drawing.Point(328, 26);
            this.InfoList.Name = "InfoList";
            this.InfoList.Size = new System.Drawing.Size(337, 424);
            this.InfoList.TabIndex = 3;
            // 
            // RecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(688, 477);
            this.Controls.Add(this.InfoList);
            this.Controls.Add(this.FindButton);
            this.Controls.Add(this.FindDatePicker);
            this.Name = "RecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing Records";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.RecordsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private DateTimePicker FindDatePicker;
        private Button FindButton;
        private ListBox InfoList;
        private ListView InfoListView;
    }
}