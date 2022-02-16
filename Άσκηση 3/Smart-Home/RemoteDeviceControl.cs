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

        // οι μεταβλητές αυτές ορίζουν τους 'διακόπτες΄ για την θερμοκρασία του κάθε δωματίου
        bool temp_hol = false;
        bool temp_living_room = false;
        bool temp_kitchen = false;
        bool temp_garage = false;
        bool temp_bathroom = false;
        bool temp_bedroom = false;

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
                pictureBox17.ImageLocation = @"C:/Users/strat/OneDrive/Έγγραφα/GitHub/Human-and-Computer-Interaction/Άσκηση 3/Imageshole-dark-light";
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

        // διαχείριση θέρμανσης στο χωλ
        private void button3_Click(object sender, EventArgs e)
        {
            if (temp_hol == false)
            {
                button3.Text = "Κλέίσιμο θέρμανσης";
                MessageBox.Show("Η θέρμανση στο χωλ έχει ανοίξει.");
                temp_hol = true;

            }
            else
            {
                temp_hol = false;
                button3.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο χωλ έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στο χωλ
        private void button4_Click(object sender, EventArgs e)
        {
            if (temp_living_room == false)
            {
                button4.Text = "Κλέίσιμο θέρμανσης";
                MessageBox.Show("Η θέρμανση στο σαλόνι έχει ανοίξει.");
                temp_living_room = true;

            }
            else
            {
                temp_living_room = false;
                button4.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο σαλόνι έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στην κουζίνα
        private void button6_Click(object sender, EventArgs e)
        {
            if (temp_kitchen == false)
            {
                button6.Text = "Κλέίσιμο θέρμανσης";
                MessageBox.Show("Η θέρμανση στην κουζίνα έχει ανοίξει.");
                temp_kitchen = true;

            }
            else
            {
                temp_kitchen = false;
                button6.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στην κουζίνα έχει κλείσει.");
            }
        }
        
        // διαχείριση θέρμανσης στο μπάνιο
        private void button9_Click(object sender, EventArgs e)
        {
            if (temp_bathroom == false)
            {
                button9.Text = "Κλέίσιμο θέρμανσης";
                MessageBox.Show("Η θέρμανση στο μπάνιο έχει ανοίξει.");
                temp_bathroom = true;

            }
            else
            {
                temp_bathroom = false;
                button9.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο μπάνιο έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στο υπνοδωμάτιο
        private void button12_Click(object sender, EventArgs e)
        {
            if (temp_bedroom == false)
            {
                button12.Text = "Κλέίσιμο θέρμανσης";
                MessageBox.Show("Η θέρμανση στο υπνοδωμάτιο έχει ανοίξει.");
                temp_bedroom = true;

            }
            else
            {
                temp_bedroom = false;
                button12.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο υπνοδωμάτιο έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στο γκαραζ
        private void button13_Click(object sender, EventArgs e)
        {
            if (temp_garage == false)
            {
                button13.Text = "Κλέίσιμο θέρμανσης";
                MessageBox.Show("Η θέρμανση στο γκαράζ έχει ανοίξει.");
                temp_garage = true;

            }
            else
            {
                temp_garage = false;
                button13.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο γκαράζ έχει κλείσει.");
            }
        }
    }
}
