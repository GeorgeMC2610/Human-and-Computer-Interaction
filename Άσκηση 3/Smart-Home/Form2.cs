﻿using System;
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
        // - Πρέπει να κάνω τα ζώα να σπάνε αντικείμενα
        // - Πρέπει να βρω φωτογραφίες για τα ζώα, άδειο και γεμάτο μπωλ
        // - Πρέπει τα ζώα να τρώνε και να πίνουν νερό, και να τα γεμίζει ο χρήστης.

        public static List<FragileFurniture> FragileFurniture = new List<FragileFurniture>();
        public static List<Animal> Pets = new List<Animal>();

        public static Bowl[] Bowls = new Bowl[4];

        private static int[] CatImages = { 0, 1, 2 };
        private static int[] DogImages = { 0, 1, 2 };

        private static readonly Random random = new Random();
        public static bool isHome = false;

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

            //θα βάλουμε από 1-3 γάτες στα κατοικίδιάς μας.
            for (int i = 0; i < random.Next(1, 4); i++)
            {
                Cat potential_cat = new Cat();

                //εδώ σιγουρευόμαστε ότι δεν θα υπάρξει γάτα που θα 'χει ίδιο όνομα με άλλη γάτα.
                if (!(from pet in Pets where pet.Name == potential_cat.Name select pet).Any())
                    Pets.Add(potential_cat);
            }

            //το ίδιο ισχύει και για τους σκύλους.
            for (int i = 0; i < random.Next(1, 4); i++)
            {
                Dog potential_dog = new Dog();

                //εδώ σιγουρευόμαστε ότι δεν θα υπάρξει σκύλος που θα 'χει ίδιο όνομα με κάποιον άλλο σκύλο.
                if (!(from pet in Pets where pet.Name == potential_dog.Name select pet).Any())
                    Pets.Add(potential_dog);
            }

            for (int i = 0; i < random.Next(10, 20); i++)
                FragileFurniture.Add(new FragileFurniture());

            Bowls[0] = new Bowl(true);
            Bowls[1] = new Bowl(true);
            Bowls[2] = new Bowl(false);
            Bowls[3] = new Bowl(false);

            CatImages = Shuffle(CatImages);
            DogImages = Shuffle(DogImages);
        }

        public int[] Shuffle(int[] array)
        {
            int n = array.Length;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                int value = array[k];
                array[k] = array[n];
                array[n] = value;
            }

            return array;
        }


        private void timerAnimals_Tick(object sender, EventArgs e)
        {
            if ((from bowl in Bowls where bowl.Capacity < 20 select bowl.Capacity).Any())
            {
                labelAnimalWarning.Text = "Ίσως χρειαστεί να γεμίσετε κάποιο μπωλ.";
                labelAnimalWarning.Visible = true;
            }

            //Αν ο Χρήστης είναι σπίτι, τότε τα ζώα έχουνε μικρή πιθανότητα να σπάσουν κάτι ή να είναι ζωηρά.
            if (isHome)
            {
                if (random.Next(0, 10) < 6)
                    Pets.ForEach(pet => pet.Calm());
                else
                    Pets.ForEach(pet => pet.Awaken());

            }
            else
            {
                if (random.Next(0, 10) < 6)
                    Pets.ForEach(pet => pet.Awaken());
                else
                    Pets.ForEach(pet => pet.Calm());
            }

            if (random.Next(0, 10) == 5)
                Pets.ForEach(pet => pet.ManageNeeds());

            Pets.ForEach(pet => pet.Debug());
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            //όταν κλείνει η φόρμα, θα πρέπει να κλείνει και η αρχική, καθώς θα κλείνει και όλο το πρόγραμμα έτσι.
            Application.OpenForms[0].Close();
        }

        // κουμπί μενού: Διαχείριση Συσκευών
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

        // κουμπί μενού: Φροντίδα κατοικιδίου
        private void buttonAnimalCare_Click(object sender, EventArgs e)
        {
            //open form
            AnimalCare animal = new AnimalCare(CatImages, DogImages);
            animal.Show();
        }

        // κουμπί 'βοήθεια'
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            // εμφάνιση φόρμα βοήθειας
            Help help = new Help();
            help.Show();
        }
    }
}
