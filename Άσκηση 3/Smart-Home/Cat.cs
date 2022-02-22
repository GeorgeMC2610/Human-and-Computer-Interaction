using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    public class Cat : Animal
    {
        //Τυχαία ονόματα γάτας.
        private static string[] Names = { "Jack", "Loki", "Jasper", "Garfield", "Simba", "Soozie", "Ellie", "Raymond", "Lucy", "Kitty"};

        //Όπως και στον σκύλο, έτσι και στην γάτα το όνομα είναι τυχαίο.
        public Cat() : base()
        {
            name = Names[random.Next(0, Names.Length)];
        }

        /// <summary>
        /// Κάνει μια γάτα να πάρει ποσοστό δραστηριότητας. Σε σχέση με έναν σκύλο, η γάτα παίρνει λιγότερο ποσοστό δραστηριότητας.
        /// <br></br>
        /// <br></br>
        /// <b>ΑΝΑΛΥΤΙΚΑ ΟΙ ΠΙΘΑΝΟΤΗΤΕΣ:</b>
        /// <list type="bullet">
        ///     <item>Με πείνα ή δίψα μεγαλύτερη του 70%, υπάρχει 80% πιθανότητα να ανακτηθεί 1% δραστηριότητα και 20% να μείνει η ίδια.</item>
        ///     <item>Με πείνα ή δίψα λιγότερη του 70%, υπάρχει 50% πιθανότητα να ανακτηθεί 1% δραστηριότητα και 50% μείνει η ίδια.</item>
        /// </list>
        /// </summary>
        public override void Awaken()
        {
            if (HungerPercentage > 70 || ThirstPercentage > 70)
            {
                if (random.Next(0, 10) < 8)
                    ActivityPercentage++;
            }
            else if (random.Next(0, 2) == 0)
                ActivityPercentage++;

            base.Awaken();
        }

        /// <summary>
        /// Κάνει μια γάτα να χάσει ποσοστό δραστηριότητας. Σε σχέση με έναν σκύλο, η γάτα χάνει περισσότερη δραστηριότητα.
        /// <br></br>
        /// <br></br>
        /// <b>ΑΝΑΛΥΤΙΚΑ ΟΙ ΠΙΘΑΝΟΤΗΤΕΣ:</b>
        /// <list type="bullet">
        ///     <item>Με πείνα ή δίψα λιγότερη του 70%, υπάρχει 50% πιθανότητα να χαθεί 1% δραστηριότητα και 50% πιθανότητα να χαθεί 2%.</item>
        ///     <item>Με πείνα ή δίψα μεγαλύτερη του 70%, υπάρχει 80% πιθανότητα να χαθεί 10% δραστηριότητα και 20% να μείνει η ίδια.</item>
        /// </list>
        /// </summary>
        public override void Calm()
        {
            if (HungerPercentage > 70 || ThirstPercentage > 70)
                ActivityPercentage = (random.Next(0, 10) < 8) ? ActivityPercentage - 10 : ActivityPercentage;
            else
                ActivityPercentage = (random.Next(0, 2) == 0) ? ActivityPercentage - 1 : ActivityPercentage - 2;

            base.Calm();
        }

        /// <summary>
        /// Η γάτα τρώει κανονικά το φαγητό της με κανονικό ρυθμό.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε φαγητό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, επιστρέφεται ώστε να αποθηκεύονται οι αλλαγές.</returns>

        public override void ManageNeeds()
        {
            if (ActivityPercentage < 15)
            {
                ThirstPercentage += 1;
                HungerPercentage += 2;
            }
            else if (ActivityPercentage < 40)
            {
                ThirstPercentage += 5;
                HungerPercentage += 7;
            }
            else if (ActivityPercentage < 70)
            {
                ThirstPercentage += 14;
                HungerPercentage += 15;
            }
            else
            {
                ThirstPercentage += 22;
                HungerPercentage += 26;
            }

            base.ManageNeeds();
        }

        /// <summary>
        /// Η γάτα πίνει κανονικά νερό.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε φαγητό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, επιστρέφεται ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Drink(Bowl bowl)
        {
            if (bowl.Capacity == 0)
            {
                Console.WriteLine("Bowl is empty!");
                return bowl;
            }

            ThirstPercentage--;
            bowl.Capacity--;
    
            return base.Drink(bowl);
        }

        public override Bowl Eat(Bowl bowl)
        {
            if (bowl.Capacity == 0)
            {
                Console.WriteLine("Bowl is empty!");
                return bowl;
            }

            HungerPercentage--;
            bowl.Capacity--;

            return base.Eat(bowl);
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Type: Cat";
        }
    }
}
