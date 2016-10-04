using InputOuputClass;
using RecipeProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIProject
{
    public partial class Form1 : Form
    {

        private List<Recipe> recipes;
        private Serializer serializer;

        public string FilePath {get; set;}
        public Form1()
        {
            InitializeComponent();
             
            FilePath =  Environment.CurrentDirectory + @"\Databas.xml";
            serializer = new Serializer(FilePath);
            recipes = serializer.DeserializeRecipes();


            //Enum binding
            comBox.DataSource = Enum.GetValues(typeof(Product));

        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var item in Enum.GetValues(typeof()))
            {
                comBox.Items.Add(item.ToString());
            }
        }
         
        /// <summary>
        /// 
        /// </summary>
        /// <param name="product"></param>
        private void PopulateListBox(Product product)
        {
            //Tömmer den gamla listan
            listRecept.Items.Clear();

            foreach (Recipe r in recipes)
            {
                //Väljer endast att vissa en kategori
                if (r.Product == product)
                {
                    listRecept.Items.Add(r);
                }

            } 

        }

        private void listRecept_SelectedIndexChanged(object sender, EventArgs e)
        {
            Recipe r = (Recipe)listRecept.SelectedItem;
            

        }



    }
}
