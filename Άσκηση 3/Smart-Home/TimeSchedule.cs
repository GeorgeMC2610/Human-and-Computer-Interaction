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

        // παπούτσια που μπορεί να έχει ένας άνδρας και μία γυναίκα (δύο ξεχωριστοί πίνακες)
        string[] shoes_gen = {"Αθλητικά", "Μοκασίνια", "Sneakers", "Παντόφλες", "Σκαρπίνια"};
        
        // η λίστα αυτή εμπεριέχει παπούτσια που υπάρχουν μέσα στην παπουτσοθήκη (επιλέγονται κάθε φορά τυχαία)
        List<String> shoes = new List<string>();

        // λίστα που εμπεριέχει το πρόγραμμα του χρήστη (15 εγγραφές)
        List<string> schedule = new List<string>();

        // λίστα με τα παπούτσια που αναγκαστικά πρέπει να έχει ο χρήστης
        // αν ένα ζευγάρι παπουτσιών που είναι απαραίτητο (π.χ αθλητικά για γυμναστική)
        // τότε ο αυτόματος βοηθός προτείνει από e-shop την αγορά κατάλληλου ζευγαριού παπουτσιών
        List<string> required_shoes = new List<string>();

        bool T = true; // διακόπτης

        string current_shoe;

        public TimeSchedule()
        {
            InitializeComponent();

            if (T)
            {
                // προσθήκη τυχαίων παπουτσιών στη λίστα shoes (γίνεταί μία φορά, ενόσω εκτελείται το πρόγραμμα)

                Random rnd = new Random(); // τυχαία επιλογή επαναλήψεων for loop
                Random random_shoe = new Random(); // τυχαία επιλογή παπουτσιού από τον πίνακα shoes_gen (επιτρέπονται και διπλότυπα)

                int j = rnd.Next(5);
                for (int i = 0; i < j; i++)
                {
                    shoes.Add(shoes_gen[random_shoe.Next(5)]);
                }

                T = false;
            }
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
                    if (shoes[i].Equals("Aθλητικά"))
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
            button4.Enabled = true;

            // προσθήκη γεγονότων όλων των comboboxes σε μία λίστα
            for (int i = 1; i < 15; i++)
            {
                var my_comboBox = this.Controls["comboBox" + i.ToString()];

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
            MessageBox.Show("Αγοράσατε καινούριο ζευγάρι παπουτσιών");
            
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
            
            for (int i = 0; i < required_shoes.Count(); i++)
            {
                MessageBox.Show(required_shoes[i]);
            }
            MessageBox.Show("Έγινε αποθήκευση του προγράμματός σας!");

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

            if (button3.Visible == false && button8.Visible == false && button7.Visible == false && button5.Visible == false && button6.Visible == false)
            {
                MessageBox.Show("Με βάση το πρόγραμμά σας, δεν χρειάζεται να αγοράσετε νέα παπούτσια!");
                panel2.Visible = false;
            }
            
        }

        private void agora_papoutsiou(string item)
        {
            if (item.Equals("Αθλητικά")) // αγορά αθλητικών παπουτσιών
            {
                panel1.Visible = true;
                label23.Text = "αθλητικών παπουτσιών";
                pictureBox1.Image = Properties.Resources.athlitika1;
                shoes.Add("Αθλητικά");
            }
            else if (item.Equals("Μοκασίνια")) // αγορά μοκασινιών
            {
                panel1.Visible = true;
                label23.Text = "μοκασίνια";
                pictureBox1.Image = Properties.Resources.mokasinia1;
                shoes.Add("Μοκασίνια");
            }
            else if (item.Equals("Sneakers")) // αγορά sneakers
            {
                panel1.Visible = true;
                label23.Text = "sneakers";
                pictureBox1.Image = Properties.Resources.sneakers1;
                shoes.Add("Sneakers");
            }
            else if (item.Equals("Sneakers")) // αγορά sneakers
            {
                panel1.Visible = true;
                label23.Text = "sneakers";
                pictureBox1.Image = Properties.Resources.sneakers1;
                shoes.Add("Sneakers");
            }
            else if (item.Equals("Παντόφλες")) // αγορά παντόφλας
            {
                panel1.Visible = true;
                label23.Text = "με παντόφλες";
                pictureBox1.Image = Properties.Resources.padofles;
                shoes.Add("Παντόφλες");
            }
            else if (item.Equals("Σκαρπίνια")) // αγορά σκαρπι΄νιών
            {
                panel1.Visible = true;
                label23.Text = "σκαρπίνια";
                pictureBox1.Image = Properties.Resources.skarpinia1;
                shoes.Add("Σκαρπίνια");
            }
        }

        // διαγραφή προγράμματος ημέρας
        private void button4_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button4.Enabled = false;

            // καθαρισμός όλων των λιστών
            required_shoes.Clear();
            schedule.Clear();

            // επαναφορά των τιμών όλων των comboboxes
            for (int i = 1; i < 15; i++)
            {
                var my_comboBox = this.Controls["comboBox" + i.ToString()];

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
    }
}
