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
    public partial class TimeSchedule : Form
    {   
        // η λίστα αυτή εμπεριέχει παπούτσια που υπάρχουν μέσα στην παπουτσοθήκη (επιλέγονται κάθε φορά τυχαία)
        List<String> shoes = new List<string>();

        // λίστα που εμπεριέχει το πρόγραμμα του χρήστη (15 εγγραφές)
        List<string> schedule = new List<string>();

        // λίστα με τα παπούτσια που αναγκαστικά πρέπει να έχει ο χρήστης
        // αν ένα ζευγάρι παπουτσιών που είναι απαραίτητο (π.χ αθλητικά για γυμναστική)
        // τότε ο αυτόματος βοηθός προτείνει από e-shop την αγορά κατάλληλου ζευγαριού παπουτσιών
        List<string> required_shoes = new List<string>();

        string current_shoe;

        public TimeSchedule()
        {
            InitializeComponent();
            this.Width = 905;
        }

        // ο χρήστης πατώντας αυτό το κουμπί, μπορεί να δει τα διαθέσιμα παπούτσια που βρίσκονται
        // στην παπουτσοθήκη αυτή τη στιγμή
        private void button20_Click(object sender, EventArgs e)
        {
            if (shoes.Count() == 0)
            {
                MessageBox.Show("Η παπουτσοθήκη σας είναι άδεια αυτή τη στιγμή.");
            }
            else
            {
                // μετρητές παπουτσιών ανά είδος
                int count_mokasinia = 0;
                int count_sneakers = 0;
                int count_athlitika = 0;
                int count_skarpinia = 0;
                int count_padofles = 0;

                for (int i = 0; i < shoes.Count(); i++)
                {
                    if (shoes[i].Equals("Αθλητικά"))
                    {
                        count_athlitika += 1;
                    }
                    else if (shoes[i].Equals("Μοκασίνια"))
                    {
                        count_mokasinia += 1;
                    }
                    else if (shoes[i].Equals("Sneakers"))
                    {
                        count_sneakers += 1;
                    }
                    else if (shoes[i].Equals("Παντόφλες"))
                    {
                        count_padofles += 1;
                    }
                    else if (shoes[i].Equals("Σκαρπίνια"))
                    {
                        count_skarpinia += 1;
                    }
                }

                // εμφάνιση μηνύματος προς τον χρήστη
                MessageBox.Show("H παπουτσοθήκη σας περιέχει τα ακόλουθα ζευγάρια παπουτσιών: " +
                    "Sneakers --> " + count_sneakers.ToString() + " , " + "Μοκασίνια --> " + count_mokasinia.ToString() +
                    " , " + "Σκαρπίνια --> " + count_skarpinia.ToString() + " , " + "Παντόφλες --> " +
                    count_padofles.ToString() + " , " + "Αθλητικά --> " + count_athlitika.ToString() + ".");
            }
        }

        // ενέργειες που γίνονται όταν ο χρήστης πατάει το κουμπί Χ (κλείσιμο φόρμας)
        private void TimeSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            // η φόρμα κρύβεται όταν ο χρήστης πατήσει το X. Με αυτόν τον τρόπο, οι αλλαγές που κάνει στην φόρμα δεν χάνονται άπαξ και την ξαναανοίξει (ενόσω εκτελείται το πρόγραμμα φυσικά)
            this.Hide();
            e.Cancel = true;
        }

        // κουμπί "Αποθήκευση Προγράμματος" ημέρας χρήστη
        private void button1_Click(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button1.BackColor = Color.Gray;
            button1.ForeColor = Color.Black;
            button4.Enabled = true;
            button4.BackColor = Color.Maroon;
            button4.ForeColor = Color.White;

            // προσθήκη γεγονότων όλων των comboboxes σε μία λίστα
            for (int i = 1; i <= 15; i++)
            {
                var my_comboBox = panel3.Controls["comboBox" + i.ToString()];

                if (my_comboBox.Text == "Τί θα κάνετε αυτή την ώρα;")
                {
                    continue;
                }
                else
                {
                    schedule.Add(my_comboBox.Text);
                }   
            }

            shoe_analysis(); // γίνεται ανάληση του προγράμματος ημέρας
        }

        // αγορά παπουτσιού
        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να αγοράσετε αυτό ο ζευγάρι παπουτσιών;", "Αγορά Παπουτσιών", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            MessageBox.Show("Αγοράσατε καινούριο ζευγάρι παπουτσιών!");
            
            if (current_shoe.Equals("Μοκασίνια"))
            {
                button3.Visible = false;
                label25.Visible = false;
                panel1.Visible = false;
                panel2.Visible = true;
                shoes.Add(current_shoe);
            }
            else if (current_shoe.Equals("Παντόφλες"))
            {
                button5.Visible = false;
                label29.Visible = false;
                panel2.Visible = true;
                panel1.Visible = false;
                shoes.Add(current_shoe);
            }
            else if (current_shoe.Equals("Sneakers"))
            {
                button8.Visible = false;
                label31.Visible = false;
                panel2.Visible = true;
                panel1.Visible = false;
                shoes.Add(current_shoe);
            }
            else if (current_shoe.Equals("Αθλητικά"))
            {
                button6.Visible = false;
                label28.Visible = false;
                panel2.Visible = true;
                panel1.Visible = false;
                shoes.Add(current_shoe);
            }
            else if (current_shoe.Equals("Σκαρπίνια"))
            {
                button7.Visible = false;
                label30.Visible = false;
                panel2.Visible = true;
                panel1.Visible = false;
                shoes.Add(current_shoe);
            }

            check_finish();
        }

        // η μέθοδος αυτή αναλύει το πρόγραμμα του χρήστη και ελέγχει εάν έχει (ή όχι) στην 
        // κατοχή του τα απαραίτητα ζευγάρια παπουτσιών. Αν όχι, η εφαρμογή προτεινει από 
        // e-shop κατάλληλα παπούτσια
        private void shoe_analysis()
        {
            for (int k = 0; k < schedule.Count(); k++)
            {
                // βρίσκουμε τα απαραίτητα παπούτσια που χρειάζονται ανάλογα το πρόγραμμα ημέρας
                if (schedule[k].Equals("Αθλήματα") || schedule[k].Equals("Περπάτημα") || schedule[k].Equals("Γυμναστική") || schedule[k].Equals("Τρέξιμο"))
                {
                    required_shoes.Add("Αθλητικά");
                }
                else if (schedule[k].Equals("Βόλτα") || schedule[k].Equals("Ψώνια") || schedule[k].Equals("Διάβασμα"))
                {
                    required_shoes.Add("Sneakers");
                }
                else if (schedule[k].Equals("Δουλειά"))
                {
                    required_shoes.Add("Μοκασίνια");
                }
                else if (schedule[k].Equals("Συνέντευξη"))
                {
                    required_shoes.Add("Σκαρπίνια");
                }
                else if (schedule[k].Equals("Μαγείρεμα") || schedule[k].Equals("Χαλάρωση στο σπίτι"))
                {
                    required_shoes.Add("Παντόφλες");
                }
            }
            
            MessageBox.Show("Έγινε αποθήκευση του προγράμματός σας!");

            button3.Visible = false;
            label25.Visible = false;
            button6.Visible = false;
            label28.Visible = false;
            button8.Visible = false;
            label31.Visible = false;
            button5.Visible = false;
            label29.Visible = false;
            button7.Visible = false;
            label30.Visible = false;
            label32.Visible = true;
            panel2.Visible = true;

            // συγκρίνουμε την λίστα με τα απαραίτητα παπούτσια (required_shoes) με την λίστα shoes (παπούτσια
            // που ο χρήστης έχει ήδη στην κατοχή του).

            foreach (string item in required_shoes)
            {
                if (!shoes.Contains(item))
                {
                    if (item.Equals("Μοκασίνια"))
                    {
                        button3.Visible = true;
                        label25.Visible = true;
                    }
                    else if (item.Equals("Αθλητικά"))
                    {
                        button6.Visible = true;
                        label28.Visible = true;
                    }
                    else if (item.Equals("Παντόφλες"))
                    {
                        button5.Visible = true;
                        label29.Visible = true;
                    }
                    else if (item.Equals("Σκαρπίνια"))
                    {
                        button7.Visible = true;
                        label30.Visible = true;
                    }
                    else if (item.Equals("Sneakers"))
                    {
                        button8.Visible = true;
                        label31.Visible = true;
                    }   
                }
            }

            check_finish();
        }

        // διαγραφή προγράμματος ημέρας
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Είστε σίγουρος ότι θέλετε να διαγράψετε το πρόγραμμά σας;", "Διαγραφή Προγράμματος", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;

            this.Width = 905;
            label36.Visible = false;
            label33.Visible = false;
            panel5.Visible = false;
            button10.Enabled = true;
            button10.BackColor = Color.Orange;
            button10.ForeColor = Color.White;

            button1.Enabled = true;
            button1.BackColor = Color.Green;
            button1.ForeColor = Color.White;
            button4.Enabled = false;
            button4.BackColor = Color.Gray;
            button4.ForeColor = Color.Black;

            label32.Visible = false;
            panel2.Visible = false;
            panel1.Visible = false;

            // καθαρισμός όλων των λιστών
            required_shoes.Clear();
            schedule.Clear();

            // επαναφορά των τιμών όλων των comboboxes
            for (int i = 1; i <= 15; i++)
            {
                var my_comboBox = panel3.Controls["comboBox" + i.ToString()];

                my_comboBox.Text = "Τί θα κάνετε αυτή την ώρα;";
            }

            MessageBox.Show("Το πρόγραμμα ημέρας σας διαγράφηκε με επιτυχία!");
        }

        // αγορά μοκασινιών
        private void button3_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            label23.Text = "μοκασίνια";
            pictureBox1.Image = Properties.Resources.mokasinia1;
            current_shoe = "Μοκασίνια";
        }

        // κουμπί "κλείσιμο eshop"
        private void button9_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = true;
        }

        // αγορά ζευγαριού με παντόφλες
        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = false;
            panel1.Visible = true;
            label23.Text = "με παντόφλες";
            pictureBox1.Image = Properties.Resources.padofles;
            current_shoe = "Παντόφλες";
        }

        // αγορά ζευγαρού με αθλητικά
        private void button6_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            label23.Text = "αθλητικών παπουτσιών";
            pictureBox1.Image = Properties.Resources.athlitika1;
            current_shoe = "Αθλητικά";
        }

        // αγορά ζευγαριού με σκαρπίνια
        private void button7_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            label23.Text = "σκαρπίνια";
            pictureBox1.Image = Properties.Resources.skarpinia1;
            current_shoe = "Σκαρπίνια";
        }

        // αγορά sneakers
        private void button8_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            label23.Text = "sneakers";
            pictureBox1.Image = Properties.Resources.sneakers1;
            current_shoe = "Sneakers";
        }

        // έλεγχος για το εάν ο χρήστης ΔΕΝ χρειάζεται άλλα παπούτσια να αγοράσει
        private void check_finish()
        {
            if (button3.Visible == false && button8.Visible == false && button7.Visible == false && button5.Visible == false && button6.Visible == false)
            {
                panel2.Visible = false;
                label32.Visible = false;
                MessageBox.Show("Με βάση το πρόγραμμά σας, δεν χρειάζεται να αγοράσετε νέα παπούτσια!");
            }
        }

        // κουμπί για γεωγραφικές οδηγίες
        private void button10_Click(object sender, EventArgs e)
        {
           
            // αρχικά ψάχνουμε ποιες δραστηριότητες εκτός σπιτιού έχει στο πρόγραμμά του ο χρήστης (8 στο σύνολο δραστηριότητες)
            bool bolta = false;
            bool gimnastiki = false;
            bool douleia = false;
            bool sinedeuxi = false;
            bool perpatima = false;
            bool athlimata = false;
            bool treximo = false;
            bool psonia = false;

            foreach (string item in schedule)
            {
                if (item.Equals("Βόλτα"))
                {
                    bolta = true;
                }
                else if (item.Equals("Γυμναστική"))
                {
                    gimnastiki = true;
                }
                else if (item.Equals("Δουλειά"))
                {
                    douleia = true;
                }
                else if (item.Equals("Περπάτημα"))
                {
                    perpatima = true;
                }
                else if (item.Equals("Συνέντευξη"))
                {
                    sinedeuxi = true;
                }
                else if (item.Equals("Τρέξιμο"))
                {
                    treximo = true;
                }
                else if (item.Equals("Ψώνια"))
                {
                    psonia = true;
                }
                else if (item.Equals("Αθλήματα"))
                {
                    athlimata = true;
                }
            }

            // εάν ο χρήστης έχει δραστηριότητες εκτός σπιτιού, εμφανίζεται ο χώρος στην φόρμα για
            // οδηγίες τοποθεσίας

            if (athlimata || treximo || sinedeuxi || perpatima || psonia || douleia || gimnastiki || bolta)
            {
                button21.Enabled = true;
                pictureBox2.Visible = true;
                pictureBox2.Image = Properties.Resources.google_maps;
                this.Width = 1188;
                label33.Visible = true;
                label36.Visible = false;
                panel5.Visible = true;
                button10.Enabled = false;
                button10.BackColor = Color.Gray;
                button10.ForeColor = Color.Black;
            }
            else
            {
                button21.Enabled = false;
                MessageBox.Show("Δεν έχετε δραστηριότητες εκτός σπιτιού στο πρόγραμμα ημέρας σας!");
                button10.Enabled = true;
                button10.BackColor = Color.Orange;
                button10.ForeColor = Color.White;
            }

            // στο σημείο που δίνεται η επεξήγηση τοποθεσίας, εμφανίζονται κατάλληλες επιλογές
            // οι επιλογές πρέπει να συμφωνούν με το πρόγραμμα του χρήστη. Δεν εμφανίζονται επιλογές
            // τοποθεσίας για δραστηριότητες που δεν συμπεριλαμβάνονται στο πρόγραμμα του χρήστη.

            //τι έχεις κάνει γτθς

            button11.Visible = bolta;
            button12.Visible = athlimata;
            button13.Visible = douleia;
            button14.Visible = treximo;
            button15.Visible = perpatima;
            button16.Visible = psonia;
            button17.Visible = gimnastiki;
            button18.Visible = sinedeuxi;
            
        }

        // επιλογή για άνοιγμα τοποθεσίας στο Google Maps
        private void label34_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το Google Maps είναι έτοιμο προς χρήση!");
        }

        // κουμπί κλείσιμο
        private void button19_Click(object sender, EventArgs e)
        {
            this.Width = 905;
            pictureBox2.Image = Properties.Resources.google_maps;
            label33.Visible = false;
            panel5.Visible = false;
            button10.Enabled = true;
            button10.BackColor = Color.Orange;
            button10.ForeColor = Color.White;
        }

        // οδηγίες για "Βόλτα"
        private void button11_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για βόλτα";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.bolta_odigies;
            label34.Visible = true;
        }

        // οδηγίες για "Γυμναστική"
        private void button17_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για γυμναστική";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.gimnastiki_odigies;
            label34.Visible = true;
        }

        // οδηγίες για "Δουλειά"
        private void button13_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για δουλειά";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.odigies_douleia;
            label34.Visible = true;
        }

        // οδηγίες για "Περπάτημα"
        private void button15_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για περπάτημα";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.perpatima_odigies;
            label34.Visible = true;
        }

        // οδηγίες για "Τρέξιμο"
        private void button14_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για τρέξιμο";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.treximo_odigies;
            label34.Visible = true;
        }

        // οδηγίες για "Συνέντευξη"
        private void button18_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για συνέντευξη";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.sinedeuxi_odigies;
            label34.Visible = true;
        }

        // οδηγίες για "Αθλήματα"
        private void button12_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για αθλήματα";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.odigies_athlimata;
            label34.Visible = true;
        }

        // οδηγίες για "Ψώνια"
        private void button16_Click(object sender, EventArgs e)
        {
            label36.Visible = true;
            label36.Text = "Οδηγίες για ψώνια";
            pictureBox2.Visible = true;
            pictureBox2.Image = Properties.Resources.odigies_psonia;
            label34.Visible = true;
        }

        // κουμπί για παραγγελία καφέ
        private void button21_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Έχει γίνει παραγγελία του καφέ σας! Περάστε να τον πάρετε σε 10 λεπτά.");
            button21.Enabled = false;
        }

        // Η φόρμα πάντα βρίσκεται στη μέση όταν γίνεται resize
        private void TimeSchedule_Resize(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }
    }
}
