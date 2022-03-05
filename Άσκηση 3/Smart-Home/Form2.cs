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
        // - Πρέπει να βρω φωτογραφίες για άδειο και γεμάτο μπωλs

        public static List<FragileFurniture> FragileFurniture = new List<FragileFurniture>();
        public static List<Animal> Pets = new List<Animal>();

        public static Bowl[] Bowls = new Bowl[4];

        private static int[] CatImages = { 0, 1, 2 };
        private static int[] DogImages = { 0, 1, 2 };

        private static readonly Random random = new Random();
        public static bool isHome = false;

        // αντικείμενο φόρμας διαχέρισης συσκευών
        Remote_Device_Control rmctrl;

        // αντικείμενο φόρμας διαχείρισης προγράμματος ημέρας
        TimeSchedule schedule;

        public FormMain()
        {
            InitializeComponent();
            rmctrl = new Remote_Device_Control();
            schedule = new TimeSchedule();
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
            if ((from bowl in Bowls where bowl.Capacity < 20 select bowl.Capacity).Any() || (from furniture in FragileFurniture where furniture.Broken select furniture).Any())
                labelAnimalWarning.Visible = true;
            else
                labelAnimalWarning.Visible = false;

            //Αν ο Χρήστης είναι σπίτι, τότε τα ζώα έχουνε μικρή πιθανότητα να σπάσουν κάτι ή να είναι ζωηρά.
            if (isHome)
            {
                if (random.Next(0, 10) < 6)
                    Pets.ForEach(pet => pet.Calm());
                else
                    Pets.ForEach(pet => pet.Awaken());

                //1% πιθανότητα να σπάσει κάτι ένα ζώο.
                if (random.Next(0, 100) == 0)
                    AnimalBreakFurniture();
                
            }
            else
            {
                if (random.Next(0, 10) < 6)
                    Pets.ForEach(pet => pet.Awaken());
                else
                    Pets.ForEach(pet => pet.Calm());

                //1 στις 30 πιθανότητα να σπάσει κάποιο αντικείμενο ένα ζώο.
                if (random.Next(0, 30) == 0)
                    AnimalBreakFurniture();
            }

            //έχουμε 10% πιθανότητα να πεινάσει/διψάσει κάποιο ζώο.
            if (random.Next(0, 10) == 0)
                Pets.ForEach(pet => pet.ManageNeeds());

            foreach (Animal pet in Pets)
            {
                //βλέπουμε κλιμακωτά την πείνα και βλέπουμε αν ένα ζώο πρέπει να φάει ή όχι.
                if (pet.hungerPercentage < 10)
                    continue;
                else if (pet.hungerPercentage < 20)
                {
                    if (random.Next(0, 10) < 3)
                    {
                        Bowls[2] = (pet is Cat) ? pet.Eat(Bowls[2]) : Bowls[2];
                        Bowls[3] = (pet is Dog) ? pet.Eat(Bowls[3]) : Bowls[3];
                    }
                }
                else if (pet.hungerPercentage < 50)
                {
                    if (random.Next(0, 10) < 5)
                    {
                        Bowls[2] = (pet is Cat) ? pet.Eat(Bowls[2]) : Bowls[2];
                        Bowls[3] = (pet is Dog) ? pet.Eat(Bowls[3]) : Bowls[3];
                    }
                }
                else if (pet.hungerPercentage < 70)
                {
                    if (random.Next(0, 10) < 8)
                    {
                        Bowls[2] = (pet is Cat) ? pet.Eat(Bowls[2]) : Bowls[2];
                        Bowls[3] = (pet is Dog) ? pet.Eat(Bowls[3]) : Bowls[3];
                    }
                }
                else
                {
                    Bowls[2] = (pet is Cat) ? pet.Eat(Bowls[2]) : Bowls[2];
                    Bowls[3] = (pet is Dog) ? pet.Eat(Bowls[3]) : Bowls[3];
                }

                //το ίδιο κάνουμε και για την δίψα.
                if (pet.thirstPercentage < 20)
                {
                    if (random.Next(0, 10) < 3)
                    {
                        Bowls[0] = (pet is Cat) ? pet.Drink(Bowls[0]) : Bowls[0];
                        Bowls[1] = (pet is Dog) ? pet.Drink(Bowls[1]) : Bowls[1];
                    }
                }
                else if (pet.thirstPercentage < 50)
                {
                    if (random.Next(0, 10) < 5)
                    {
                        Bowls[0] = (pet is Cat) ? pet.Drink(Bowls[0]) : Bowls[0];
                        Bowls[1] = (pet is Dog) ? pet.Drink(Bowls[1]) : Bowls[1];
                    }
                }
                else if (pet.thirstPercentage < 70)
                {
                    if (random.Next(0, 10) < 8)
                    {
                        Bowls[0] = (pet is Cat) ? pet.Drink(Bowls[0]) : Bowls[0];
                        Bowls[1] = (pet is Dog) ? pet.Drink(Bowls[1]) : Bowls[1];
                    }
                }
                else
                {
                    Bowls[0] = (pet is Cat) ? pet.Drink(Bowls[0]) : Bowls[0];
                    Bowls[1] = (pet is Dog) ? pet.Drink(Bowls[1]) : Bowls[1];
                }

            }

            Pets.ForEach(pet => pet.Debug());
        }

        private void AnimalBreakFurniture()
        {
            //παίρνουμε τα
            var ActiveAnimals = (from pet in Pets where pet.activityPercentage > (isHome ? 50 : 40) select pet).ToArray();
            var NotBrokenFragileFurniture = (from furniture in FragileFurniture where !furniture.Broken select furniture).ToArray();

            if (ActiveAnimals.Length == 0 || NotBrokenFragileFurniture.Length == 0)
                return;

            ActiveAnimals[random.Next(0, ActiveAnimals.Length)].BreakFurniture(NotBrokenFragileFurniture[random.Next(0, NotBrokenFragileFurniture.Length)]);
            Console.WriteLine("Random furniture just broke.");
            labelAnimalWarning.Visible = true;
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

        // κουμπί μενού: Εισαγωγή Προγράμματος
        private void buttonTimeSchedule_Click(object sender, EventArgs e)
        {
            //open form
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
