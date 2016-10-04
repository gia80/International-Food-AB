using RecipeProject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InputOuputClass
{
    public class ProductFileSystem
    {
        public string FilePath { get; set; }

        public ProductFileSystem(string filePath)
        {
            FilePath = filePath;
        }

        private void WriteProductToFile(List<Recipe> recipe)
        { //hejehaj
            try
            {
                using (StreamWriter w = new StreamWriter(FilePath))
                {
                    foreach (Recipe p in recipe)
                    {
                        //w.WriteLine("Firstname: " + p.Firstname, Encoding.Unicode);
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

        public void SerializeObject(List<Recipe> list)
        {
            var serializer = new XmlSerializer(typeof(List<Recipe>));
            using (var stream = File.OpenWrite(FilePath))
            {
                serializer.Serialize(stream, list);
            }
        }

        public List<Recipe>  Deserialize()
        {
            var serializer = new XmlSerializer(typeof(List<string>));
            using (var stream = File.OpenRead(FilePath))
            {
                List<Recipe> other = (List<Recipe>)(serializer.Deserialize(stream));

                return other;
            }
        }
    }
}