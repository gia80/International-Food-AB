using System;

namespace RecipeProject
{
    public enum Product
    {
        meat, sallad, fish, dessert, soup
    }

    [Serializable]
    public class Recipe
    {
        public string Description { get; set; }
        public string Namerecipe { get; set; }
        public Product Product { get; set; }
    }
}