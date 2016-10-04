using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeProject
{
    public enum Product
    {
        meat, sallad, fish, dessert, soup
    }

        public class Recipe
        {
            public string Description { get; set; }
            public string Namerecipe { get; set; }
            public Product Product { get; set; }
        }

    }

