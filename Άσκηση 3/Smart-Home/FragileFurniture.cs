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

        public void Break()
        {
            switch (Type)
            {
                case "curtain":
                    SoundEffects.Curtain();
                    break;
                case "vase":
                    SoundEffects.Vase();
                    break;
                case "plate":
                    SoundEffects.Plate();
                    break;
                case "glass":
                    SoundEffects.Glass();
                    break;
                case "couch":
                    SoundEffects.Couch();
                    break;
            }

            Broken = true;
        }

        public override string ToString()
        {
            return "Class: Furniture, Type: " + Type;
        }
    }
}
