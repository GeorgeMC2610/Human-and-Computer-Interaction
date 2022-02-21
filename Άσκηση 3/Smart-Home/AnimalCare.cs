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

        public AnimalCare()
        {
            InitializeComponent();
        }

        private void AnimalCare_Load(object sender, EventArgs e)
        {
            Animal[] cats = (from pet in FormMain.Pets where pet is Cat select pet).ToArray();
            Animal[] dogs = (from pet in FormMain.Pets where pet is Dog select pet).ToArray();

            labelCat1.Text = cats[0].Name;
            labelDog1.Text = dogs[0].Name;

            //φτιάχνουμε τα ονόματα για τις γάτες
            if (cats.Length >= 2)
                labelCat2.Text = cats[1].Name;
            else
                labelCat2.Visible = false;

            if (cats.Length >= 3)
                labelCat3.Text = cats[2].Name;
            else
                labelCat3.Visible = false;

            //φτιάχνουμε τα ονόματα για τους σκύλους
            if (dogs.Length >= 2)
                labelDog2.Text = dogs[1].Name;
            else
                labelDog2.Visible = false;

            if (dogs.Length >= 3)
                labelDog3.Text = dogs[2].Name;
            else
                labelDog3.Visible = false;

            labelCat1.Location = new Point(pictureBoxCat1.Location.X / 2 - labelCat1.Width / 2, labelCat1.Location.Y);
            labelCat2.Location = new Point(pictureBoxCat2.Location.X / 2 - labelCat2.Width / 2, labelCat2.Location.Y);
            labelCat3.Location = new Point(pictureBoxCat3.Location.X / 2 - labelCat3.Width / 2, labelCat3.Location.Y);

            labelDog1.Location = new Point(pictureBoxDog1.Location.X / 2 - labelDog1.Width / 2, labelDog1.Location.Y);
            labelDog2.Location = new Point(pictureBoxDog2.Location.X / 2 - labelDog2.Width / 2, labelDog2.Location.Y);
            labelDog3.Location = new Point(pictureBoxDog3.Location.X / 2 - labelDog3.Width / 2, labelDog3.Location.Y);


        }
    }
}
