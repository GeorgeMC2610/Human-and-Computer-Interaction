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
        string[] shoes_gen = {"Αθλητικά", "Μοκασίνια", "Sneakers", "Παπούτσια ποδοσφαίρου", "Σκαρπίνια"};
        
        // η λίστα αυτή εμπεριέχει παπούτσια που υπάρχουν μέσα στην παπουτσοθήκη (επιλέγονται κάθε φορά τυχαία)
        List<String> shoes = new List<string>();

        bool T = true; // διακόπτης

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
                int count_football = 0;

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
                    else if (shoes[i].Equals("Παπούτσια ποδοσφαίρου"))
                    {
                        count_football += 1;
                    }
                    else if (shoes[i].Equals("Σκαρπίνια"))
                    {
                        count_skarpinia += 1;
                    }
                }

                // εμφάνιση μηνύματος προς τον χρήστη
                MessageBox.Show("H παπουτσοθήκη σας περιέχει τα ακόλουθα ζευγάρια παπουτσιών: " +
                    "Sneakers --> " + count_sneakers.ToString() + " , " + "Μοκασίνια --> " + count_mokasinia.ToString() +
                    " , " + "Σκαρπίνια --> " + count_skarpinia.ToString() + " , " + "Παπούτσια Ποδοσφαίρου --> " +
                    count_football.ToString() + " , " + "Αθλητικά --> " + count_athlitika.ToString() + ".");
            }
        }

        // ενέργειες που γίνονται όταν ο χρήστης πατάει το κουμπί Χ (κλείσιμο φόρμας)
        private void TimeSchedule_FormClosing(object sender, FormClosingEventArgs e)
        {
            // η φόρμα κρύβεται όταν ο χρήστης πατήσει το X. Με αυτόν τον τρόπο, οι αλλαγές που κάνει στην φόρμα δεν χάνονται άπαξ και την ξαναανοίξει (ενόσω εκτελείται το πρόγραμμα φυσικά)
            this.Hide();
            e.Cancel = true;
        }
    }
}
