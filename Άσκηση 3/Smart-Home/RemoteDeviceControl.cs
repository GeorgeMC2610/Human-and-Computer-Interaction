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
    // αυτή η φόρμα χρησιμοποιείται για την διαχέιριση όλων των συσκευών της εφαρμογής
    public partial class Remote_Device_Control : Form
    {
        // οι μεταβλητές αυτές ορίζουν τους 'διακόπτες΄ των φωτών οροφής του κάθε δωματίου
        bool light_hol = false;
        bool light_living_room = false;
        bool light_kitchen = false;
        bool light_garage = false;
        bool light_bathroom = false;
        bool light_bedroom = false;

        public Remote_Device_Control()
        {
            InitializeComponent();
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στο χωλ
        private void button1_Click(object sender, EventArgs e)
        {
            if (light_hol)
            {
                pictureBox1.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Imageshole-dark-light";
                light_hol = false;
            }
            else
            {
                pictureBox1.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Images\hole";
                light_hol = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στο σαλόνι
        private void button15_Click(object sender, EventArgs e)
        {
            if (light_living_room)
            {
                pictureBox17.Image = @"C:/Users/strat/OneDrive/Έγγραφα/GitHub/Human-and-Computer-Interaction/Άσκηση 3/Imageshole-dark-light";
                light_living_room = false;
            }
            else
            {
                pictureBox17.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Images\hole";
                light_living_room = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στην κουζίνα
        private void button8_Click(object sender, EventArgs e)
        {
            if (light_kitchen)
            {
                pictureBox20.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Imageshole-dark-light";
                light_kitchen = false;
            }
            else
            {
                pictureBox20.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Images\hole";
                light_kitchen = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στο μπάνιο
        private void button11_Click(object sender, EventArgs e)
        {
            if (light_bathroom)
            {
                pictureBox11.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Imageshole-dark-light";
                light_bathroom = false;
            }
            else
            {
                pictureBox11.ImageLocation = @"C:\Users\strat\OneDrive\Έγγραφα\GitHub\Human-and-Computer-Interaction\Άσκηση 3\Images\hole";
                light_bathroom = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στo υπνοδωμάτιο
        private void button17_Click(object sender, EventArgs e)
        {
            if (light_bedroom)
            {
                light_bedroom = false;
            }
            else
            {
                light_bedroom = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στo γκαράζ
        private void button18_Click(object sender, EventArgs e)
        {
            if (light_garage)
            {
                light_garage = false;
            }
            else
            {
                light_garage = true;
            }
        }
    }
}
