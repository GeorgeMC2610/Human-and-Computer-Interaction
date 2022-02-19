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
            this.Name = Names[random.Next(0, Names.Length)];
        }

    }
}
