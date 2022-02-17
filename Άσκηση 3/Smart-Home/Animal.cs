using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    abstract class Animal
    {
        private static Random random = new Random();

        public bool Asleep { get; set; }

        private int HungerPercentage;
        private int ActivityPercentage;

        public Animal()
        {
            HungerPercentage   = 0;
            ActivityPercentage = 0;
        }

        public void FallAsleep()
        {
            ActivityPercentage = 0;
            Asleep = true;
        }

        public void Awaken()
        {
            ActivityPercentage++;
            Asleep = false;
        }

        public void ManageHunger()
        {
            if (ActivityPercentage == 0)
            {
                if (random.Next(0, 2) == 0)
                    HungerPercentage--;
            }
            else if (ActivityPercentage == 1)
            {
                if (random.Next(0, 6) <= 3)
                    HungerPercentage--;
            }
            else
                HungerPercentage--;
        }
    }
}
