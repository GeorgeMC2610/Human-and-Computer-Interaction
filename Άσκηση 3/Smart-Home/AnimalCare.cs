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
    public partial class AnimalCare : Form
    {
        /* TODO:
         * Και πρέπει να βρω εικόνες για μπωλ.
         * Να βάλω ήχους όποτε γίνεται κάτι.
         */

        public AnimalCare()
        {
            InitializeComponent();
        }

        public AnimalCare(int[] cat, int[] dog)
        {
            InitializeComponent();

            //παίρνουμε τις τιμές για τυχαίες εικόνες
            Bitmap[] cat_pics = { Properties.Resources.cat1, Properties.Resources.cat2, Properties.Resources.cat3 };
            Bitmap[] dog_pics = { Properties.Resources.dog1, Properties.Resources.dog2, Properties.Resources.dog3 };

            pictureBoxCat1.Image = cat_pics[cat[0]];
            pictureBoxCat2.Image = cat_pics[cat[1]];
            pictureBoxCat3.Image = cat_pics[cat[2]];
         
            pictureBoxDog1.Image = dog_pics[dog[0]];
            pictureBoxDog2.Image = dog_pics[dog[1]];
            pictureBoxDog3.Image = dog_pics[dog[2]];
        }

        private void AnimalCare_Load(object sender, EventArgs e)
        {
            //ξεχωρίζουμε τις γάτες από τους σκύλους.
            Animal[] cats = (from pet in FormMain.Pets where pet is Cat select pet).ToArray();
            Animal[] dogs = (from pet in FormMain.Pets where pet is Dog select pet).ToArray();

            //εφ' όσον υπάρχει τουλάχιστον μία γάτα και τουλάχιστον ένας σκύλος, θέτουμε κατ' ευθείαν τα ονόματά τους.
            labelCat1.Text = cats[0].Name;
            labelDog1.Text = dogs[0].Name;

            //φτιάχνουμε τα ονόματα για τις γάτες, εκεί που υπάρχουν. Αλλιώς σβήνουμε το πίξουρ μποξ και το λέημπελ.
            if (cats.Length >= 2)
                labelCat2.Text = cats[1].Name;
            else
                labelCat2.Visible = pictureBoxCat2.Visible = false;

            if (cats.Length >= 3)
                labelCat3.Text = cats[2].Name;
            else
                labelCat3.Visible = pictureBoxCat3.Visible = false;

            //το ίδιο κάνουμε και για τους σκύλους.
            if (dogs.Length >= 2)
                labelDog2.Text = dogs[1].Name;
            else
                labelDog2.Visible = pictureBoxDog2.Visible = false;

            if (dogs.Length >= 3)
                labelDog3.Text = dogs[2].Name;
            else
                labelDog3.Visible = pictureBoxDog3.Visible = false;

            //φτιάχνουμε τα labels να 'ναι στα σωστά σημεία, ακόμη κι όταν κάνουμε resize.
            labelCat1.Location = new Point(pictureBoxCat1.Location.X + pictureBoxCat1.Width/2 - labelCat1.Width / 2, labelCat1.Location.Y);
            labelCat2.Location = new Point(pictureBoxCat2.Location.X + pictureBoxCat2.Width/2 - labelCat2.Width / 2, labelCat2.Location.Y);
            labelCat3.Location = new Point(pictureBoxCat3.Location.X + pictureBoxCat3.Width/2 - labelCat3.Width / 2, labelCat3.Location.Y);

            labelDog1.Location = new Point(pictureBoxDog1.Location.X + pictureBoxDog1.Width / 2 - labelDog1.Width / 2, labelDog1.Location.Y);
            labelDog2.Location = new Point(pictureBoxDog2.Location.X + pictureBoxDog2.Width / 2 - labelDog2.Width / 2, labelDog2.Location.Y);
            labelDog3.Location = new Point(pictureBoxDog3.Location.X + pictureBoxDog3.Width / 2 - labelDog3.Width / 2, labelDog3.Location.Y);

            //κάνουμε και τα labels του φαγητού resize
            FixBowlLabelLocations();

            //αν υπάρχει τουλάχιστον ένα σπασμένο αντικείμενο τότε ενεργοποιούμε το κουμπί.
            HandleButton((from furniture in FormMain.FragileFurniture where furniture.Broken select furniture).Any());

            //βάζουμε την ποσότητα φαγητού και νερού σωστά στα progress bars
            UpdateProgressBars();
        }

        private void HandleButton(bool handling)
        {
            buttonFixBrokenFurniture.Enabled   =  handling;
            buttonFixBrokenFurniture.BackColor = (handling) ? Color.WhiteSmoke : Color.Gray;
            buttonFixBrokenFurniture.ForeColor = (handling) ? Color.Black : Color.DarkGray;
        }

        private void UpdateProgressBars()
        {
            progressBarCatWater.Value = FormMain.Bowls[0].Capacity;
            progressBarDogWater.Value = FormMain.Bowls[1].Capacity;
            progressBarCatFood.Value  = FormMain.Bowls[2].Capacity;
            progressBarDogFood.Value  = FormMain.Bowls[3].Capacity;
        }

        private void FixBowlLabelLocations()
        {
            labelCatWater.Location = new Point(pictureBoxCatBowlWater.Location.X + pictureBoxCatBowlWater.Width / 2 - labelCatWater.Width / 2, labelCatWater.Location.Y);
            labelCatFood.Location = new Point(pictureBoxCatBowlFood.Location.X + pictureBoxCatBowlFood.Width / 2 - labelCatFood.Width / 2, labelCatFood.Location.Y);
            labelDogWater.Location = new Point(pictureBoxDogBowlWater.Location.X + pictureBoxDogBowlWater.Width / 2 - labelDogWater.Width / 2, labelDogWater.Location.Y);
            labelDogFood.Location = new Point(pictureBoxDogBowlFood.Location.X + pictureBoxDogBowlFood.Width / 2 - labelDogFood.Width / 2, labelDogFood.Location.Y);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            HandleButton((from furniture in FormMain.FragileFurniture where furniture.Broken select furniture).Any());
            Console.WriteLine("there are " + (from furniture in FormMain.FragileFurniture where furniture.Broken select furniture).ToArray().Length.ToString() + " broken furniture");
            UpdateProgressBars();
            FixBowlLabelLocations();
        }

        private void buttonFixBrokenFurniture_Click(object sender, EventArgs e)
        {
            FormMain.FragileFurniture.ForEach(f => f.Repair());
            HandleButton((from furniture in FormMain.FragileFurniture where furniture.Broken select furniture).Any());
        }

        private void buttonRefill_Click(object sender, EventArgs e)
        {
            foreach (Bowl b in FormMain.Bowls)
                b.Capacity = Bowl.MaxCapacity;

            Console.WriteLine("Filled all bowls.");
            UpdateProgressBars();
        }
    }
}
