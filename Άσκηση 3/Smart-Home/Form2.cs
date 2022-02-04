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
            //εμφανίζουμε το μήνυμα στον χρήστη όταν φορτώνει η φόρμα.
            labelWelcome.Text = "Καλώς ορίσατε, " + FormLogin.Username + ".";
            label_choose_action.Text = "Παρακαλώ, επιλέξτε μία ενέργεια: ";

            //φτιάχνουμε τα positions των labels της φόρμας
            labelWelcome.Location = new Point(Width / 2 - labelWelcome.Width / 2, labelWelcome.Location.Y);
            label_choose_action.Location = new Point(Width / 2 - label_choose_action.Width / 2, label_choose_action.Location.Y);
        }

        private void FormMain_Resize(object sender, EventArgs e)
        {
            //labelWelcome.Location = new Point(Width / 2 - labelWelcome.Width / 2, labelWelcome.Location.Y);
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //όταν κλείνει η φόρμα, θα πρέπει να κλείνει και η αρχική, καθώς θα κλείνει και όλο το πρόγραμμα έτσι.
            Application.OpenForms[0].Close();
        }

        private void buttonThermansi_Click(object sender, EventArgs e)
        {
            //open form
            RemoteDeviceControl rmctrl = new RemoteDeviceControl();
            rmctrl.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonTimeSchedule_Click(object sender, EventArgs e)
        {
            //open form
            TimeSchedule schedule = new TimeSchedule();
            schedule.Show();
        }

        private void buttonAnimalCare_Click(object sender, EventArgs e)
        {
            //open form
            AnimalCare animal = new AnimalCare();
            animal.Show();
        }
    }
}
