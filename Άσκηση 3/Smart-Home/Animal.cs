using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    abstract class Animal
    {
        //μεταβλητή τυχαιότητας για να προσομοιώσουμε πράγματα όπως πείνα και ύπνο.
        protected static Random random = new Random();

        //καθορίζει το αν κοιμάται ένα ζώο (TRUE = ΚΟΙΜΑΤΑΙ).
        protected bool Asleep { get; set; }

        //Ποσοστά πείνας και δραστηριότητας
        protected int HungerPercentage;
        protected int ThurstPercentage;
        protected int ActivityPercentage;

        //Το όνομα του κατοικιδίου (θα είναι τυχαίο)
        public string Name { get { return name; } }
        protected string name;

        public Animal()
        {
            HungerPercentage   = 0;
            ActivityPercentage = 0;
           
        }

        //Η μέθοδος που θα κάνει ένα ζώο να κοιμάται 
        public void FallAsleep()
        {
            ActivityPercentage = 0;
            Asleep = true;
        }

        //Η μέθοδος που θα «ζωηρεύει» ένα κατοικίδιο
        public void Awaken()
        {
            ActivityPercentage++;
            Asleep = false;
        }

        //Αυτή η μέθοδος θα χρησιμοποιείται σε ρολόι. Κάνει ένα ζώο να πεινάει, ανάλογα με το πόσο δραστήριο είναι
        public void ManageHunger()
        {
            if (ActivityPercentage == 0)
            {
                if (random.Next(0, 2) == 0)
                    HungerPercentage++;
            }
            else if (ActivityPercentage == 1)
            {
                if (random.Next(0, 6) <= 3)
                    HungerPercentage++;
            }
            else
                HungerPercentage++;
        }
    }
}
