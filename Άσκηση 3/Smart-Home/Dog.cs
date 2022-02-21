using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    class Dog : Animal
    {
        //Ο σκύλος και η γάτα θα έχουν ορισμένα ονόματα, τα οποία θα επιλέγουμε τυχαία.
        private static string[] Names = { "Charlie", "Bella", "Max", "Buddy", "Luna", "Coco", "Ruby", "Milo", "Archie" };

        //To base() σημαίνει ότι καλούμε και τον constructor της Animal.
        public Dog() : base()
        {
            name = Names[random.Next(0, Names.Length)];
        }

        /// <summary>
        /// Ο σκύλος, έχει περισσότερες πιθανότητες να κάνει ζημιά σε σχέση με μία γάτα. Οπότε, ο σκύλος έχει 50% πιθανότητα να του ανέβει η δραστηριότητα κάτα 2 μονάδες και 50% να του ανεβεί κατά μία μονάδα.
        /// </summary>
        public override void Awaken()
        {
            isAsleep = false;
            if (random.Next(0, 2) == 0)
                ActivityPercentage += 2;
            else
                ActivityPercentage++;
        }

        /// <summary>
        /// Ο σκύλος μπορεί να τρώει παραπάνω από τη γάτα, και χορταίνει πιο δύσκολα.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε φαγητό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, επιστρέφεται ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Eat(Bowl bowl)
        {
            if (!bowl.Containing.Equals("food"))
                throw new Exception("Eat() method can only be called on Bowls containing food");
            else
            {
                bowl.Capacity -= 2;
                HungerPercentage--;
            }

            return bowl;
        }

        /// <summary>
        /// Συγκριτικά με τη γάτα, ο σκύλος πίνει πιο πολύ νερό και χορταίνει πιο δύσκολα.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε νερό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, επιστρέφεται ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Drink(Bowl bowl)
        {
            if (!bowl.Containing.Equals("water"))
                throw new Exception("Drink() method can only be called on Bowls containing water");
            else
            {
                bowl.Capacity -= 2;
                ThirstPercentage--;
            }

            return bowl;
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
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Type: Dog";
        }
    }
}
