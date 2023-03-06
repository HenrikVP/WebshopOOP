namespace WebshopOOP
{
    enum ProductType { GPU, CPU, Motherboard, RAM, Storage, Monitor, PSU, Case, Cooling}
    internal class Product
    {
        private double price;

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
        public ProductType ProductType { get; set; }
        public double Price {
            get
            { return price; }
                 
            set
            { 
                if (value < StockPrice) 
                    throw new Exception("Price too low. We need to MAKE money not LOSE money!"); 
                else price = value;
            } 
        }
        public double StockPrice { get; set; }

        public Product() { }
        public Product(string name, double stockPrice, double price, int stock, string description, ProductType productType )
        {
            Name = name;
            StockPrice = stockPrice;
            Price = price;
            Stock= stock;
            Description = description;
            ProductType = productType;
        }
        public override string ToString()
        {
            return $"{Name} {Price} {ProductType}";
        }
    }
}
