namespace WebshopOOP
{
    internal class Data
    {
        public List<Product> Products = new();
        public void AddProducts()
        {
            Products.Add(new Product("Nvidia RTX4090", 12000, 15999, 4, "The Best money can get. Can play minesweeper in 8K!"));
        }
    }
}
