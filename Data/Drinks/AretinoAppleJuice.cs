using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: AretinoAppleJuice.cs
* Purpose: Create all the necessary properties for aretino apple juice in order to make a proper order
*/

namespace BleakwindBuffet.Data.Drinks
{
    public class AretinoAppleJuice : Drink
    {
        /// <summary>
        /// A property for the price of the drink that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small: return 0.62;
                    case Size.Medium: return 0.87;
                    case Size.Large: return 1.01;
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
                switch(Size)
                {
                    case Size.Small: return 44;
                    case Size.Medium: return 88;
                    case Size.Large: return 132;
                    default: throw new NotImplementedException("Should never be reached");
                }
            }
        }

        private bool ice = false;
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
                if (value) specialInstructions.Add("Add ice");
                else specialInstructions.Remove("Add ice");
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
        /// A function that overrides the original toString method in order to return the size and name of the drink
        /// </summary>
        /// <returns> the size and name of the drink </returns>
        public override string ToString()
        {
            return Size + " Aretino Apple Juice";
        }
    }
}
