namespace Plastic.Molding
{
    public class Pallet
    {
        public ProductCollection Products { get; } = new ProductCollection();

        public void AddProduct(string name, string subDirectory, string filename, CodeWriter cw)
        {
            Products.Add(new Product { Name = name, SubDirectory = subDirectory, Filename = filename, Source = cw.ToString() });
        }

        public void Save(string path)
        {
            foreach (Product product in Products)
            {
                product.Save(path);
            }
        }
    }
}