using System;
using System.Collections.Generic;
using System.Text;

namespace BleakwindBuffet.Data
{
    /// <summary>
    /// The base interface for all menu items
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price of item
        /// </summary>
        /// <value>
        /// In US Dollars
        /// </value>
        double Price { get; }
        /// <summary>
        /// Calories in item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Special Instructions to prepare item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}

