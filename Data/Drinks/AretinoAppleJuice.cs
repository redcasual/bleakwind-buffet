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
    public class AretinoAppleJuice
    {
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

        private double price = 0.62;
        /// <summary>
        /// A property for the price of the drink that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 0.62;
                    return price;
                }

                else if (size == Size.Medium)
                {
                    price = 0.87;
                    return price;
                }

                else
                {
                    price = 1.01;
                    return price;
                }
            }
        }

        private uint calories = 44;
        /// <summary>
        /// A property for the calories in the drink that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 44;
                    return calories;
                }

                else if (size == Size.Medium)
                {
                    calories = 88;
                    return calories;
                }

                else
                {
                    calories = 132;
                    return calories;
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
        public List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        /// <summary>
        /// A function that overrides the original toString method in order to return the size and name of the drink
        /// </summary>
        /// <returns> the size and name of the drink </returns>
        public string toString()
        {
            return size + " Aretino Apple Juice";
        }
    }
}
