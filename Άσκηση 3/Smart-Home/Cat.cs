﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Home
{
    class Cat : Animal
    {
        //Τυχαία ονόματα γάτας.
        private static string[] Names = { "Jack", "Loki", "Jasper", "Garfield", "Simba", "Soozie", "Ellie", "Raymond", "Lucy", "Kitty"};

        //Όπως και στον σκύλο, έτσι και στην γάτα το όνομα είναι τυχαίο.
        public Cat() : base()
        {
            name = Names[random.Next(0, Names.Length)];
        }
        
        /// <summary>
        /// Μία γάτα είναι λιγότερο πιθανό να κάνει ζημιά από έναν σκύλο. Οπότε, κάθε φορά που καλείται η μέθοδος, υπάρχει 50% πιθανότητα να ανεβεί το ποσοστό δραστηριότητάς της.
        /// </summary>
        public override void Awaken()
        {
            Asleep = false;
            if (random.Next(0, 2) == 0)
                ActivityPercentage++;
        }

        public override string ToString()
        {
            return "Name: " + this.Name + ", Type: Cat";
        }
    }
}
