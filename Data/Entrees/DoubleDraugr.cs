using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: DoubleDraugr.cs
* Purpose: Create all the necessary properties for double braugr in order to make a proper order
*/

namespace BleakwindBuffet.Data.Entrees
{
    public class DoubleDraugr
    {
        /// <summary>
        /// A property to determine the price, this is static
        /// </summary>
        public double Price => 7.32;
        /// <summary>
        /// A property to determine the calories, this is static
        /// </summary>
        public uint Calories => 843;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie bun
        /// </summary>
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        private bool bun = true;
        private bool ketchup = true;
        private bool mustard = true;
        private bool pickle = true;
        private bool cheese = true;
        private bool tomato = true;
        private bool lettuce = true;
        private bool mayo = true;

        /// <summary>
        /// A boolean property for bun that determines whether the order should or should not have a bun
        /// </summary>
        public bool Bun
        {
            get
            {
                return bun;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold bun");
                else specialInstructions.Remove("Hold bun");
                bun = value;
            }
        }
        /// <summary>
        /// A boolean property for ketchup that determines whether the order should or should not have ketchup
        /// </summary>
        public bool Ketchup
        {
            get
            {
                return ketchup;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold ketchup");
                else specialInstructions.Remove("Hold ketchup");
                ketchup = value;
            }
        }
        /// <summary>
        /// A boolean property for mustard that determines whether the order should or should not have mustard
        /// </summary>
        public bool Mustard
        {
            get
            {
                return mustard;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold mustard");
                else specialInstructions.Remove("Hold mustard");
                mustard = value;
            }
        }
        /// <summary>
        /// A boolean property for pickle that determines whether the order should or should not have pickle
        /// </summary>
        public bool Pickle
        {
            get
            {
                return pickle;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold pickle");
                else specialInstructions.Remove("Hold pickle");
                pickle = value;
            }
        }
        /// <summary>
        /// A boolean property for cheese that determines whether the order should or should not have cheese
        /// </summary>
        public bool Cheese
        {
            get
            {
                return cheese;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold cheese");
                else specialInstructions.Remove("Hold cheese");
                cheese = value;
            }
        }
        /// <summary>
        /// A boolean property for tomato that determines whether the order should or should not have tomato
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else specialInstructions.Remove("Hold tomato");
                tomato = value;
            }
        }
        /// <summary>
        /// A boolean property for lettuce that determines whether the order should or should not have lettuce
        /// </summary>
        public bool Lettuce
        {
            get
            {
                return lettuce;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold lettuce");
                else specialInstructions.Remove("Hold lettuce");
                lettuce = value;
            }
        }
        /// <summary>
        /// A boolean property for mayo that determines whether the order should or should not have mayo
        /// </summary>
        public bool Mayo
        {
            get
            {
                return mayo;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold mayo");
                else specialInstructions.Remove("Hold mayo");
                mayo = value;
            }
        }
        /// <summary>
        /// A function that overrides the original toString method in order to return the entree
        /// </summary>
        /// <returns> the name of the entree </returns>
        public override string ToString()
        {
            return "Double Draugr";
        }
    }
}
