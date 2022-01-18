using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Smart_Home
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            HandleLoginButton(false);
        }

        private void AnyTextboxTextChanged(object sender, EventArgs e)
        {
            if (textBoxUsername.TextLength < 1 || textBoxPassword.TextLength < 1)
                HandleLoginButton(false);
            else
                HandleLoginButton(true);
        }

        private void linkLabelForgotCredentials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Δεν έχει σημασία τι θα βάλετε στα πεδία του Username και του Password (υπάρχουν για διακοσμητικούς σκοπούς). Αρκεί να συμπληρώσετε τουλάχιστον ένα χαρακτήρα σε κάθε πεδίο.", "Υπενθύμιση Στοιχείων", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void HandleLoginButton(bool handle)
        {
            buttonLogin.Enabled = handle;

            if (handle)
            {
                buttonLogin.BackColor = Color.DarkGreen;
                buttonLogin.ForeColor = Color.White;
            } 
            else
            {
                buttonLogin.BackColor = Color.DarkGray;
                buttonLogin.ForeColor = Color.Black;
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
        }

    }
}
