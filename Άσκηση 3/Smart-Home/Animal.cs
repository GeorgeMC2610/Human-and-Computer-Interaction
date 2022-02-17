using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    abstract class Animal
    {
        public bool Asleep { get; private set; }
        
        private int HungerPercentage;
        private int ActivityPercentage;


    }
}
