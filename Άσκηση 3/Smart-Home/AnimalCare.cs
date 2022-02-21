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
        }
    }
}
