using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: CandlehearthCoffee.cs
* Purpose: Create all the necessary properties for candelhearth coffee in order to make a proper order
*/

namespace BleakwindBuffet.Data.Drinks
{
    public class CandlehearthCoffee
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

        private double price = 0.75;
        /// <summary>
        /// A property for the price of the drink that gets the price based on a private variable and sets the price based on inputs
        /// </summary>
        public double Price
        {
            get
            {
                if (size == Size.Small)
                {
                    price = 0.75;
                    return price;
                }

                else if (size == Size.Medium)
                {
                    price = 1.25;
                    return price;
                }

                else
                {
                    price = 1.75;
                    return price;
                }
            }
        }

        private uint calories = 7;
        /// <summary>
        /// A property for the calories in the drink that gets the calories based on a private variable and sets the calories based on input
        /// </summary>
        public uint Calories
        {
            get
            {
                if (size == Size.Small)
                {
                    calories = 7;
                    return calories;
                }

                else if (size == Size.Medium)
                {
                    calories = 10;
                    return calories;
                }

                else
                {
                    calories = 20;
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

        private bool roomforcream = false;
        /// <summary>
        /// A boolean property for cream that determines whether the order should or should not have cream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomforcream;
            }

            set
            {
                if (value) specialInstructions.Add("Add cream");
                else specialInstructions.Remove("Add cream");
                roomforcream = value;
            }
        }

        private bool decaf = false;
        /// <summary>
        /// A boolean property for decaf that determines whether the order should or should not be decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }

            set
            {
                decaf = value;
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
        /// A function that overrides the original toString method in order to return the size and name of the drink and if it is decaf
        /// </summary>
        /// <returns> The size and name of the drink and if it is decaf </returns>
        public override string ToString()
        {
            if(decaf)
            {
                return size + " Decaf Candlehearth Coffee";
            }

            else
            {
                return size + " Candlehearth Coffee";
            }
        }
    }
}
