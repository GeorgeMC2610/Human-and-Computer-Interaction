
namespace Smart_Home
{
    partial class TimeSchedule
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimeSchedule));
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button20 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.Maroon;
            this.button20.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button20.Location = new System.Drawing.Point(490, 65);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(214, 31);
            this.button20.TabIndex = 38;
            this.button20.Text = "Διαθέσιμα Παπούτσια";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(293, 210);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(214, 31);
            this.button1.TabIndex = 39;
            this.button1.Text = "Διαθέσιμα Παπούτσια";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // TimeSchedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.dateTimePicker1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TimeSchedule";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Διαχείριση Χρονοπρογράμματος";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimeSchedule_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button1;
    }
}