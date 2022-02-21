using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    public abstract class Animal
    {
        //μεταβλητή τυχαιότητας για να προσομοιώσουμε πράγματα όπως πείνα και ύπνο.
        protected static Random random = new Random();

        //καθορίζει το αν κοιμάται ένα ζώο (TRUE = ΚΟΙΜΑΤΑΙ).
        protected bool isAsleep { get; set; }
        protected bool isEating { get; set; }

        //Ποσοστά πείνας και δραστηριότητας
        protected int HungerPercentage;
        protected int ThirstPercentage;
        protected int ActivityPercentage;

        //Το όνομα του κατοικιδίου (θα είναι τυχαίο)
        public string Name { get { return name; } }
        protected string name;

        public Animal()
        {
            HungerPercentage = 0;
            ThirstPercentage = 0;
            ActivityPercentage = 30;

        }

        //Η μέθοδος που θα κάνει ένα ζώο να κοιμάται 
        public virtual void FallAsleep()
        {
            ActivityPercentage = 0;
            isAsleep = true;
        }

        //Η μέθοδος που θα «ζωηρεύει» ένα κατοικίδιο
        public virtual void Awaken()
        {
            isAsleep = false;
            ActivityPercentage = (ActivityPercentage >= 100) ? 100 : ActivityPercentage; 
        }


        //Αυτή η μέθοδος θα χρησιμοποιείται σε ρολόι. Κάνει ένα ζώο να πεινάει, ανάλογα με το πόσο δραστήριο είναι
        public virtual void ManageNeeds()
        {
            ThirstPercentage = (ThirstPercentage > 100) ? 100 : ThirstPercentage;
            HungerPercentage = (HungerPercentage > 100) ? 100 : ThirstPercentage;
        }

        public virtual void Calm()
        {
            ActivityPercentage = (ActivityPercentage <= 0) ? 0 : ActivityPercentage;

            if (ActivityPercentage <= 0)
            {
                FallAsleep();
                return;
            }
        }

        public void Debug()
        {
            Console.WriteLine(Name + " is " + ActivityPercentage.ToString() + "% active, " + HungerPercentage.ToString() + "% hungry and " + ThirstPercentage.ToString() + "% thirsty.");
        }

        public abstract Bowl Eat(Bowl bowl);
        public abstract Bowl Drink(Bowl bowl);
    }
}
