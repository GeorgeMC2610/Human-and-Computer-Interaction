﻿using System;
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
    // εδώ ορίζονται κάποια μηνύματα που εμφάνίζονται στον χρήστη, προκειμένου να βοηθηθεί και να 
    // χρησιμοποιεί με άνεση τον έξυπνο προσωπικό βοηθό ημέρας.
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }

        // κουμπί βοήθειας "Επιλογή Έλεγχος Συσκευών"
        private void button13_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Πατώντας αυτή την επιλογή από το κύριο μενού θα μεταβείτε στο" +
                " χώρο όπου εσείς ελέγχετε απομακρυσμένα τις συσκευές του σπιτιού σας. Οι " +
                "συσκευές που υποστηρίζονται από τον προσωπικό βοηθό είναι: τα φώτα οροφής σε κάθε δωμάτιο, η θερμοκρασία (καλοριφέρ) κάθε δωματίου," +
                " η καφετιέρα που υπάρχει στην κουζίνα και η  παπουτσοθήκη που υπάρχει στο χωλ.");
        }

        // κουμπί Οnline βοήθεια
        private void button11_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το κουμπί αυτό σας οδηγεί στην οθόνη που βλέπετε μπροστά σας αυτή τη στιγμή. " +
                "Εδώ συλλέγεται όλη η πληροφορία που" +
                " σας καθοδηγεί για την ορθή λειτουργία του έξυπνου προσωπικού βοηθού ημέρας.");
        }

        // κουμπί βοήθειας Εισαγωγή προγράμματος
        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η επιλογή αυτή σας επιτρέπει να εισάγετε στον προσωπικό βοηθό σας το ημερήσιο πρόγραμμά σας. Από εκεί και" +
                " πέρα, η εφαρμογή αναλύει αυτό το πρόγραμμα και σας προτείνει συμβουλές όπως:" +
                " 1) σωστή επιλογή παπουτσιών ανάλογα την περίσταση και 2) οδηγίες για να κατευθυνθείτε" +
                " προς το σημείο που θέλετε να πάτε.");
        }

        // επιλογή "Άνοιγμα και Κλείσιμο φωτισμού οροφής"
        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Το κουμπί 'Άνοιγμα φωτός', το οπόίο δίνεται ως επιλογή για κάθε δωμάτιο του" +
                " σπιτιού σας, σας επιτρέπει να ενεργοποιήσετε και να απενεργοποιήσετε αντίστοιχα τον " +
                "φωτισμό στο εκάστοτε δωμάτιο. Την επιλογή αυτή θα την βρείτε πατώντας από το μενού " +
                "την επιλογή 'Έλεγχος Συσκευών'. Για να καταλάβεται εάν το φως στο δωμάτιο της" +
                " αρεσκείας σας έχει ανάψει/σβήσει, η εικόνα του συγκεκριμένου δωματίου θα φαίνεται" +
                " ανοιχτόχρωμη ή σκουρόχρωμη. Ταυτόχρονα, μία λάμπα θα φαίνεται αναμμένη ή σβησμένη " +
                ", έτσι ώστε να καταλαβαίνεται γρήγορα και εύκολα την κατάσταση φωτισμού του δωματίου.");
        }

        // φροντίδα κατοικιδίου
        private void button12_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Η επιλογή αυτή βρίσκεται στο κύριο μενού του προσωπικού βοηθού." +
                " Πατώντας αυτό το κουμπί, μπορείτε να ελέγξετε κάθε ενέργεια που κάνει το" +
                " κατοικίδιό σας (ακόμα και όταν λείπετε από το σπίτι). Παράλληλα, με την δοθείσα" +
                " επιλογή, μπορείτε να ταϊσετε ή/και να δώσετε νερό στο κατοικίδιό σας."); 
        }
    }
}
