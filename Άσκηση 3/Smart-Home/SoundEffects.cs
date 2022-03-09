using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace Smart_Home
{
    /// <summary>
    /// Η κλάση αυτή έχει όλα τα <b>ηχητικά εφέ</b> που χρειαζόμαστε να παίζουμε.
    /// Έχουμε κάνει πολύ απλή την χρήση της και μπορούμε να παίζουμε με ασφάλεια όποιους ήχους υπάρχουν.
    /// </summary>
    public class SoundEffects
    {
        private static SoundPlayer Player = new SoundPlayer();

        /// <summary>
        /// Η μέθοδος παίζει τον ήχο, βλέποντας πρώτα αν υπάρχει το <paramref name="path"/> που ζητήσαμε. 
        /// </summary>
        /// <param name="path"></param>
        private static void InitiateSoundEffect(string path)
        {
            try
            {
                Player.SoundLocation = path;
                Player.Play();
            }
            catch (Exception e)
            {
                Console.WriteLine("Could not play sound " + path + "! See exception details.\n" + e.Message);
            }
        }

        public static void Curtain()
        {
            InitiateSoundEffect("sound/curtain.wav");
        }

        public static void Vase()
        {
            InitiateSoundEffect("sound/vase.wav");
        }

        public static void Couch()
        {
            InitiateSoundEffect("sound/couch.wav");
        }

        public static void Glass()
        {
            InitiateSoundEffect("sound/glass.wav");
        }

        public static void Plate()
        {
            InitiateSoundEffect("sound/plate.wav");
        }

        public static void Refill()
        {
            InitiateSoundEffect("sound/refill.wav");
        }

    }
}
