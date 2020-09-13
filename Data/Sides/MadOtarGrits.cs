using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: MadOtarGrits.cs
* Purpose: Create all the necessary properties for mad otar grits in order to make a proper order
*/

namespace BleakwindBuffet.Data.Sides
{
    public class MadOtarGrits : Side
    {
        /// <summary>
        /// A property for the price of the side that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.22;
                    case Size.Medium: return 1.58;
                    case Size.Large: return 1.93;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// A property for the calories in the side that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 105;
                    case Size.Medium: return 142;
                    case Size.Large: return 179;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie bun
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size and name of the side
        /// </summary>
        /// <returns> the size and name of the side </returns>
        public override string ToString()
        {
            return Size + " Mad Otar Grits";
        }
    }
}
