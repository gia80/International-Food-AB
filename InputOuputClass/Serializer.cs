using RecipeProject;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace InputOuputClass
{
    public class Serializer
    {
        public string FilePath { get; set; }

        public Serializer(string filePath)
        {
            FilePath = filePath;
        }

        public void SerializeRecipes(List<Recipe> list)
        {
            var serializer = new XmlSerializer(typeof(List<Recipe>));
            using (var stream = File.OpenWrite(FilePath))
            {
                serializer.Serialize(stream, list);
            }
        }

        public List<Recipe> DeserializeRecipes()
        {
            var serializer = new XmlSerializer(typeof(List<Recipe>));
            using (var stream = File.OpenRead(FilePath))
            {
                List<Recipe> other = (List<Recipe>)(serializer.Deserialize(stream));

                return other;
            }
        }
    }
}