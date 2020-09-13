using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: SmokeHouseSkeleton.cs
* Purpose: Create all the necessary properties for smokehouse skeleton in order to make a proper order
*/

namespace BleakwindBuffet.Data.Entrees
{
    public class SmokehouseSkeleton : Entree
    {
        /// <summary>
        /// A property to determine the price, this is static
        /// </summary>
        public override double Price => 5.62;
        /// <summary>
        /// A property to determine the calories, this is static
        /// </summary>
        public override uint Calories => 602;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie sausage links
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        private bool sausagelink = true;
        private bool egg = true;
        private bool hashbrowns = true;
        private bool pancake = true;

        /// <summary>
        /// A boolean property for sausage links that determines whether the order should or should not have sausage links
        /// </summary>
        public bool SausageLink
        {
            get
            {
                return sausagelink;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold sausage");
                else specialInstructions.Remove("Hold sausage");
                sausagelink = value;
            }
        }
        /// <summary>
        /// A boolean property for eggs that determines whether the order should or should not have an egg
        /// </summary>
        public bool Egg
        {
            get
            {
                return egg;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold eggs");
                else specialInstructions.Remove("Hold eggs");
                egg = value;
            }
        }
        /// <summary>
        /// A boolean property for hash browns that determines whether the order should or should not have hash browns
        /// </summary>
        public bool HashBrowns
        {
            get
            {
                return hashbrowns;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold hash browns");
                else specialInstructions.Remove("Hold hash browns");
                hashbrowns = value;
            }
        }
        /// <summary>
        /// A boolean property for pancake that determines whether the order should or should not have a pancake
        /// </summary>
        public bool Pancake
        {
            get
            {
                return pancake;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold pancakes");
                else specialInstructions.Remove("Hold pancakes");
                pancake = value;
            }
        }
        /// <summary>
        /// A function that overrides the original toString method in order to return the entree
        /// </summary>
        /// <returns> the name of the entree </returns>
        public override string ToString()
        {
            return "Smokehouse Skeleton";
        }
    }
}
