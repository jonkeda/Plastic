using System.IO;

namespace Plastic.Molding
{
    public class Product
    {
        public string SubDirectory { get; set; }

        public string Filename { get; set; }

        public string Name { get; set; }

        public string Source { get; set; }

        public void Save(string directoryPath)
        {
            string folder = Path.Combine(directoryPath, SubDirectory);
            Directory.CreateDirectory(folder);
            string fullName = Path.Combine(folder, Filename);
            File.WriteAllText(fullName, Source);
        }
    }
}