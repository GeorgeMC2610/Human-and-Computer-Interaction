
namespace Smart_Home
{
    partial class AnimalCare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnimalCare));
            this.buttonRefill = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonRefill
            // 
            this.buttonRefill.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonRefill.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonRefill.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonRefill.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRefill.ForeColor = System.Drawing.Color.White;
            this.buttonRefill.Location = new System.Drawing.Point(12, 378);
            this.buttonRefill.Name = "buttonRefill";
            this.buttonRefill.Size = new System.Drawing.Size(383, 60);
            this.buttonRefill.TabIndex = 0;
            this.buttonRefill.Text = "ΓΕΜΙΣΜΑ ΟΛΩΝ ΤΩΝ ΜΠΟΛ";
            this.buttonRefill.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(414, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(374, 60);
            this.button1.TabIndex = 1;
            this.button1.Text = "ΠΡΟΣΘΗΚΗ ΣΥΓΚΕΚΡΙΜΕΝΗΣ ΠΟΣΟΤΗΤΑΣ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // AnimalCare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonRefill);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnimalCare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Φροντίδα Κατοικιδίων";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonRefill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}