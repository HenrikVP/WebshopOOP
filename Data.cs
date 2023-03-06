namespace WebshopOOP
{
    internal class Data
    {
        public List<Product> Products = new();
        public Data()
        {
            AddProducts();
        }
        public void AddProducts()
        {
            Products.Add(new Product("Nvidia RTX4090", 12000, 15999, 4, "The Best money can get. Can play minesweeper in 8K!", ProductType.GPU));
            Products.Add(new Product("Radeon RX 6700 XT", 3000, 4999, 4000, "Good Value for money. Almost always FPS>1", ProductType.GPU));
        }
    }
}
