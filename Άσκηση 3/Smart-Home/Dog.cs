using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    class Dog : Animal
    {
        private static string[] Names = { "Charlie", "Bella", "Max", "Buddy", "Luna", "Coco", "Ruby", "Milo", "Archie" };

        public Dog() : base()
        {
            name = Names[random.Next(0, Names.Length)];
        }

        //Ο σκύλος έχει πιθανότητα 50% να είναι πιο ζωηρός από την γάτα
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
