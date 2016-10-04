﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOuputClass
{
    public class ProductFileSystem
    {
        public string FilePath { get; set; }
 

       public  ProductFileSystem(string filePath)
        {
            FilePath = filePath;
        }
        private void WriteProductToFile(List<Recipe> recipe)
        { 
            try
            {
                using (StreamWriter w = new StreamWriter(FilePath))
                {
                    foreach (Recipe p in recipe)
                    {
                        w.WriteLine("", Encoding.Unicode);        
                        w.WriteLine("------------------------------------");
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void ReadProductFromFile()
        {
            try
            {
                using (StreamReader r = new StreamReader(FilePath))
                {
                    for (int i = 0; !r.EndOfStream; i++)
                    {
                        Recipe p = new Recipe();

                        string text = r.ReadLine();
                        //p.Firstname = text.Substring(text.IndexOf(":") + 1).Trim();
                        text = r.ReadLine();
                

                        r.ReadLine();
                     
                       // phonebook.Add(p);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

    }

    internal class Recipe
    {
    }
}