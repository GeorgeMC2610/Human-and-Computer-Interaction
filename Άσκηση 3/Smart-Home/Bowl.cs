using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    class Bowl
    {
        public static readonly int MaxCapacity = 100;
        public readonly string Containing;
        
        public int Capacity { get; set; }

        public Bowl(int type)
        {
            Capacity = 100;

            if (type == 0)
                Containing = "Water";
            else
                Containing = "Food";
        }

        public Bowl(int Capacity, int type)
        {
            this.Capacity = Capacity;

            if (type == 0)
                Containing = "Water";
            else
                Containing = "Food";
        }
    }
}
