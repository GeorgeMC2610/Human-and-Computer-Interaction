using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    public class Dog : Animal
    {
        //Ο σκύλος και η γάτα θα έχουν ορισμένα ονόματα, τα οποία θα επιλέγουμε τυχαία.
        private static string[] Names = { "Charlie", "Bella", "Max", "Buddy", "Luna", "Coco", "Ruby", "Milo", "Archie" };

        //To base() σημαίνει ότι καλούμε και τον constructor της Animal.
        public Dog() : base()
        {
            name = Names[random.Next(0, Names.Length)];
        }

        /// <summary>
        /// Κάνει έναν σκύλο να πάρει ποσοστό δραστηριότητας. Σε σχέση με μία γάτα, ο σκύλος ανακτά πιο πολλή δραστηριότητα.
        /// <br></br>
        /// <br></br>
        /// <b>ΑΝΑΛΥΤΙΚΑ ΟΙ ΠΙΘΑΝΟΤΗΤΕΣ:</b>
        /// <list type="bullet">
        ///     <item><b>Με πείνα ή δίψα λιγότερη του 70%</b>, υπάρχει 50% πιθανότητα να ανακτηθεί 1% δραστηριότητα και 50% πιθανότητα να δραστηριότητα 2%.</item>
        ///     <item><b>Με πείνα ή δίψα μεγαλύτερη του 70%</b>, υπάρχει 70% πιθανότητα να ανακτηθεί 1% δραστηριότητα και 30% να μείνει η ίδια.</item>
        /// </list>
        /// </summary>
        public override void Awaken()
        {
            if (HungerPercentage > 70 || ThirstPercentage > 70)
                ActivityPercentage = (random.Next(0, 10) < 3) ? ActivityPercentage + 1 : ActivityPercentage;
            else
                ActivityPercentage = (random.Next(0, 2) == 0) ? ActivityPercentage + 2 : ActivityPercentage + 1;

            base.Awaken();
        }

        /// <summary>
        /// Κάνει έναν σκύλο να χάσει ποσοστό δραστηριότητας. Σε σχέση με μία γάτα, ο σκύλος χάνει λιγότερη δραστηριότητα.
        /// <br></br>
        /// <br></br>
        /// <b>ΑΝΑΛΥΤΙΚΑ ΟΙ ΠΙΘΑΝΟΤΗΤΕΣ:</b>
        /// <list type="bullet">
        ///     <item><b>Με πείνα ή δίψα λιγότερη του 70%</b>, χάνεται 1% δραστηριότητας.</item>
        ///     <item><b>Με πείνα ή δίψα μεγαλύτερη του 70%</b>, υπάρχει 70% πιθανότητα να ανακτηθεί 8% δραστηριότητα και 30% να μείνει η ίδια.</item>
        /// </list>
        /// </summary>
        public override void Calm()
        {
            if (HungerPercentage > 70 || ThirstPercentage > 70)
                ActivityPercentage = (random.Next(0, 10) > 3) ? ActivityPercentage - 8 : ActivityPercentage;
            else
                ActivityPercentage--;

            base.Calm();
        }

        /// <summary>
        /// Μέθοδος στην οποία ο σκύλος πίνει νερό. Για κάθε μονάδα που αφαιρείται στο μπωλ, ο σκύλος αναπληρώνει 5% της δίψας του.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε νερό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Drink(Bowl bowl)
        {
            if (bowl.Capacity == 0)
            {
                Console.WriteLine("Bowl is empty!");
                return bowl;
            }

            ThirstPercentage -= 5;
            bowl.Capacity--;

            return base.Drink(bowl);
        }

        /// <summary>
        /// Μέθοδος στην οποία ο σκύλος τρώει. Για κάθε μονάδα που αφαιρείται στο μπωλ, ο σκύλος αναπληρώνει 4% της πείνας του.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε φαγητό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Eat(Bowl bowl)
        {
            if (bowl.Capacity == 0)
            {
                Console.WriteLine("Bowl is empty!");
                return bowl;
            }

            HungerPercentage -= 4;
            bowl.Capacity--;

            return base.Eat(bowl);
        }

        public override void ManageNeeds()
        {
            if (ActivityPercentage < 15)
            {
                ThirstPercentage += 2;
                HungerPercentage += 3;
            }
            else if (ActivityPercentage < 40)
            {
                ThirstPercentage += 10;
                HungerPercentage += 13;
            }
            else if (ActivityPercentage < 70)
            {
                ThirstPercentage += 26;
                HungerPercentage += 30;
            }
            else
            {
                ThirstPercentage += 40;
                HungerPercentage += 44;
            }

            base.ManageNeeds();
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Type: Dog";
        }
    }
}
