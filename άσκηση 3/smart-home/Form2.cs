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

        // οι μεταβλητές αυτές ορίζουν τους 'διακόπτες΄ των φωτών οροφής του κάθε δωματίου
        private bool light_hol = false;
        private bool light_living_room = false;
        private bool light_kitchen = false;
        private bool light_garage = false;
        private bool light_bathroom = false;
        private bool light_bedroom = false;

        // οι μεταβλητές αυτές ορίζουν τους 'διακόπτες΄ για την θερμοκρασία του κάθε δωματίου
        private bool temp_hol = false;
        private bool temp_living_room = false;
        private bool temp_kitchen = false;
        private bool temp_garage = false;
        private bool temp_bathroom = false;
        private bool temp_bedroom = false;

        // διακόπτης που ρυθμίζει την κατάσταση λειτουργίας της παπουτσοθήκης
        private bool papoutsotiki = false;

        // διακόπτης που ρυθμίζει την κατάσταση λειτουργίας της καφετιέρας
        private bool kafetiera = false;

        private static List<FragileFurniture> FragileFurniture = new List<FragileFurniture>();
        private static List<Animal> Pets = new List<Animal>();

        private static Random random = new Random();
        public static bool isHome = true;

        // δημιουργία setter για τις μεταβλητές που "ρυθμίζουν" τον φωτισμό σε κάθε δωμάτιο
        public void light_in_hol(bool light_hol)
        {
            this.light_hol = light_hol;
        }

        public void light_in_living_room(bool light_living_room)
        {
            this.light_living_room = light_living_room;
        }

        public void light_in_kitchen(bool light_kitchen)
        {
            this.light_kitchen = light_kitchen;
        }

        public void light_in_bathroom(bool light_bathroom)
        {
            this.light_bathroom = light_bathroom;
        }

        public void light_in_bedroom(bool light_bedroom)
        {
            this.light_bedroom = light_bedroom;
        }

        public void light_in_garage(bool light_garage)
        {
            this.light_garage = light_garage;
        }

        // δημιουργία setter για τις μεταβλητές που "ρυθμίζουν" την θερμοκρασία σε κάθε δωμάτιο
        public void temp_in_hol(bool temp_hol)
        {
            this.temp_hol = temp_hol;
        }

        public void temp_in_living_room(bool temp_living_room)
        {
            this.temp_living_room = temp_living_room;
        }

        public void temp_in_kitchen(bool temp_kitchen)
        {
            this.temp_kitchen = temp_kitchen;
        }

        public void temp_in_bathroom(bool temp_bathroom)
        {
            this.temp_bathroom = temp_bathroom;
        }

        public void temp_in_bedroom(bool temp_bedroom)
        {
            this.temp_bedroom = temp_bedroom;
        }

        public void temp_in_garage(bool temp_garage)
        {
            this.temp_garage = temp_garage;
        }

        // δημιουργία setter για την μεταβλητή που "ρυθμίζει" την κατάσταση της παπουτσοθήκης
        public void setter_papoutsothiki(bool papoutsothiki)
        {
            this.papoutsotiki = papoutsothiki;
        }

        // δημιουργία setter για την μεταβλητή που "ρυθμίζει" την κατάσταση της καφετιέρας
        public void setter_kafetiera(bool kafetiera)
        {
            this.kafetiera = kafetiera;
        }

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
            labelWelcome.Location        = new Point(Width / 2 - labelWelcome.Width / 2, labelWelcome.Location.Y);
            label_choose_action.Location = new Point(Width / 2 - label_choose_action.Width / 2, label_choose_action.Location.Y);

            labelAnimalWarning.Visible = false;

            //θα βάλουμε από 1-4 γάτες στα κατοικίδιάς μας.
            for (int i = 0; i < random.Next(1, 4); i++)
                Pets.Add(new Cat());

            //το ίδιο ισχύει και για τους σκύλους.
            for (int i = 0; i < random.Next(1, 4); i++)
                Pets.Add(new Dog());

            //debugging.
            foreach (Animal animal in Pets)
                Console.WriteLine(animal.ToString());

        }

        private void timerAnimals_Tick(object sender, EventArgs e)
        {

        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //όταν κλείνει η φόρμα, θα πρέπει να κλείνει και η αρχική, καθώς θα κλείνει και όλο το πρόγραμμα έτσι.
            Application.OpenForms[0].Close();
        }

        private void buttonThermansi_Click(object sender, EventArgs e)
        {
            // άνοιγμα φόρμα διαχείρισης συσκευών.
            Remote_Device_Control rmctrl = new Remote_Device_Control();
            rmctrl.Show();

            // "περνάμε" όλες τις μεταβλητές σχετικά με την κατάσταση των δωματίων (φωτισμός,θερμότητα, καφετιέρα και παπουτσοθήκη)
            // στην φόρμα που διαχειρίζεται τις συσκευές του σπιτιού.
            rmctrl.light_bathroom = light_bathroom;
            rmctrl.light_bedroom = light_bedroom;
            rmctrl.light_garage = light_garage;
            rmctrl.light_hol = light_hol;
            rmctrl.light_kitchen = light_kitchen;
            rmctrl.light_living_room = light_living_room;
            rmctrl.kafetiera = kafetiera;
            rmctrl.temp_bathroom = temp_bathroom;
            rmctrl.temp_bedroom = temp_bedroom;
            rmctrl.temp_garage = temp_garage;
            rmctrl.temp_hol = temp_hol;
            rmctrl.temp_kitchen = temp_kitchen;
            rmctrl.temp_living_room = temp_living_room;
            rmctrl.papoutsotiki = papoutsotiki;
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
