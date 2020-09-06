using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: MarkarthMilk.cs
* Purpose: Create all the necessary properties for markarth milk in order to make a proper order
*/

namespace BleakwindBuffet.Data.Drinks
{
    public class MarkarthMilk
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

        private double price = 1.05;
        /// <summary>
        /// A property for the price of the drink that gets the price based on a private variable and sets the price based on input
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 1.05;
                    return price;
                }

                else if (size == Size.Medium)
                {
                    price = 1.11;
                    return price;
                }

                else
                {
                    price = 1.22;
                    return price;
                }
            }
        }

        private uint calories = 56;
        /// <summary>
        /// A property for the calories in the drink that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 56;
                    return calories;
                }

                else if (size == Size.Medium)
                {
                    calories = 72;
                    return calories;
                }

                else
                {
                    calories = 93;
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
        /// <returns> the name of the drink and its size </returns>
        public override string ToString()
        {
            return size + " Markarth Milk";
        }
    }
}
