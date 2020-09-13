using BleakwindBuffet.Data.Enums;
using BleakwindBuffet.Data.Drinks;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: SailorSoda.cs
* Purpose: Create all the necessary properties for sailor soda in order to make a proper order
*/

namespace BleakwindBuffet.Data.Drinks
{
    public class SailorSoda : Drink
    {
        private SodaFlavor flavor = SodaFlavor.Cherry;
        /// <summary>
        /// A property for the flavor of the drink that gets the flavor based on a private variable and sets the flavor based on input
        /// </summary>
        public SodaFlavor Flavor
        {
            get
            {
                return flavor;
            }

            set
            {
                flavor = value;
            }
        }

        /// <summary>
        ///  A property for the price of the drink that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 1.42;
                    case Size.Medium: return 1.74;
                    case Size.Large: return 2.07;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        /// <summary>
        /// A property for the calories in the drink that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 117;
                    case Size.Medium: return 153;
                    case Size.Large: return 205;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

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
                if(!value) specialInstructions.Add("Hold ice");
                else specialInstructions.Remove("Hold ice");
                ice = value;
            }
        }


        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie ice
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size, flaovr, and name of the drink
        /// </summary>
        /// <returns> the size, flavor, and name of the drink </returns>
        public override string ToString()
        {
            return Size + " " + flavor + " Sailor Soda";
        }
    }
}
