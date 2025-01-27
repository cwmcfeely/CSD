using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aliens.Models
{
    internal class Alien
    {
        // Properties
        public bool Dead { get; set; }
        public bool Dodging { get; set; }
        public int Health { get; set; }

        // Class constructor
        public Alien(bool dodging, int alienHealth)
        {
            //TODO: Construct the Alien object and initialise the data members appropriately.

        }

        // Methods
        //TODO: Implement appropriate getters and setters for the class

        public void Dodge()
        {
            //TODO: Implement the method
            /*Set dodging to true if the alien is alive*/

        }

        public void Hit()
        {
            //TODO: Implement the method
            /*Reduces the alien health by 1. Minimum Alien health should 0.*/
        }

        public void Miss()
        {
            //TODO: Implement the method
            /*Sets dodging to false*/

        }

    }
}
