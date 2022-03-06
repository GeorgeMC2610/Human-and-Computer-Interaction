using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Smart_Home
{
    public class SoundEffects
    {
        private static SoundPlayer Player = new SoundPlayer();

        public static void Curtain()
        {
            Player.SoundLocation = "sound/curtain.wav";
            Player.Play();
        }

        public static void Vase()
        {
            Player.SoundLocation = "sound/vase.wav";
            Player.Play();
        }

        public static void Couch()
        {
            Player.SoundLocation = "sound/couch.wav";
            Player.Play();
        }


    }
}
