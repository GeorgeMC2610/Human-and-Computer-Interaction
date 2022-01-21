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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            labelWelcome.Text = "Καλώς ορίσατε, " + FormLogin.Username + ".";
            labelWelcome.Location = new Point(Width / 2 - labelWelcome.Width / 2, labelWelcome.Location.Y);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Close();
        }

    }
}
