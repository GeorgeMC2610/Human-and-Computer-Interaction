using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    class Cat : Animal
    {
        //Τυχαία ονόματα γάτας.
        private static string[] Names = { "Jack", "Loki", "Jasper", "Garfield", "Simba", "Soozie", "Ellie", "Raymond", "Lucy", "Kitty"};

        //Όπως και στον σκύλο, έτσι και στην γάτα το όνομα είναι τυχαίο.
        public Cat() : base()
        {
            name = Names[random.Next(0, Names.Length)];
        }
        
        /// <summary>
        /// Μία γάτα είναι λιγότερο πιθανό να κάνει ζημιά από έναν σκύλο. Οπότε, κάθε φορά που καλείται η μέθοδος, υπάρχει 50% πιθανότητα να ανεβεί το ποσοστό δραστηριότητάς της.
        /// </summary>
        public override void Awaken()
        {
            isAsleep = false;
            if (random.Next(0, 2) == 0)
                ActivityPercentage++;
        }

        /// <summary>
        /// Η γάτα τρώει κανονικά το φαγητό της με κανονικό ρυθμό.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε φαγητό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, επιστρέφεται ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Eat(Bowl bowl)
        {
            if (!bowl.Containing.Equals("food"))
                throw new Exception("Eat() method can only be called on Bowls containing food");
            else
            {
                bowl.Capacity--;
                HungerPercentage--;
            }

            return bowl;
        }

        /// <summary>
        /// Η γάτα πίνει κανονικά νερό.
        /// </summary>
        /// <param name="bowl">Το μπωλ το οποίο θέλουμε να πάρουμε και να του αφαιρέσουμε φαγητό.</param>
        /// <returns>Το μεταχειρισμένο μπωλ, επιστρέφεται ώστε να αποθηκεύονται οι αλλαγές.</returns>
        public override Bowl Drink(Bowl bowl)
        {
            if (!bowl.Containing.Equals("water"))
                throw new Exception("Drink() method can only be called on Bowls containing water");
            else
            {
                bowl.Capacity--;
                ThirstPercentage--;
            }

            return bowl;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Type: Cat";
        }
    }
}
