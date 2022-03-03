using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    public class FragileFurniture
    {
        private readonly string[] Types = { "curtain", "vase", "plate", "glass", "couch" };
        private readonly static Random random = new Random();

        public bool Broken { get; private set; }
        public string Type { get; private set; }

        public FragileFurniture()
        {
            Type = Types[random.Next(0, Types.Length)];
            Broken = false;
        }

        public void Repair()
        {
            Broken = false;
        }

        public override string ToString()
        {
            return "Class: Furniture, Type: " + Type;
        }
    }
}
