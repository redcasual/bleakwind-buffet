using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: VokunSalad.cs
* Purpose: Create all the necessary properties for vokun salad in order to make a proper order
*/

namespace BleakwindBuffet.Data.Sides
{
    class VokunSalad
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

        private double price = 0.93;
        /// <summary>
        /// A property for the price of the side that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 0.93;
                    return price;
                }

                else if (size == Size.Medium)
                {
                    price = 1.28;
                    return price;
                }

                else
                {
                    price = 1.82;
                    return price;
                }
            }
        }

        private uint calories = 31;
        /// <summary>
        /// A property for the calories in the side that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 31;
                    return calories;
                }

                else if (size == Size.Medium)
                {
                    calories = 52;
                    return calories;
                }

                else
                {
                    calories = 73;
                    return calories;
                }
            }
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size and name of the side
        /// </summary>
        /// <returns> the size and name of the side </returns>
        public string toString()
        {
            return size + " Vokun Salad";
        }
    }
}
