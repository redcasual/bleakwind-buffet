using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: DragonbornWaffleFries.cs
* Purpose: Create all the necessary properties for dragonborn waffle fries in order to make a proper order
*/

namespace BleakwindBuffet.Data.Sides
{
    public class DragonbornWaffleFries
    {
        private Size size= Size.Small;
        /// <summary>
        /// A property for the size of the side that gets the size based on a private variable and sets the size based on input
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

        private double price = 0.42;
        /// <summary>
        /// A property for the price of the side that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 0.42;
                    return price;
                }

                else if (size == Size.Medium)
                {
                    price = 0.76;
                    return price;
                }

                else
                {
                    price = 0.96;
                    return price;
                }
            }
        }

        private uint calories = 77;
        /// <summary>
        /// A property for the calories in the side that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 77;
                    return calories;
                }

                else if (size == Size.Medium)
                {
                    calories = 89;
                    return calories;
                }

                else
                {
                    calories = 100;
                    return calories;
                }
            }
        }

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie bun
        /// </summary>
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size and name of the side
        /// </summary>
        /// <returns> the size and name of the side </returns>
        public override string ToString()
        {
            return size + " Dragonborn Waffle Fries";
        }
    }
}
