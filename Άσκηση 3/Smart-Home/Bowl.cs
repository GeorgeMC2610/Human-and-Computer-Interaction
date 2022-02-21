using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    public class Bowl
    {
        public static readonly int MaxCapacity = 100;
        public readonly string Containing;
        
        public int Capacity { get; set; }

        /// <summary>
        /// Μπωλ για νερό ή φαΐ. Ανάλογα με το τι <paramref name="water"/> έχουμε βάλει.
        /// </summary>
        /// <param name="type">0 για νερό, 1 για φαΐ.</param>
        public Bowl(bool water)
        {
            Capacity = 100;

            if (water)
                Containing = "water";
            else
                Containing = "food";
        }

        public Bowl(int Capacity, bool water)
        {
            this.Capacity = Capacity;

            if (water)
                Containing = "water";
            else
                Containing = "food";
        }
    }
}
