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
    public class SailorSoda
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

        private double price = 1.42;
        /// <summary>
        ///  A property for the price of the drink that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public double Price
        {
            get
            {
                if(size == Size.Small)
                {
                    price = 1.42;
                    return price;
                }

                else if(size == Size.Medium)
                {
                    price = 1.74;
                    return price;
                }

                else
                {
                    price = 2.07;
                    return price;
                }
            }
        }

        private uint calories = 117;
        /// <summary>
        /// A property for the calories in the drink that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if(size == Size.Small)
                {
                    calories = 117;
                    return calories;
                }

                else if(size == Size.Medium)
                {
                    calories = 153;
                    return calories;
                }

                else
                {
                    calories = 205;
                    return calories;
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
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size, flaovr, and name of the drink
        /// </summary>
        /// <returns> the size, flavor, and name of the drink </returns>
        public override string ToString()
        {
            return size + " " + flavor + " Sailor Soda";
        }
    }
}
