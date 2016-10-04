using InputOuputClass;
using RecipeProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = Environment.CurrentDirectory + @"\test.xml";
            Serializer cl = new Serializer(path);


            Recipe re = new Recipe();
            re.Description = "Laga si elle så";
            re.Title = "Min Lasange";
            re.Product = Product.dessert;


            Recipe re2 = new Recipe();
            re2.Description = "En annan beskrivning";
            re2.Title = "Min pizza";
            re2.Product = Product.fish;


            List<Recipe> list = new List<Recipe>();
            list.Add(re);
            list.Add(re2);


            cl.SerializeRecipes(list);




            List<Recipe> testlist = cl.DeserializeRecipes();


        }
    }
}
