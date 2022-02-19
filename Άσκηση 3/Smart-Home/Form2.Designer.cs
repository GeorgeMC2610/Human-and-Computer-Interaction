
namespace Smart_Home
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.labelWelcome = new System.Windows.Forms.Label();
            this.buttonRemoteControl = new System.Windows.Forms.Button();
            this.buttonTimeSchedule = new System.Windows.Forms.Button();
            this.buttonAnimalCare = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label_choose_action = new System.Windows.Forms.Label();
            this.timerAnimals = new System.Windows.Forms.Timer(this.components);
            this.labelAnimalWarning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.BackColor = System.Drawing.Color.Transparent;
            this.labelWelcome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.Location = new System.Drawing.Point(93, 22);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(0, 19);
            this.labelWelcome.TabIndex = 0;
            // 
            // buttonRemoteControl
            // 
            this.buttonRemoteControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRemoteControl.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRemoteControl.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonRemoteControl.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonRemoteControl.Location = new System.Drawing.Point(91, 96);
            this.buttonRemoteControl.Name = "buttonRemoteControl";
            this.buttonRemoteControl.Size = new System.Drawing.Size(350, 57);
            this.buttonRemoteControl.TabIndex = 1;
            this.buttonRemoteControl.Text = "Έλεγχος Συσκευών";
            this.buttonRemoteControl.UseVisualStyleBackColor = false;
            this.buttonRemoteControl.Click += new System.EventHandler(this.buttonThermansi_Click);
            // 
            // buttonTimeSchedule
            // 
            this.buttonTimeSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTimeSchedule.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimeSchedule.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTimeSchedule.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonTimeSchedule.Location = new System.Drawing.Point(91, 182);
            this.buttonTimeSchedule.Name = "buttonTimeSchedule";
            this.buttonTimeSchedule.Size = new System.Drawing.Size(350, 57);
            this.buttonTimeSchedule.TabIndex = 2;
            this.buttonTimeSchedule.Text = "Εισαγωγή Προγράμματος";
            this.buttonTimeSchedule.UseVisualStyleBackColor = true;
            this.buttonTimeSchedule.Click += new System.EventHandler(this.buttonTimeSchedule_Click);
            // 
            // buttonAnimalCare
            // 
            this.buttonAnimalCare.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAnimalCare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAnimalCare.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonAnimalCare.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonAnimalCare.Location = new System.Drawing.Point(91, 268);
            this.buttonAnimalCare.Name = "buttonAnimalCare";
            this.buttonAnimalCare.Size = new System.Drawing.Size(350, 57);
            this.buttonAnimalCare.TabIndex = 3;
            this.buttonAnimalCare.Text = "Φροντίδα Κατοικιδίου";
            this.buttonAnimalCare.UseVisualStyleBackColor = true;
            this.buttonAnimalCare.Click += new System.EventHandler(this.buttonAnimalCare_Click);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonHelp.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.buttonHelp.Location = new System.Drawing.Point(91, 416);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(350, 44);
            this.buttonHelp.TabIndex = 4;
            this.buttonHelp.Text = "Bοήθεια";
            this.buttonHelp.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = global::Smart_Home.Properties.Resources.remote_control;
            this.pictureBox1.Location = new System.Drawing.Point(12, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::Smart_Home.Properties.Resources.calendar;
            this.pictureBox2.Location = new System.Drawing.Point(12, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::Smart_Home.Properties.Resources.pawprint;
            this.pictureBox3.Location = new System.Drawing.Point(12, 268);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 57);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::Smart_Home.Properties.Resources.lifesaver;
            this.pictureBox4.Location = new System.Drawing.Point(12, 416);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(64, 44);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // label_choose_action
            // 
            this.label_choose_action.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_choose_action.AutoSize = true;
            this.label_choose_action.BackColor = System.Drawing.Color.Transparent;
            this.label_choose_action.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label_choose_action.Location = new System.Drawing.Point(160, 44);
            this.label_choose_action.Name = "label_choose_action";
            this.label_choose_action.Size = new System.Drawing.Size(110, 18);
            this.label_choose_action.TabIndex = 10;
            this.label_choose_action.Text = "choose_action";
            this.label_choose_action.Click += new System.EventHandler(this.label2_Click);
            // 
            // timerAnimals
            // 
            this.timerAnimals.Enabled = true;
            this.timerAnimals.Interval = 1000;
            this.timerAnimals.Tick += new System.EventHandler(this.timerAnimals_Tick);
            // 
            // labelAnimalWarning
            // 
            this.labelAnimalWarning.AutoSize = true;
            this.labelAnimalWarning.BackColor = System.Drawing.Color.Transparent;
            this.labelAnimalWarning.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnimalWarning.ForeColor = System.Drawing.Color.IndianRed;
            this.labelAnimalWarning.Location = new System.Drawing.Point(94, 328);
            this.labelAnimalWarning.Name = "labelAnimalWarning";
            this.labelAnimalWarning.Size = new System.Drawing.Size(210, 19);
            this.labelAnimalWarning.TabIndex = 11;
            this.labelAnimalWarning.Text = "Ρίξτε μία ματιά στις ανάγκες!";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(453, 502);
            this.Controls.Add(this.labelAnimalWarning);
            this.Controls.Add(this.label_choose_action);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonAnimalCare);
            this.Controls.Add(this.buttonTimeSchedule);
            this.Controls.Add(this.buttonRemoteControl);
            this.Controls.Add(this.labelWelcome);
            this.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Κύριο Μενού";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Button buttonRemoteControl;
        private System.Windows.Forms.Button buttonTimeSchedule;
        private System.Windows.Forms.Button buttonAnimalCare;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label_choose_action;
        private System.Windows.Forms.Timer timerAnimals;
        private System.Windows.Forms.Label labelAnimalWarning;
    }
}