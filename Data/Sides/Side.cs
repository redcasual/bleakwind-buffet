using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Sides
{
    /// <summary>
    /// A base class representing common properties of sides
    /// </summary>
    public abstract class Side : IOrderItem
    {
        /// <summary>
        /// Size of side
        /// </summary>
        public virtual Size Size { get; set; }
        /// <summary>
        /// Price of side
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in side
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare side
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
