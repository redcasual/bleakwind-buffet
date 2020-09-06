using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Zachery Brunner
* Class name: Something.cs
* Purpose: Create all the necessary properties for philly poacher in order to make a proper order
*/

namespace BleakwindBuffet.Data.Entrees
{
    public class PhillyPoacher
    {
        /// <summary>
        /// A property to determine the price, this is static
        /// </summary>
        public double Price => 7.23;
        /// <summary>
        /// A property to determine the calories, this is static
        /// </summary>
        public uint Calories => 784;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie sirloin
        /// </summary>
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        private bool sirloin = true;
        private bool onion = true;
        private bool roll = true;

        /// <summary>
        /// A boolean property for sirloin that determines whether the order should or should not have sirloin
        /// </summary>
        public bool Sirloin
        {
            get
            {
                return sirloin;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold sirloin");
                else specialInstructions.Remove("Hold sirloin");
                sirloin = value;
            }
        }
        /// <summary>
        /// A boolean property for onion that determines whether the order should or should not have onion
        /// </summary>
        public bool Onion
        {
            get
            {
                return onion;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold onions");
                else specialInstructions.Remove("Hold onions");
                onion = value;
            }
        }
        /// <summary>
        /// A boolean property for roll that determines whether the order should or should not have roll
        /// </summary>
        public bool Roll
        {
            get
            {
                return roll;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold roll");
                else specialInstructions.Remove("Hold roll");
                roll = value;
            }
        }
        /// <summary>
        /// A function that overrides the original toString method in order to return the entree
        /// </summary>
        /// <returns> the name of the entree </returns>
        public override string ToString()
        {
            return "Philly Poacher";
        }
    }
}
