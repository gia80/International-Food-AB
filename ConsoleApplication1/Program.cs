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
            re.Namerecipe = "Min Lasange";
            re.Product = Product.dessert;


            List<Recipe> list = new List<Recipe>();
            list.Add(re);


            cl.SerializeRecipes(list);




            List<Recipe> testlist = cl.DeserializeRecipes();


        }
    }
}
