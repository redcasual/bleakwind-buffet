using System;
using System.Collections.Generic;
using System.Text;

/*
* Author: Mitch Higgins
* Class name: GardenOrcOmelette.cs
* Purpose: Create all the necessary properties for garden orc omelette in order to make a proper order
*/

namespace BleakwindBuffet.Data.Entrees
{
    public class GardenOrcOmelette : Entree
    {
        /// <summary>
        /// A property to determine the price, this is static
        /// </summary>
        public override double Price => 4.57;
        /// <summary>
        /// A property to determine the calories, this is static
        /// </summary>
        public override uint Calories => 404;

        private List<string> specialInstructions = new List<string>();
        /// <summary>
        /// A string list property that contains all special orders ie broccoli
        /// </summary>
        public override List<String> SpecialInstructions
        {
            get => new List<string>(specialInstructions);
        }

        private bool broccoli = true;
        private bool mushrooms = true;
        private bool tomato = true;
        private bool cheddar = true;

        /// <summary>
        /// A boolean property for broccoli that determines whether the order should or should not have a broccoli
        /// </summary>
        public bool Broccoli
        {
            get
            {
                return broccoli;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold broccoli");
                else specialInstructions.Remove("Hold broccoli");
                broccoli = value;
            }
        }
        /// <summary>
        /// A boolean property for mushrooms that determines whether the order should or should not have a mushrooms
        /// </summary>
        public bool Mushrooms
        {
            get
            {
                return mushrooms;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold mushrooms");
                else specialInstructions.Remove("Hold mushrooms");
                mushrooms = value;
            }
        }
        /// <summary>
        /// A boolean property for tomato that determines whether the order should or should not have a tomato
        /// </summary>
        public bool Tomato
        {
            get
            {
                return tomato;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold tomato");
                else specialInstructions.Remove("Hold tomato");
                tomato = value;
            }
        }
        /// <summary>
        /// A boolean property for cheddar that determines whether the order should or should not have a cheddar
        /// </summary>
        public bool Cheddar
        {
            get
            {
                return cheddar;
            }

            set
            {
                if (!value) specialInstructions.Add("Hold cheddar");
                else specialInstructions.Remove("Hold cheddar");
                cheddar = value;
            }
        }
        /// <summary>
        /// A function that overrides the original toString method in order to return the entree
        /// </summary>
        /// <returns> the name of the entree </returns>
        public override string ToString()
        {
            return "Garden Orc Omelette";
        }
    }


}
