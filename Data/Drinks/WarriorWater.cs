using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: WarriorWater.cs
* Purpose: Create all the necessary properties for warrior water in order to make a proper order
*/

namespace BreakwindBuffet.Data.Drinks
{
    class WarriorWater
    {
        private Size size = Size.Small;
        /// <summary>
        /// A property for the size of the drink that gets the size based on a private variable and sets the size based on input
        /// </summary>
        public Size Size
        {
            get
            {
                return size;
            }

            set
            {
                size = value;
            }
        }

        /// <summary>
        /// A property that determines the price, this one is static
        /// </summary>
        public double Price => 0.0;

        /// <summary>
        /// A property that determines the calories, this one is static
        /// </summary>
        public uint Calories => 0;

        private bool ice = true;
        /// <summary>
        /// A boolean property for ice that determines whether the order should or should not have ice
        /// </summary>
        public bool Ice
        {
            get
            {
                return ice;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold ice");
                else specialInstructions.Remove("Hold ice");
                ice = value;
            }
        }

        private bool lemon = false;
        /// <summary>
        /// A boolean property for lemon that determines whether the order should or should not have lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }

            set
            {
                if (value) specialInstructions.Add("Add lemon");
                else specialInstructions.Remove("Add lemon");
                lemon = value;
            }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie ice
        /// </summary>
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size and name of the drink
        /// </summary>
        /// <returns> the size and name of the drink </returns>
        public string toString()
        {
            return size + " Warrior Water";
        }
    }
}
