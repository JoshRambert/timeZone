namespace cityTimeZone
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.citiesListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayTimeZoneLabel = new System.Windows.Forms.Label();
            this.okButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select a city and I will give you the time zone";
            // 
            // citiesListBox
            // 
            this.citiesListBox.FormattingEnabled = true;
            this.citiesListBox.Items.AddRange(new object[] {
            "Boston",
            "Denver",
            "Honolulu",
            "Eugene",
            "Minneanapolis"});
            this.citiesListBox.Location = new System.Drawing.Point(70, 53);
            this.citiesListBox.Name = "citiesListBox";
            this.citiesListBox.Size = new System.Drawing.Size(120, 95);
            this.citiesListBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Time Zone:";
            // 
            // displayTimeZoneLabel
            // 
            this.displayTimeZoneLabel.Location = new System.Drawing.Point(99, 177);
            this.displayTimeZoneLabel.Name = "displayTimeZoneLabel";
            this.displayTimeZoneLabel.Size = new System.Drawing.Size(100, 13);
            this.displayTimeZoneLabel.TabIndex = 3;
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(48, 216);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(155, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 251);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.displayTimeZoneLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.citiesListBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Time Zone Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox citiesListBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label displayTimeZoneLabel;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Button button2;
    }
}

