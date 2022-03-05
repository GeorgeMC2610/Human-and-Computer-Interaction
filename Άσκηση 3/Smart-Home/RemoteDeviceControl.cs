using System;
using System.Drawing;
using System.Windows.Forms;

namespace Smart_Home
{
    // αυτή η φόρμα χρησιμοποιείται για την διαχέιριση όλων των συσκευών της εφαρμογής
    public partial class Remote_Device_Control : Form
    {
        // οι μεταβλητές αυτές ορίζουν τους 'διακόπτες΄ των φωτών οροφής του κάθε δωματίου
        private bool light_hol = false;
        private bool light_living_room = false;
        private bool light_kitchen = false;
        private bool light_garage = false;
        private bool light_bathroom = false;
        private bool light_bedroom = false;

        // οι μεταβλητές αυτές ορίζουν τους 'διακόπτες΄ για την θερμοκρασία του κάθε δωματίου
        private bool  temp_hol = false;
        private bool temp_living_room = false;
        private bool temp_kitchen = false;
        private bool temp_garage = false;
        private bool temp_bathroom = false;
        private bool temp_bedroom = false;

        // διακόπτης που ρυθμίζει την κατάσταση λειτουργίας της παπουτσοθήκης
        private bool papoutsotiki = false;

        // διακόπτης που ρυθμίζει την κατάσταση λειτουργίας της καφετιέρας
        private bool kafetiera = false;

