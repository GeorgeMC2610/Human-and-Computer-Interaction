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
        //TODO: 
        // - Πρέπει να γίνουν τα picture boxes σωστά στην AnimalCare
        // - Πρέπει να κάνω τα ζώα να πεινάνε, να διψάνε και να σπάνε αντικείμενα
        // - Πρέπει να βάλω μπωλ
        // - Πρέπει να βρω φωτογραφίες για τα ζώα, άδειο και γεμάτο μπωλ
        // - Πρέπει τα ζώα να τρώνε και να πίνουν νερό, και να τα γεμίζει ο χρήστης.

        private static List<FragileFurniture> FragileFurniture = new List<FragileFurniture>();
        private static List<Animal> Pets = new List<Animal>();

        private static Random random = new Random();
        public static bool isHome = true;

        // αντικείμενο φόρμας διαχέρισης συσκευών
        Remote_Device_Control rmctrl;

        public FormMain()
        {
            InitializeComponent();
            rmctrl = new Remote_Device_Control();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //εμφανίζουμε το μήνυμα στον χρήστη όταν φορτώνει η φόρμα.
            labelWelcome.Text = "Καλώς ορίσατε, " + FormLogin.Username + ".";
            label_choose_action.Text = "Παρακαλώ, επιλέξτε μία ενέργεια: ";

            //φτιάχνουμε τα positions των labels της φόρμας
            labelWelcome.Location        = new Point(Width / 2 - labelWelcome.Width / 2, labelWelcome.Location.Y);
            label_choose_action.Location = new Point(Width / 2 - label_choose_action.Width / 2, label_choose_action.Location.Y);

            labelAnimalWarning.Visible = false;

            //θα βάλουμε από 1-4 γάτες στα κατοικίδιάς μας.
            for (int i = 0; i < random.Next(1, 4); i++)
                Pets.Add(new Cat());

            //το ίδιο ισχύει και για τους σκύλους.
            for (int i = 0; i < random.Next(1, 4); i++)
                Pets.Add(new Dog());

            for (int i = 0; i < random.Next(10, 20); i++)
                FragileFurniture.Add(new FragileFurniture());

            //debugging.
            foreach (Animal animal in Pets)
                Console.WriteLine(animal.ToString());

            foreach (FragileFurniture furnitures in FragileFurniture)
                Console.WriteLine(furnitures.ToString());

        }

        private void timerAnimals_Tick(object sender, EventArgs e)
        {
            //Αν ο Χρήστης είναι σπίτι, τότε τα ζώα έχουνε μικρή πιθανότητα να σπάσουν κάτι ή να είναι ζωηρά.
            if (isHome)
            {

            }
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //όταν κλείνει η φόρμα, θα πρέπει να κλείνει και η αρχική, καθώς θα κλείνει και όλο το πρόγραμμα έτσι.
            Application.OpenForms[0].Close();
        }

        private void buttonThermansi_Click(object sender, EventArgs e)
        {
            // άνοιγμα φόρμα διαχείρισης συσκευών.
            rmctrl.Show();
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
