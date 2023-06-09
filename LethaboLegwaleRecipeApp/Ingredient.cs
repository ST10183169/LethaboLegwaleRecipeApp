﻿namespace LethaboLegwaleRecipeApp
{
    public class Ingredient
    {
        public string Name { get; set; }
        public double Quantity { get; set; }
        public string Unit { get; set; }

        public override string ToString()
        {
            return $"{Quantity} {Unit} {Name}";
        }
    }
}