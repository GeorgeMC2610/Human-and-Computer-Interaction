using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    public class FragileFurniture
    {
        public bool Broken { get; set; }
        private string type;
        private string[] types = { "curtain", "vase", "plate", "glass", "couch" };
        private static Random random = new Random();

        public string Type { get { return type; } }

        public FragileFurniture()
        {
            type = types[random.Next(0, types.Length)];
            Broken = false;
        }

        public override string ToString()
        {
            return "Class: Furniture, Type: " + Type;
        }
    }
}
