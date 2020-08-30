﻿using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: ThugsTBone.cs
* Purpose: Create all the necessary properties for thugs t-bone in order to make a proper order
*/

namespace BleakwindBuffet.Data.Entrees
{
    class ThugsTBone
    {
        /// <summary>
        /// A property to determine the price, this is static
        /// </summary>
        public double Price => 6.44;
        /// <summary>
        /// A property to determine the calories, this is static
        /// </summary>
        public uint Calories => 982;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders, this has none
        /// </summary>
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }
        /// <summary>
        /// A function that overrides the original toString method in order to return the entree
        /// </summary>
        /// <returns> the name of the entree </returns>
        String toString()
        {
            return "Thugs T-Bone";
        }
    }
}
