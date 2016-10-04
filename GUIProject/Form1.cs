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



        }

        private void comBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btNew_Click(object sender, EventArgs e)
        {
           string newrecipe = new recipe();




        }
    }
}
