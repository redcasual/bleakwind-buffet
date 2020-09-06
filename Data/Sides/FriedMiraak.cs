using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: FriedMiraak.cs
* Purpose: Create all the necessary properties for fried miraak in order to make a proper order
*/

namespace BleakwindBuffet.Data.Sides
{
    public class FriedMiraak
    {
        private Size size = Size.Small;
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

        private double price = 1.78;
        /// <summary>
        /// A property for the price of the side that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 1.78;
                    return price;
                }

                else if (size == Size.Medium)
                {
                    price = 2.01;
                    return price;
                }

                else
                {
                    price = 2.88;
                    return price;
                }
            }
        }

        private uint calories = 151;
        /// <summary>
        /// A property for the calories in the side that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 151;
                    return calories;
                }

                else if (size == Size.Medium)
                {
                    calories = 236;
                    return calories;
                }

                else
                {
                    calories = 306;
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
            return size + " Fried Miraak";
        }
    }
}
