using BleakwindBuffet.Data.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data.Entrees
{
    /// <summary>
    /// A base class representing common properties of entrees
    /// </summary>
    public abstract class Entree : IOrderItem 
    {
        /// <summary>
        /// Price of entree
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        public abstract double Price { get; }
        /// <summary>
        /// Calories in entree
        /// </summary>
        public abstract uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