        public Remote_Device_Control()
        {
            InitializeComponent();
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στο χωλ
        private void button1_Click(object sender, EventArgs e)
        {
            if (light_hol)
            {
                pictureBox1.Image = Properties.Resources.hole_dark_light;
                pictureBox6.Image = Properties.Resources.lights_off;
                button1.Text = "Άνοιγμα φωτός";
                light_hol = false;
            }
            else
            {
                pictureBox1.Image = Properties.Resources.hole;
                pictureBox6.Image = Properties.Resources.lights_on;
                button1.Text = "Κλείσιμο φωτός";
                light_hol = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στο σαλόνι
        private void button15_Click(object sender, EventArgs e)
        {
            if (light_living_room)
            {
                pictureBox17.Image = Properties.Resources.living_room_dark_light;
                pictureBox7.Image = Properties.Resources.lights_off;
                button15.Text = "Άνοιγμα φωτός";
                light_living_room = false;
            }
            else
            {
                pictureBox17.Image = Properties.Resources.living_room_medium_light;
                pictureBox7.Image = Properties.Resources.lights_on;
                button15.Text = "Κλείσιμο φωτός";
                light_living_room = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στην κουζίνα
        private void button8_Click(object sender, EventArgs e)
        {
            if (light_kitchen)
            {
                pictureBox20.Image = Properties.Resources.kitchen_dark_light;
                pictureBox8.Image = Properties.Resources.lights_off;
                button8.Text = "Άνοιγμα φωτός";
                light_kitchen = false;    
            }
            else
            {
                pictureBox20.Image = Properties.Resources.kitchen_medium_light;
                pictureBox8.Image = Properties.Resources.lights_on;
                button8.Text = "Κλείσιμο φωτός";
                light_kitchen = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στο μπάνιο
        private void button11_Click(object sender, EventArgs e)
        {
            if (light_bathroom)
            {
                pictureBox11.Image = Properties.Resources.bathroom_dark_light;
                pictureBox9.Image = Properties.Resources.lights_off;
                button11.Text = "Άνοιγμα φωτός";
                light_bathroom = false;
            }
            else
            {
                pictureBox11.Image = Properties.Resources.bathroom_medium_light;
                pictureBox9.Image = Properties.Resources.lights_on;
                button11.Text = "Κλείσιμο φωτός";
                light_bathroom = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στo υπνοδωμάτιο
        private void button17_Click(object sender, EventArgs e)
        {
            if (light_bedroom)
            {
                pictureBox22.Image = Properties.Resources.bedroom_dark_light;
                pictureBox13.Image = Properties.Resources.lights_off;
                button17.Text = "Άνοιγμα φωτός";
                light_bedroom = false;
            }
            else
            {
                pictureBox22.Image = Properties.Resources.bedroom_medium_light;
                pictureBox13.Image = Properties.Resources.lights_on;
                button17.Text = "Κλείσιμο φωτός";
                light_bedroom = true;
            }
        }

        // το κουμπί αυτό διαχειρίζεται το φως οροφής στo γκαράζ
        private void button18_Click(object sender, EventArgs e)
        {
            if (light_garage)
            {
                pictureBox23.Image = Properties.Resources.garage_dark_light;
                pictureBox15.Image = Properties.Resources.lights_off;
                button18.Text = "Άνοιγμα φωτός";
                light_garage = false;
            }
            else
            {
                pictureBox23.Image = Properties.Resources.garage;
                pictureBox15.Image = Properties.Resources.lights_on;
                button18.Text = "Κλείσιμο φωτός";
                light_garage = true;
            }
        }

        // διαχείριση θέρμανσης στο χωλ
        private void button3_Click(object sender, EventArgs e)
        {
            if (temp_hol == false)
            {
                button3.Text = "Κλείσιμο θέρμανσης";
                pictureBox5.Image = Properties.Resources.temperature;
                MessageBox.Show("Η θέρμανση στο χωλ έχει ανοίξει.");
                temp_hol = true;

            }
            else
            {
                temp_hol = false;
                pictureBox5.Image = Properties.Resources.temperature_cold;
                button3.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο χωλ έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στο σαλόνι
        private void button4_Click(object sender, EventArgs e)
        {
            if (temp_living_room == false)
            {
                button4.Text = "Κλείσιμο θέρμανσης";
                pictureBox2.Image = Properties.Resources.temperature;
                MessageBox.Show("Η θέρμανση στο σαλόνι έχει ανοίξει.");
                temp_living_room = true;

            }
            else
            {
                temp_living_room = false;
                pictureBox2.Image = Properties.Resources.temperature_cold;
                button4.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στο σαλόνι έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στην κουζίνα
        private void button6_Click(object sender, EventArgs e)
        {
            if (temp_kitchen == false)
            {
                button6.Text = "Κλείσιμο θέρμανσης";
                pictureBox4.Image = Properties.Resources.temperature;
                MessageBox.Show("Η θέρμανση στην κουζίνα έχει ανοίξει.");
                temp_kitchen = true;

            }
            else
            {
                temp_kitchen = false;
                pictureBox4.Image = Properties.Resources.temperature_cold;
                button6.Text = "Άνοιγμα θέρμανσης";
                MessageBox.Show("Η θέρμανση στην κουζίνα έχει κλείσει.");
            }
        }
        
        // διαχείριση θέρμανσης στο μπάνιο
        private void button9_Click(object sender, EventArgs e)
        {
            if (temp_bathroom == false)
            {
                button9.Text = "Κλείσιμο θέρμανσης";
                pictureBox3.Image = Properties.Resources.temperature;
                MessageBox.Show("Η θέρμανση στο μπάνιο έχει ανοίξει.");
                temp_bathroom = true;

            }
            else
            {
                temp_bathroom = false;
                button9.Text = "Άνοιγμα θέρμανσης";
                pictureBox3.Image = Properties.Resources.temperature_cold;
                MessageBox.Show("Η θέρμανση στο μπάνιο έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στο υπνοδωμάτιο
        private void button12_Click(object sender, EventArgs e)
        {
            if (temp_bedroom == false)
            {
                button12.Text = "Κλείσιμο θέρμανσης";
                pictureBox12.Image = Properties.Resources.temperature;
                MessageBox.Show("Η θέρμανση στο υπνοδωμάτιο έχει ανοίξει.");
                temp_bedroom = true;

            }
            else
            {
                temp_bedroom = false;
                button12.Text = "Άνοιγμα θέρμανσης";
                pictureBox12.Image = Properties.Resources.temperature_cold;
                MessageBox.Show("Η θέρμανση στο υπνοδωμάτιο έχει κλείσει.");
            }
        }

        // διαχείριση θέρμανσης στο γκαραζ
        private void button13_Click(object sender, EventArgs e)
        {
            if (temp_garage == false)
            {
                button13.Text = "Κλείσιμο θέρμανσης";
                pictureBox14.Image = Properties.Resources.temperature;
                MessageBox.Show("Η θέρμανση στο γκαράζ έχει ανοίξει.");
                temp_garage = true;

            }
            else
            {
                temp_garage = false;
                button14.Text = "Άνοιγμα θέρμανσης";
                pictureBox12.Image = Properties.Resources.temperature_cold;
                MessageBox.Show("Η θέρμανση στο γκαράζ έχει κλείσει.");
            }
        }

        // περισσότερες ρυθμίσεις για το δωμάτιο 'χωλ'
        private void label1_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel7.Visible = true;
            pictureBox10.Image = pictureBox5.Image;
            panel7.Location = panel1.Location;
        }

        // επιστροφή στο κύριο μενού διαχείρισης του χωλ
        private void button5_Click(object sender, EventArgs e)
        {
            panel7.Visible = false;
            panel1.Visible = true;
        }

        // κουμπί για πλύσιμο παπουτσιών
        private void button7_Click(object sender, EventArgs e)
        {
            if (papoutsotiki)
                MessageBox.Show("Τα παπούτσια πλύθηκαν με επιτυχία!");
            else
                MessageBox.Show("Η παπουτσοθήκη δεν έχει ενεργοποιηθεί!");
        }

        // κουμπί για αυτοκαθαρισμό της παπουτσοθήκης
        private void button14_Click(object sender, EventArgs e)
        {
            if (papoutsotiki)
                MessageBox.Show("Η παπουτσοθήκη έχει καθαριστεί!");
            else
                MessageBox.Show("Η παπουτσοθήκη δεν έχει ενεργοποιηθεί!");
        }

        // διαχείριση έντασης θερμοκρασίας στο χωλ
        private void button16_Click(object sender, EventArgs e)
        {
            if (temp_hol) // έλεγχος για το εάν η θέρμανση είναι ενεργοποιημένη στο χωλ
            {
                if (radioButton1.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο χωλ ορίστηκε σε: χαμηλή");
                }
                else if (radioButton2.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο χωλ ορίστηκε σε: μέτρια");
                }
                else if (radioButton3.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο χωλ ορίστηκε σε: υψηλή");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, ορίστε θερμοκρασία!");
                }
            }
            else
            {
                MessageBox.Show("Η θέρμανση στο χωλ δεν είναι ενεργοποιημένη!");
            }
        }

        // κουμπί για το άνοιγμα και κλείσιμο της παπουτσοθήκης
        private void button2_Click(object sender, EventArgs e)
        {
            if (papoutsotiki)
            {
                button2.Text = "Άνοιγμα παπουτσοθήκης";
                MessageBox.Show("Η παπουτσοθήκη απενεργοποιήθηκε!");
                papoutsotiki = false;
            }
            else
            {
                button2.Text = "Κλείσιμο παπουτσοθ.";
                MessageBox.Show("Η παπουτσοθήκη ενεργοποιήθηκε!");
                papoutsotiki = true;
            }
        }

        // περισσότερες ρυθμίσεις για το δωμάτιο 'σαλόνι'
        private void label2_Click(object sender, EventArgs e)
        {
            panel8.Visible = true;
            panel2.Visible = false;
            pictureBox16.Image = pictureBox2.Image;
            panel8.Location = panel2.Location;
        }

        // επιστροφή στο κύριο μενού διαχείρισης του σαλονιού
        private void button21_Click(object sender, EventArgs e)
        {
            panel8.Visible = false;
            panel2.Visible = true;
        }

        // διαχείριση έντασης θερμοκρασίας στο σαλόνι
        private void button10_Click(object sender, EventArgs e)
        {
            if (temp_living_room) // έλεγχος για το εάν η θέρμανση είναι ενεργοποιημένη στο σαλόνι
            {
                if (radioButton6.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο σαλόνι ορίστηκε σε: χαμηλή");
                }
                else if (radioButton5.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο σαλόνι ορίστηκε σε: μέτρια");
                }
                else if (radioButton4.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο σαλόνι ορίστηκε σε: υψηλή");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, ορίστε θερμοκρασία!");
                }
            }
            else
            {
                MessageBox.Show("Η θέρμανση στο σαλόνι δεν είναι ενεργοποιημένη!");
            }
        }

        // περισσότερες ρυθμίσεις για το δωμάτιο 'κουζίνα'
        private void label3_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel9.Visible = true;
            pictureBox19.Image = pictureBox4.Image;
            panel9.Location = panel3.Location;
        }

        // επιστροφή στο κύριο μενού διαχείρισης για το δωμάτιο 'κουζίνα'
        private void button20_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel9.Visible = false;
        }

        // διαχείριση θερμοκρασίας στο δωμάτιο 'κουζίνα'
        private void button19_Click(object sender, EventArgs e)
        {
            if (temp_kitchen) // έλεγχος για το εάν η θέρμανση είναι ενεργοποιημένη στην κουζίνα
            {
                if (radioButton9.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στην κουζίνα ορίστηκε σε: χαμηλή");
                }
                else if (radioButton8.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στην κουζίνα ορίστηκε σε: μέτρια");
                }
                else if (radioButton7.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στην κουζίνα ορίστηκε σε: υψηλή");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, ορίστε θερμοκρασία!");
                }
            }
            else
            {
                MessageBox.Show("Η θέρμανση στην κουζίνα δεν είναι ενεργοποιημένη!");
            }
        }

        // περισσότερες ρυθμίσεις για το δωμάτιο 'μπάνιο'
        private void label4_Click(object sender, EventArgs e)
        {
            panel10.Visible = true;
            panel4.Visible = true;
            panel10.Location = panel4.Location;
            pictureBox21.Image = pictureBox3.Image;
        }

        // διαχείριση θερμοκρασίας στο μπάνιο
        private void button22_Click(object sender, EventArgs e)
        {
            if (temp_bathroom) // έλεγχος για το εάν η θέρμανση είναι ενεργοποιημένη στο μπάνιο
            {
                if (radioButton12.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο μπάνιο ορίστηκε σε: χαμηλή");
                }
                else if (radioButton11.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο μπάνιο ορίστηκε σε: μέτρια");
                }
                else if (radioButton10.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο μπάνιο ορίστηκε σε: υψηλή");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, ορίστε θερμοκρασία!");
                }
            }
            else
            {
                MessageBox.Show("Η θέρμανση στο μπάνιο δεν είναι ενεργοποιημένη!");
            }
        }

        // επιστροφή στο κύριο μενού διαχείρισης για το δωμάτιο 'μπάνιο'
        private void button23_Click(object sender, EventArgs e)
        {
            panel10.Visible = false;
            panel4.Visible = true;
        }

        // κουμπί για το άνοιγμα και το κλείσιμο της καφετιέρας
        private void button24_Click(object sender, EventArgs e)
        {
            if (kafetiera == false)
            {
                button24.Text = "Κλείσιμο καφετιέρας";
                MessageBox.Show("Η καφετιέρα ενεργοποιήθηκε.");
                kafetiera = true;
            }
            else
            {
                button24.Text = "Άνοιγμα καφετιέρας";
                MessageBox.Show("Η καφετιέρα απενεργοποιήθηκε.");
                kafetiera = false;
            }
        }

        // κουμπί για αυτοκαθαρισμό της καφετιέρας
        private void button25_Click(object sender, EventArgs e)
        {
            if (kafetiera)
                MessageBox.Show("Η καφετιέρα έχει καθαριστεί με επιτυχία!");
            else
                MessageBox.Show("Η καφετιέρα είναι απενεργοποιημένη!");
        }

        // κουμπί για παρασεκυή καφέ
        private void button26_Click(object sender, EventArgs e)
        {
            if (kafetiera)
                MessageBox.Show("Ο καφές σας είναι έτοιμος, καλή απόλαυση!");
            else
                MessageBox.Show("Η καφετιέρα είναι απενεργοποιημένη!");
        }

        // περισσότερες ρυθμίσεις για το δωμάτιο 'υπνοδωμάτιο'
        private void label5_Click(object sender, EventArgs e)
        {
            panel11.Visible = true;
            panel5.Visible = true;
            panel11.Location = panel5.Location;
            pictureBox26.Image = pictureBox12.Image;
        }

        // επιστροφή στο κεντρικό μενού διαχείρισης του υπνοδωματίου
        private void button28_Click(object sender, EventArgs e)
        {
            panel11.Visible = false;
            panel5.Visible = true;
        }

        // διαχείριση θερμοκρασία στο δωμάτιο 'υπνοδωμάτιο'
        private void button27_Click(object sender, EventArgs e)
        {
            if (temp_bedroom) // έλεγχος για το εάν η θέρμανση είναι ενεργοποιημένη στο υπνοδωμάτιο
            {
                if (radioButton15.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο υπνοδωμάτιο ορίστηκε σε: χαμηλή");
                }
                else if (radioButton14.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο υπνοδωμάτιο ορίστηκε σε: μέτρια");
                }
                else if (radioButton13.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο υπνοδωμάτιο ορίστηκε σε: υψηλή");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, ορίστε θερμοκρασία!");
                }
            }
            else
            {
                MessageBox.Show("Η θέρμανση στο υπνοδωμάτιο δεν είναι ενεργοποιημένη!");
            }
        }

        // περισσότερες ρυμθμίσεις για το δωμάτιο 'γκαραζ'
        private void label6_Click(object sender, EventArgs e)
        {
            pictureBox27.Image = pictureBox14.Image;
            panel6.Visible = true;
            panel12.Visible = true;
            panel12.Location = panel6.Location;
        }

        // επιστροφή στο κύριο μενού διαχείρισης του δωματίου 'γκαράζ'
        private void button30_Click(object sender, EventArgs e)
        {
            panel6.Visible = true;
            panel12.Visible = false;
        }

        // διαχείριση θερμοκρασίας του δωματίου γκαράζ
        private void button29_Click(object sender, EventArgs e)
        {
            if (temp_garage) // έλεγχος για το εάν η θέρμανση είναι ενεργοποιημένη στο γκαράζ
            {
                if (radioButton18.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο γκαράζ ορίστηκε σε: χαμηλή");
                }
                else if (radioButton17.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο γκαράζ ορίστηκε σε: μέτρια");
                }
                else if (radioButton16.Checked == true)
                {
                    MessageBox.Show("Η θερμοκρασία στο γκαράζ ορίστηκε σε: υψηλή");
                }
                else
                {
                    MessageBox.Show("Παρακαλώ, ορίστε θερμοκρασία!");
                }
            }
            else
            {
                MessageBox.Show("Η θέρμανση στο γκαράζ δεν είναι ενεργοποιημένη!");
            }
        }

        // ενέργειες που θα γίνουν αφού κλείσει η φόρμα
        private void Remote_Device_Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            // η φόρμα κρύβεται όταν ο χρήστης πατήσει το X. Με αυτόν τον τρόπο, οι αλλαγές που κάνει στην φόρμα δεν χάνονται άπαξ και την ξαναανοίξει (ενόσω εκτελείται το πρόγραμμα φυσικά)
            this.Hide();
            e.Cancel = true;
        }

        // Η φόρμα πάντα βρίσκεται στη μέση όταν γίνεται resize
        private void Remote_Device_Control_Resize(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }
    }
}
