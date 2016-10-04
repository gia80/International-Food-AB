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
            public string Title { get; set; }
            public Product Product { get; set; }
    }


    //Recipe sök = new Recipe();

    //List<Recipe> resultat = Product.Where(a => a.Rubrik.ToLower().Contains(textBox1.Text)).ToList();
    //        //Loopar
    //        foreach ( Product food in resultat)
    //        {
    //                textBox1.Items.Add(Produt);
    //        }
}



