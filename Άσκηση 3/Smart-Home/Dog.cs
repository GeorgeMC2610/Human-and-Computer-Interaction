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
            Asleep = false;
            if (random.Next(0, 2) == 0)
                ActivityPercentage += 2;
            else
                ActivityPercentage++;
        }
    }
}
