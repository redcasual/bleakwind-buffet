using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: ThugsTBone.cs
* Purpose: Create all the necessary properties for thugs t-bone in order to make a proper order
*/

namespace BleakwindBuffet.Data.Entrees
{
    public class ThugsTBone : Entree
    {
        /// <summary>
        /// A property to determine the price, this is static
        /// </summary>
        public override double Price => 6.44;
        /// <summary>
        /// A property to determine the calories, this is static
        /// </summary>
        public override uint Calories => 982;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders, this has none
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// A function that overrides the original toString method in order to return the entree
        /// </summary>
        /// <returns> the name of the entree </returns>
        public override string ToString()
        {
            return "Thugs T-Bone";
        }
    }
}
