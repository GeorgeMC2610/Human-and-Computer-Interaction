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
        public static string Username { get; private set; }

        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //με το που ανοίγει η φόρμα κλειδώνουμε το κουμπί.
            HandleLoginButton(false);
        }

        private void AnyTextboxTextChanged(object sender, EventArgs e)
        {
            //για να ξεκλειδωθεί το κουμπί, πρέπει να υπάρχει τουλάχιστον ένας χαρακτήρας σε κάθε πεδίο.
            if (textBoxUsername.TextLength < 1)
            {
                HandleLoginButton(false);
                wrongUsername.Visible = true;
            }
            else
            {
                wrongUsername.Visible = false;
            }

            if (textBoxPassword.TextLength < 1)
            {
                HandleLoginButton(false);
                wrongPassword.Visible = true;
            }
            else
            {
                HandleLoginButton(false);
                wrongPassword.Visible = false;
            }

             //αν δεν υπάρχει για οποιονδήποτε λόγο, το κλειδώνουμε.
              if (textBoxUsername.TextLength >=1 && textBoxPassword.TextLength >=1)
                HandleLoginButton(true);
        }

        private void linkLabelForgotCredentials_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //αν ο χρήστης δεν ξέρει τι να βάλει στα πεδία, του δείχνουμε το message box.
            MessageBox.Show("Δεν έχει σημασία τι θα βάλετε στα πεδία του Username και του Password (υπάρχουν για διακοσμητικούς σκοπούς). Αρκεί να συμπληρώσετε τουλάχιστον ένα χαρακτήρα σε κάθε πεδίο.", "Υπενθύμιση Στοιχείων", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        /// <summary>
        /// Η συνάρτηση κλειδώνει ή ξεκλειδώνει το κουμπί, ανάλογα με το τι έχει βάλει ο χρήστης στο <paramref name="handle"/>.
        /// Αν ο χρήστης έχει βάλει <b>true</b>, το ξεκλειδώνουμε. Αν έχει βάλει <b>false</b> το ξεκλειδώνουμε.
        /// </summary>
        /// <param name="handle">Η παράμετρος που χειρίζεται το κουμπί. (True για ξεκλείδωμα, False για κλείδωμα)</param>
        private void HandleLoginButton(bool handle)
        {
            buttonLogin.Enabled = handle;

            //και για εφέ, κάνουμε γκρίζο το κουμπί όταν θέλουμε να το κλειδώσουμε.
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
            //όταν ο χρήστης κάνει λογκιν, κρύβουμε την φόρμα αυτή και ανοίγουμε την άλλη.
            Hide();
            Username = textBoxUsername.Text;
            new FormMain().Show();
        }

    }
}
